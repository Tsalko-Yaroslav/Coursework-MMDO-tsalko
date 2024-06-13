using System;
using System.Collections.Generic;
using System.Linq;

namespace Mmdo.main.module
{
    public enum TableAnswerType { Unbounded, Found, NoSolve }

    public class Simplex
    {
        Function function;

        double[] functionVariables;
        double[][] matrix;
        double[] b;
        bool[] m;
        double[] M;
        double[] F;
        int[] C;
        bool mBool = false;


        public Simplex(Function function, Constraint[] constraints)
        {
            if (function.isExtrMax)
            {
                this.function = function;
            }
            else
            {
                this.function = Canonize(function);
            }

            getMatrix(constraints);
            getFunctionArray();
            CalculateBottomRow();

            for (int i = 0; i < F.Length; i++)
            {
                F[i] = -functionVariables[i];
            }

        }

        public Tuple<List<Iteration>, TableAnswerType> GetIterations()
        {
            List<Iteration> list = new List<Iteration>();

            var initTable = new Iteration(b, matrix, M, F, C, functionVariables, mBool, m);
            list.Add(initTable);

            MainElement pivot = FindMainElement();
            int i = 0;

            while (pivot.result == TableAnswerType.NoSolve && i < 100)
            {
                CalculateIteration(pivot.index);
                Iteration table = new Iteration(b, matrix, M, F, C, functionVariables, mBool, m);
                pivot = FindMainElement();

                list.Add(table);
                i++;
            }

            return new Tuple<List<Iteration>, TableAnswerType> (list, pivot.result);
        }

        void CalculateIteration(Tuple<int, int> pivotElementIndices)
        {
            double[][] updatedMatrix = new double[matrix.Length][];

            C[pivotElementIndices.Item2] = pivotElementIndices.Item1;

            double[] newRowForJ = new double[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                newRowForJ[i] = matrix[i][pivotElementIndices.Item2] / matrix[pivotElementIndices.Item1][pivotElementIndices.Item2];
            }

            double[] updatedB = new double[b.Length];

            for (int i = 0; i < b.Length; i++)
            {
                if (i == pivotElementIndices.Item2)
                {
                    updatedB[i] = b[i] / matrix[pivotElementIndices.Item1][pivotElementIndices.Item2];
                }
                else
                {
                    updatedB[i] = b[i] - b[pivotElementIndices.Item2] / matrix[pivotElementIndices.Item1][pivotElementIndices.Item2] * matrix[pivotElementIndices.Item1][i];
                }
            }

            b = updatedB;

            for (int i = 0; i < matrix.Length; i++)
            {
                updatedMatrix[i] = new double[C.Length];
                for (int j = 0; j < C.Length; j++)
                {
                    if (j == pivotElementIndices.Item2)
                    {
                        updatedMatrix[i][j] = newRowForJ[i];
                    }
                    else
                    {
                        updatedMatrix[i][j] = matrix[i][j] - newRowForJ[i] * matrix[pivotElementIndices.Item1][j];
                    }
                }
            }

            matrix = updatedMatrix;
            CalculateBottomRow();
        }


        void CalculateBottomRow()
        {
            M = new double[matrix.Length];
            F = new double[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                double sumF = 0;
                double sumM = 0;
                for (int j = 0; j < matrix.First().Length; j++)
                {
                    if (m[C[j]])
                    {
                        sumM -= matrix[i][j];
                    }
                    else
                    {
                        sumF += functionVariables[C[j]] * matrix[i][j];
                    }
                }
                M[i] = m[i] ? sumM + 1 : sumM;
                F[i] = sumF - functionVariables[i];
            }
        }

        MainElement FindMainElement()
        {
            int columnMIndex = FindCol(M);

            if (mBool || columnMIndex == -1)
            {
                mBool = true;
                int columnFIndex = FindCol(F);

                if (columnFIndex != -1)
                {
                    int rowIndex = FindRow(matrix[columnFIndex], b);

                    if (rowIndex != -1)
                        return new MainElement(new Tuple<int, int>(columnFIndex, rowIndex), TableAnswerType.NoSolve);
                    else
                        return new MainElement(null, TableAnswerType.Unbounded);
                }
                else
                    return new MainElement(null, TableAnswerType.Found);
            }
            else
            {
                int rowIndex = FindRow(matrix[columnMIndex], b);

                if (rowIndex != -1)
                    return new MainElement(new Tuple<int, int>(columnMIndex, rowIndex), TableAnswerType.NoSolve);
                else
                    return new MainElement(null, TableAnswerType.Unbounded);
            }
        }


