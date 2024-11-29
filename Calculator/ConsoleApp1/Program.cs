class Calculator
{
    private int _Result = 0;
    private int _Value = 0;
    private char _Operation = ' ';
    private string _OperationAsString = "Clear";

    private bool CheckZero(int Value)
    {
        return (Value == 0);
    }
    private int Calcul(char Operation, int Value)
    {
        switch (Operation)
        {
            case ('+'):
                return _Result + Value;

            case ('-'):
                return _Result - Value;

            case ('*'):
                return _Result * Value;

            case ('/'):
                return _Result / Value;

        }
        return _Result;
    }


    public void PrintResult()
    {
        Console.WriteLine("The Result Of " + _OperationAsString + " " + _Value.ToString() + " is " + _Result);
    }



    public void Add(int Value)
    {
        _Value = Value;
        _Operation = '+';
        _OperationAsString = "Adding";
        _Result = Calcul(_Operation, Value);

    }

    public void Subtract(int Value)
    {
        _Value = Value;
        _Operation = '-';
        _OperationAsString = "Subtracting";
        _Result = Calcul(_Operation, Value);

    }

    public void Devide(int Value)
    {
        _Value = Value;
        _Operation = '/';
        _OperationAsString = "Deviding";

        if (CheckZero(Value))
        {
            Value = 1;
        }
        _Result = Calcul(_Operation, Value);

    }

    public void Multiply(int Value)
    {
        _Value = Value;
        _Operation = '*';
        _OperationAsString = "Multiplying";
        _Result = Calcul(_Operation, Value);

    }

    public int GetFinaleResult()
    {  return _Result; 
    }
    public void Clear()
    {
        _Value = 0;
        _Operation = ' ';
        _OperationAsString = "Clear";
        _Result = 0;

    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator Calculator1 = new Calculator();

            Calculator1.Add(10);
            Calculator1.PrintResult();
            Calculator1.Multiply(5);
            Calculator1.PrintResult();
            Calculator1.Devide(5);
            Calculator1.PrintResult();
            Calculator1.Subtract(1);
            Calculator1.PrintResult();

        Calculator1.Devide(0);
        Calculator1.PrintResult();
       Console.WriteLine( Calculator1.GetFinaleResult().ToString());

        Calculator1.Clear();
        Calculator1.PrintResult();

       
    }


}






