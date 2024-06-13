namespace Mmdo.main.module
{
    public class Constraint
    {
        public double[] left;
        public double right;
        public string sign;

        public Constraint(double[] left, double right, string sign = ">=")
        {
            this.left = left;
            this.right = right;
            this.sign = sign;
        }
    }


}
