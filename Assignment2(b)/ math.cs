using System;

public class Class1
{
	public Class1()
	{

        public interface IMathOperations
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);
    }

    public class MathOperations : IMathOperations
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b) => b != 0 ? (double)a / b : throw new DivideByZeroException();
    }

}
}
