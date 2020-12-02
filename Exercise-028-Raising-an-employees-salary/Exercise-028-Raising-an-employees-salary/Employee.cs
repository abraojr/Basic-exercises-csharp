using System.Globalization;

namespace Exercise_028_Raising_an_employees_salary
{
    class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }
        public void RaiseSalary(double percentage)
        {
            GrossSalary += GrossSalary * (percentage / 100);
        }
        public override string ToString()
        {
            return Name + " , U$ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
