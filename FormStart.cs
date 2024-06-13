using Mmdo.main.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mmdo
{
    public enum Sign { LessEqual, GreaterEqual, Equal }
    public partial class FormStart : Form
    {

        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildExpression();
        }


        void BuildExpression()
        {

            //constraint
            List<Constraint> constraints = new List<Constraint>
            {
                new Constraint( new double[] { ToNum(numBread1.Value), ToNum(numSalo1.Value), ToNum(numMarg1.Value), ToNum(numPotato1.Value), ToNum(numEggs1.Value), ToNum(numChoco1.Value) }, ToNum(numNorm1.Value) ),
                new Constraint( new double[] { ToNum(numBread2.Value), ToNum(numSalo2.Value), ToNum(numMarg2.Value), ToNum(numPotato2.Value), ToNum(numEggs2.Value), ToNum(numChoco2.Value) }, ToNum(numNorm2.Value) ),
                new Constraint( new double[] { ToNum(numBread3.Value), ToNum(numSalo3.Value), ToNum(numMarg3.Value), ToNum(numPotato3.Value), ToNum(numEggs3.Value), ToNum(numChoco3.Value) }, ToNum(numNorm3.Value) ),
            };

            //func
            double[] functionVariables = new double[] { ToNum(numBreadPrice.Value), ToNum(numSaloPrice.Value), ToNum(numMargPrice.Value), ToNum(numPotatoPrice.Value), ToNum(numEggsPrice.Value), ToNum(numChocoPrice.Value) };


            Simplex simplex = new Simplex(new Function(functionVariables, false), constraints.ToArray());
            var data = simplex.GetIterations();
            snaps = data.Item1;

            numIteration.Maximum = snaps.Count;
            numIteration.Minimum = 1;

            //DrawTable();
            numIteration.Value = 1;
            ShowAnswer(data);
        }

        double ToNum(decimal d)
        {
            return (double)d;
        }

        List<Iteration> snaps;

        void DrawTable()
        {
            ClearTable();

            int addCols = 3;
            grid.ColumnCount = snaps.First().matrix.Length + addCols;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false;

            for (int i = 0; i < snaps.First().matrix.Length + addCols; i++)
            {
                grid.Columns[i].Width = 50;
                grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (Iteration snap in snaps)
            {
                string[] firstRow = new string[snaps.First().matrix.Length + addCols];

                firstRow[0] = "C";
                firstRow[1] = "B";
                firstRow[2] = "X0";

                for (int i = addCols; i < snaps.First().matrix.Length + addCols; i++)
                {
                    firstRow[i] = $"X{i - 3}";
                }

                grid.Rows.Add(firstRow);

                for (int i = 0; i < snaps.First().C.Length; i++)
                {
                    string[] row = new string[snaps.First().matrix.Length + addCols];
                    for (int j = 0; j < snaps.First().matrix.Length + addCols; j++)
                    {
                        if (j == 1)
                        {
                            row[j] = $"X{snap.C[i] + 1}";
                        }
                        else if (j == 0)
                        {
                            row[j] = snap.m[snap.C[i]] ? "-M" : $"{Math.Abs(snap.fVars[snap.C[i]])}";
                        }
                        else if (j == 2)
                        {
                            row[j] = Round(snap.b[i]).ToString();
                        }
                        else
                        {
                            row[j] = Round(snap.matrix[j - addCols][i]).ToString();
                        }
                    }
                    grid.Rows.Add(row);
                }

                string[] fRow = new string[snaps.First().matrix.Length + addCols];

                fRow[1] = "F";
                fRow[2] = Round(snap.fValue).ToString();

                for (int i = addCols; i < snaps.First().matrix.Length + addCols; i++)
                {
                    fRow[i] = Round(snap.F[i - addCols]).ToString();
                }

                grid.Rows.Add(fRow);


                string[] emptyRow = new string[snaps.First().matrix.Length + addCols];
                grid.Rows.Add(emptyRow);
                grid.Rows.Add(emptyRow);
            }
        }

        void DrawIteration(int id)
        {
            ClearTable();

            int addCols = 3;
            grid.ColumnCount = snaps.First().matrix.Length + addCols;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false;

            Iteration snap = snaps[id];

            for (int i = 0; i < snaps.First().matrix.Length + addCols; i++)
            {
                grid.Columns[i].Width = 50;
                grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            string[] firstRow = new string[snaps.First().matrix.Length + addCols];

            firstRow[0] = "C";
            firstRow[1] = "B";
            firstRow[2] = "X0";

            for (int i = addCols; i < snaps.First().matrix.Length + addCols; i++)
            {
                firstRow[i] = $"X{i - (addCols - 1)}";
            }

            grid.Rows.Add(firstRow);

            for (int i = 0; i < snaps.First().C.Length; i++)
            {
                string[] row = new string[snaps.First().matrix.Length + addCols];
                for (int j = 0; j < snaps.First().matrix.Length + addCols; j++)
                {
                    if (j == 1)
                    {
                        row[j] = $"X{snap.C[i] + 1}";
                    }
                    else if (j == 0)
                    {
                        row[j] = snap.m[snap.C[i]] ? "-M" : $"{Math.Abs(snap.fVars[snap.C[i]])}";
                    }
                    else if (j == 2)
                    {
                        row[j] = Round(snap.b[i]).ToString();
                    }
                    else
                    {
                        row[j] = Round(snap.matrix[j - addCols][i]).ToString();
                    }
                }
                grid.Rows.Add(row);
            }

            string[] fRow = new string[snaps.First().matrix.Length + addCols];

            fRow[1] = "F";
            fRow[2] = Math.Abs(Round(snap.fValue)).ToString();

            for (int i = addCols; i < snaps.First().matrix.Length + addCols; i++)
            {
                fRow[i] = Round(snap.F[i - addCols]).ToString();
            }

            grid.Rows.Add(fRow);

        }

        void ShowAnswer(Tuple<List<Iteration>, TableAnswerType> result)
        {
            var x1 = Round(GetValueOfX(result.Item1.Last(), 0));
            var x2 = Round(GetValueOfX(result.Item1.Last(), 1));
            var x3 = Round(GetValueOfX(result.Item1.Last(), 2));
            var x4 = Round(GetValueOfX(result.Item1.Last(), 3));
            var x5 = Round(GetValueOfX(result.Item1.Last(), 4));
            var x6 = Round(GetValueOfX(result.Item1.Last(), 5));

            var f = Math.Abs(Round(result.Item1.Last().fValue));

            switch (result.Item2)
            {
                case TableAnswerType.Found:
                    {
                        resBread.Text = x1.ToString();
                        resSalo.Text = x2.ToString();
                        resMargarine.Text = x3.ToString();
                        resPotato.Text = x4.ToString();
                        resEggs.Text = x5.ToString();
                        resChoco.Text = x6.ToString();
                        resSum.Text = f.ToString();

                        labelError.Visible = false;
                        break;
                    }
                case TableAnswerType.Unbounded:
                case TableAnswerType.NoSolve:
                    {
                        resBread.Text = "";
                        resSalo.Text = "";
                        resMargarine.Text = "";
                        resPotato.Text = "";
                        resEggs.Text = "";
                        resChoco.Text = "";
                        resSum.Text = "";

                        labelError.Visible = true;
                        break;
                    }
            }
        }

        double GetValueOfX(Iteration result, int id)
        {
            for (int i = 0; i < result.C.Length; i++)
            {
                if (result.C[i] == id)
                {
                    return result.b[i];
                }
            }
            return 0;
        }


        double Round(double a)
        {
            return Math.Round(a, 2);
        }

        void ClearTable()
        {
            grid.Rows.Clear();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numIteration_ValueChanged(object sender, EventArgs e)
        {
            if (snaps != null && snaps.Count > 0)
            {
                DrawIteration((int)numIteration.Value - 1);
            }
            else
            {
                numIteration.Value = 0;
            }
        }


    }
}
