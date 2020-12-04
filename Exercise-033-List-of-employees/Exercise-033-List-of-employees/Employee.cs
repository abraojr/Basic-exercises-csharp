using System.Globalization;

namespace Exercise_033_List_of_employees
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Employee(int id, string name, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
        public void increaseSalary(double percent)
        {
            Salary += Salary * (percent / 100.0);
        }
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
