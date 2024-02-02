namespace Counting_employee
{
    class Employee
    {
        static int count = 0;
        string firstName;
        string lastName;
        float salary;
        string address;
        public Employee(string firstName, string lastName, float salary, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.address = address;

            count = count + 1;
        }
        public static int countEmployees()
        {
            return count;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Employee e1 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e2 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e3 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e4 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e5 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e6 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e7 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e8 = new Employee("Nikhita", "Palla", 30000, "VZM");
            Employee e9 = new Employee("Nikhita", "Palla", 30000, "VZM");

            Console.WriteLine(Employee.countEmployees());

        }
    }

}