        int FindCol(double[] array)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (!mBool || mBool && !m[i])
                    {
                        if (index == -1)
                        {
                            index = i;
                        }
                        else if (Math.Abs(array[i]) > Math.Abs(array[index]))
                        {
                            index = i;
                        }
                    }

                }
            }
            return index;
        }

        int FindRow(double[] column, double[] b)
        {
            int index = -1;

            for (int i = 0; i < column.Length; i++)
            {
                if (column[i] > 0 && b[i] > 0)
                {
                    if (index == -1)
                    {
                        index = i;
                    }
                    else if (b[i] / column[i] < b[index] / column[index])
                    {
                        index = i;
                    }
                }
            }

            return index;
        }

        public void getFunctionArray()
        {
            double[] funcVars = new double[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                funcVars[i] = i < function.variables.Length ? function.variables[i] : 0;
            }
            this.functionVariables = funcVars;
        }

        public Function Canonize(Function function)
        {
            double[] newFuncVars = new double[function.variables.Length];

            for (int i = 0; i < function.variables.Length; i++)
            {
                newFuncVars[i] = -function.variables[i];
            }
            return new Function(newFuncVars, true);
        }

        double[][] appendColumn(double[][] matrix, double[] column)
        {
            double[][] newMatrix = new double[matrix.Length + 1][];
            for (int i = 0; i < matrix.Length; i++)
            {
                newMatrix[i] = matrix[i];
            }
            newMatrix[matrix.Length] = column;
            return newMatrix;
        }

        T[] append<T>(T[] array, T element)
        {
            T[] newArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = element;
            return newArray;
        }

        double[] getColumn(double value, int place, int length)
        {
            double[] newColumn = new double[length];

            for (int k = 0; k < length; k++)
            {
                newColumn[k] = k == place ? value : 0;
            }

            return newColumn;
        }

        public void getMatrix(Constraint[] constraints)
        {
            for (int i = 0; i < constraints.Length; i++)
            {
                if (constraints[i].right < 0)
                {
                    double[] negatedLeftVars = new double[constraints[i].left.Length];

                    for (int j = 0; j < constraints[i].left.Length; j++)
                    {
                        negatedLeftVars[j] = -constraints[i].left[j];
                    }

                    string sign = constraints[i].sign;

                    if (sign == ">=")
                    {
                        sign = "<=";
                    }
                    else if (sign == "<=")
                    {
                        sign = ">=";
                    }

                    Constraint negatedConstraint = new Constraint(negatedLeftVars, -constraints[i].right, sign);
                    constraints[i] = negatedConstraint;
                }
            }

            double[][] originalMatrix = new double[constraints.First().left.Length][];

            for (int i = 0; i < constraints.First().left.Length; i++)
            {
                originalMatrix[i] = new double[constraints.Length];
                for (int j = 0; j < constraints.Length; j++)
                {
                    originalMatrix[i][j] = constraints[j].left[i];
                }
            }

            double[][] appendixMatrix = new double[0][];
            double[] Bs = new double[constraints.Length];

            for (int i = 0; i < constraints.Length; i++)
            {
                Constraint current = constraints[i];

                Bs[i] = current.right;

                if (current.sign == ">=")
                {
                    appendixMatrix = appendColumn(appendixMatrix, getColumn(-1, i, constraints.Length));
                }
                else if (current.sign == "<=")
                {
                    appendixMatrix = appendColumn(appendixMatrix, getColumn(1, i, constraints.Length));
                }
            }

            double[][] newMatrix = new double[constraints.First().left.Length + appendixMatrix.Length][];

            for (int i = 0; i < constraints.First().left.Length; i++)
            {
                newMatrix[i] = originalMatrix[i];
            }

            for (int i = constraints.First().left.Length; i < constraints.First().left.Length + appendixMatrix.Length; i++)
            {
                newMatrix[i] = appendixMatrix[i - constraints.First().left.Length];
            }

            bool[] hasBasicVar = new bool[constraints.Length];

            for (int i = 0; i < constraints.Length; i++)
            {
                hasBasicVar[i] = false;
            }

            C = new int[constraints.Length];

            int ci = 0;
            for (int i = 0; i < newMatrix.Length; i++)
            {
                bool hasOnlyNulls = true;
                bool hasOne = false;
                Tuple<int, int> onePosition = new Tuple<int, int>(0, 0);
                for (int j = 0; j < constraints.Length; j++)
                {
                    if (newMatrix[i][j] == 1)
                    {
                        if (hasOne)
                        {
                            hasOnlyNulls = false;
                            break;
                        }
                        else
                        {
                            hasOne = true;
                            onePosition = new Tuple<int, int>(i, j);
                        }
                    }
                    else if (newMatrix[i][j] != 0)
                    {
                        hasOnlyNulls = false;
                        break;
                    }
                }

                if (hasOnlyNulls && hasOne)
                {
                    hasBasicVar[onePosition.Item2] = true;
                    C[ci] = onePosition.Item1;
                    ci++;
                }
            }

            m = new bool[newMatrix.Length];

            for (int i = 0; i < newMatrix.Length; i++)
            {
                m[i] = false;
            }

            for (int i = 0; i < constraints.Length; i++)
            {
                if (!hasBasicVar[i])
                {
                    double[] basicColumn = new double[constraints.Length];

                    for (int j = 0; j < constraints.Length; j++)
                    {
                        basicColumn[j] = j == i ? 1 : 0;
                    }

                    newMatrix = appendColumn(newMatrix, basicColumn);
                    m = append(m, true);
                    C[ci] = newMatrix.Length - 1;
                    ci++;
                }
            }

            this.b = Bs;
            this.matrix = newMatrix;
        }

    }
}
