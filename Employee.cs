namespace lab1
{
    internal class Employee
    {
        public Employee(string name, string surname, string jobtitle, double rate, int experience, double tax)
        {
            Name = name;
            Surname = surname;
            JobTitle = jobtitle;
            Rate = rate;
            Experience = experience;
            Tax = tax;
        }

        public string Name { get; }
        public string Surname { get; }
        public string JobTitle { get; }
        public double Rate { get; }
        public int Experience { get; }
        public double Tax { get; }

        public double CalculateSalary()
        {
            return Rate * Experience * (1 - Tax);
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("Employee's name: {0} {1}", Name, Surname);
            Console.WriteLine("Job Title: {0}", JobTitle);
            Console.WriteLine("Salary: {0}", CalculateSalary());
        }
    }
}
