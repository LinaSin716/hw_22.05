namespace hw_22._05
{
    // без 3
    internal class Program
    {
        static void Main(string[] args)
        {
            // Номер 1
            
            List<Employee> employees = new List<Employee>()
            {
                new Employee("name1", "depart1", 1000, "1"),
                new Employee("name2", "depart2", 200, "4"),
                new Employee("name3", "depart1", 650, "3"),
                new Employee("name4", "depart3", 950, "2"),
                new Employee("name5", "depart3", 990, "2"),
                new Employee("name6", "depart3", 1300, "1"),
                new Employee("name7", "depart3", 250, "4"),
                new Employee("name8", "depart1", 300, "4"),
                new Employee("name9", "depart2", 1200, "1"),
                new Employee("name10", "depart5", 1500, "1")
            };

            Console.WriteLine("Name:\tDepartment:\tSalary:\tPositionLevel:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Name}\t{emp.Department}\t\t{emp.Salary}\t{emp.PositionLevel}");
            }

            // 1

            Dictionary<string, double> dep_salaries = new Dictionary<string, double>();
            Console.WriteLine("\n\nСредняя зп для каждого отдела: ");

            List<Employee> arr1 = employees.Where(e => e.Department == "depart1").ToList();
            double ans1 = arr1.Select(e => e.Salary).Sum() / arr1.Count();
            dep_salaries["depart1"] = ans1;
            Console.WriteLine("depart1: " + ans1);

            arr1 = employees.Where(e => e.Department == "depart2").ToList();
            ans1 = arr1.Select(e => e.Salary).Sum() / arr1.Count();
            dep_salaries["depart2"] = ans1;
            Console.WriteLine("depart2: " + ans1);

            arr1 = employees.Where(e => e.Department == "depart3").ToList();
            ans1 = arr1.Select(e => e.Salary).Sum() / arr1.Count();
            dep_salaries["depart3"] = ans1;
            Console.WriteLine("depart3: " + ans1);

            arr1 = employees.Where(e => e.Department == "depart5").ToList();
            ans1 = arr1.Select(e => e.Salary).Sum() / arr1.Count();
            dep_salaries["depart5"] = ans1;
            Console.WriteLine("depart5: " + ans1);

            // 2 

            string ans2 = dep_salaries.Where(d => d.Value == dep_salaries.Select(d => d.Value).Max()).FirstOrDefault().Key;
            Console.WriteLine("\nОтдел с самой высокой зп: " + ans2);

            // 3

            double sr_salary = employees.Select(e => e.Salary).Sum() / employees.Count();
            Console.WriteLine($"\nСотрудники с зп выше средней ({sr_salary}): ");
            foreach(Employee empl in employees.Where(e => e.Salary > sr_salary).ToList())
            {
                Console.WriteLine($"Name: {empl.Name} Salary: {empl.Salary}");
            }

            // 4

            Console.WriteLine("\nСуммарные зп для уровней: ");
            Console.WriteLine($"1: {employees.Where(e => e.PositionLevel == "1").Select(e => e.Salary).Sum()}\n" +
                $"2: {employees.Where(e => e.PositionLevel == "2").Select(e => e.Salary).Sum()}\n" +
                $"3: {employees.Where(e => e.PositionLevel == "3").Select(e => e.Salary).Sum()}\n" +
                $"4: {employees.Where(e => e.PositionLevel == "4").Select(e => e.Salary).Sum()}\n");
            

            // Номер 2
            
            ForNum2<Transaction> forNum2 = new ForNum2<Transaction>();
            forNum2.list = new List<Transaction>{
                new Transaction("123", 500, new Dates(2000, 11, 5)),
                new Transaction("124", 1000, new Dates(1999, 10, 12)),
                new Transaction("110", 260, new Dates(2006, 1, 15)),
                new Transaction("100", 457, new Dates(2006, 11, 17)),
                new Transaction("56", 560, new Dates(1500, 5, 30)),
                new Transaction("250", 500, new Dates(1890, 3, 26))
            };

            Console.WriteLine($"Id\tAmount\tDate\n");
            foreach (Transaction t in forNum2.list)
            {
                Console.WriteLine($"{t.TransactionId}\t{t.Amount}\t{t.Date.Day}.{t.Date.Month}.{t.Date.Year}");
            }

            Console.WriteLine($"\nОт 10.6.1895 до 15.1.2006: \n\nId\tAmount\tDate\n");
            foreach (Transaction t in forNum2.Lis(forNum2.list, new Dates(1895, 6, 10), new Dates(2006, 1, 15)))
            {
                Console.WriteLine($"{t.TransactionId}\t{t.Amount}\t{t.Date.Day}.{t.Date.Month}.{t.Date.Year}");
            }


            Console.Write("\nСредняя сумма транзикций от 10.6.1895 до 15.1.2006: ");
            Console.WriteLine(forNum2.Method(forNum2.list, new Dates(1895, 6, 10), new Dates(2006, 1, 15)));
            

        }
    }
}