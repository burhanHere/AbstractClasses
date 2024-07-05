namespace AbstractClasses
{
    abstract class Employee(string inputName, double inputTaxRate, double inputFullSalary)
    {
        protected string name = inputName;
        protected double taxRate = inputTaxRate;
        protected double fullSalary = inputFullSalary;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Salary
        {
            get { return this.fullSalary; }
            set { this.fullSalary = value; }
        }
        //public virtual double CalcSalary()
        //{
        //    return this.fullSalary - this.taxRate;
        //}
        public abstract double CalcSalary();
    }

    class Accountant(string inputName, double inputTaxRate, double inputFullSalary) : Employee(inputName, inputTaxRate, inputFullSalary)
    {
        public double AccountantSalary()
        {
            return this.Salary;
        }

        public override double CalcSalary()
        {
            Console.WriteLine("Accountant");
            return this.Salary - 10000;
        }
    }

    class Assistant(string inputName, double inputTaxRate, double inputFullSalary) : Accountant(inputName, inputTaxRate, inputFullSalary)
    {
        public override double CalcSalary()
        {
            Console.WriteLine("Assistant");
            return this.Salary - 11000;
        }
    }
    class Program
    {
        public static void Main()
        {
            //Employee e1 = new("Burhan", 10000, 200000.00);
            //Console.WriteLine(e1.CalcSalary());

            Accountant a1 = new("BurhanAccountant", 10000, 200000.00);
            Console.WriteLine(a1.AccountantSalary());
            Console.WriteLine(a1.CalcSalary());

            Assistant as1 = new("BurhanAssistant", 10000, 3500000);
            Console.WriteLine(as1.AccountantSalary());
            Console.WriteLine(as1.CalcSalary());
        }
    }
}