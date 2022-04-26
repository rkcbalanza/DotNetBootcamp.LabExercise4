using System;

namespace CSharp.LabExercise4
{
    //4.1 Shape Exercise
    interface IShape
    {
        void ComputeArea();
        void DisplayArea();
    }

    abstract class BaseShape
    {
        string _name;
        decimal _area;
        public string Name { get => this._name; set => this._name = value; }
        public decimal Area { get => this._area; set => this._area = value; }
    }

    class Circle : BaseShape, IShape
    {
        int radius = 5;
        decimal pi = 3.14M;
        public void ComputeArea()
        {
            this.Area = this.pi * (this.radius * this.radius);
        }

        public void DisplayArea()
        {
            Name = "Circle";
            Console.WriteLine("Variables:");
            Console.WriteLine("Radius = {0}", this.radius);
            Console.WriteLine("{0} Area: {1}", this.Name, this.Area);
        }
    }

    class Rectangle : BaseShape, IShape
    {
        int width = 3;
        int length = 5;
        public void ComputeArea()
        {
            this.Area = this.width * this.length;
        }

        public void DisplayArea()
        {
            this.Name = "Rectangle";
            Console.WriteLine("Variables:");
            Console.WriteLine("Width = {0}", this.width);
            Console.WriteLine("Length = {0}", this.length);
            Console.WriteLine("{0} Area: {1}", this.Name, this.Area);
        }
    }

    class Square : BaseShape, IShape
    {
        int side = 4;
        public void ComputeArea()
        {
            this.Area = this.side * this.side;
        }

        public void DisplayArea()
        {
            this.Name = "Square";
            Console.WriteLine("Variables:");
            Console.WriteLine("Side = {0}", this.side);
            Console.WriteLine("{0} Area: {1}", this.Name, this.Area);
        }
    }

    // 4.2 Calculator Exercise
    interface IOperations
    {
        void Compute(decimal firstNumber, decimal secondNumber);
        void DisplayAnswer();
    }

    abstract class BaseNumbers
    {

        decimal _firstNumber;
        decimal _secondNumber;
        decimal _answer;

        public decimal FirstNumber { get => this._firstNumber; set => this._firstNumber = value; }
        public decimal SecondNumber { get => this._secondNumber; set => this._secondNumber = value; }
        public decimal Answer { get => this._answer; set => this._answer = value;}
    }

    class Addition : BaseNumbers, IOperations
    {
        public void Compute(decimal firstNumber, decimal secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
            this.Answer = this.FirstNumber + this.SecondNumber;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} + {1} = {2}", this.FirstNumber, this.SecondNumber, this.Answer);
        }
    }

    class Subtraction : BaseNumbers, IOperations
    {
        public void Compute(decimal firstNumber, decimal secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
            this.Answer = this.FirstNumber - this.SecondNumber;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} - {1} = {2}", this.FirstNumber, this.SecondNumber, this.Answer);
        }
    }

    class Multiplication : BaseNumbers, IOperations
    {
        public void Compute(decimal firstNumber, decimal secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
            this.Answer = this.FirstNumber * this.SecondNumber;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} * {1} = {2}", this.FirstNumber, this.SecondNumber, this.Answer);
        }
    }

    class Division : BaseNumbers, IOperations
    {
        public void Compute(decimal firstNumber, decimal secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
            this.Answer = this.FirstNumber / this.SecondNumber;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine("{0} / {1} = {2}", this.FirstNumber, this.SecondNumber, this.Answer);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape Exercise
            IShape circle = new Circle();
            circle.ComputeArea();
            circle.DisplayArea();

            IShape square = new Square();
            square.ComputeArea();
            square.DisplayArea();

            IShape rectangle = new Rectangle();
            rectangle.ComputeArea();
            rectangle.DisplayArea();

            Console.WriteLine("\n***********************************************\n\n");

            //Calculator Exercise
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
            Console.Write("Choose your operation:");
            int choiceOperation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number:");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter second number: ");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            switch(choiceOperation)
            {
                case 1:
                    IOperations additionOperation = new Addition();
                    additionOperation.Compute(firstNumber, secondNumber);
                    additionOperation.DisplayAnswer();
                    break;
                case 2:
                    IOperations subtractionOperation = new Addition();
                    subtractionOperation.Compute(firstNumber, secondNumber);
                    subtractionOperation.DisplayAnswer();
                    break;
                case 3:
                    IOperations multiplicationOperation = new Addition();
                    multiplicationOperation.Compute(firstNumber, secondNumber);
                    multiplicationOperation.DisplayAnswer();
                    break;
                case 4:
                    IOperations divisionOperation = new Addition();
                    divisionOperation.Compute(firstNumber, secondNumber);
                    divisionOperation.DisplayAnswer();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
