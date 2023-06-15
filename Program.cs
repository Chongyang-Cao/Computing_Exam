namespace Computing_Exam
{
    class Employee 
    {
        public Decimal HourlyPay { get; set; }
        public string EmployeeNumber { get; set; }
        public string JobTitle { get; set; }
        public decimal[] PayYear2022 { get; set; }

        public Employee(decimal hourlyPay, string employeeNumber, string jobTitle)
        {
            HourlyPay = hourlyPay;
            EmployeeNumber = employeeNumber;
            JobTitle = jobTitle;
            PayYear2022 = new decimal[52];
            for (int i = 0; i < 52; i++)
            {
                PayYear2022.SetValue(0,i);
                Console.WriteLine(i);
            }
        }
        public string GetEmployeeNumber()
        {
            return(EmployeeNumber);
        }
        public virtual void SetPay(int weeknumber, int hoursworked)
        {
            PayYear2022[weeknumber] = hoursworked*HourlyPay;
        }
        public decimal GetTotalPay()
        {
            return (PayYear2022.Sum());
        }
    }
    class Manager : Employee
    {
    
        public decimal BonusValue { get; set; }
        public Manager(decimal hourlyPay, string employeeNumber, string jobTitle, decimal bonusValue)
        {
            HourlyPay = hourlyPay;
            EmployeeNumber = employeeNumber;
            JobTitle = jobTitle;
            PayYear2022 = new decimal[52];
            for (int i = 0; i < 52; i++)
            {
                PayYear2022.SetValue(0, i);
                Console.WriteLine(i);
            }
            BonusValue = bonusValue;
        }
        public override void SetPay(int weeknumber, int hoursworked)
        {

            PayYear2022[weeknumber] = (hoursworked*BonusValue/100) * HourlyPay  ;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] Database = new Employee[8];
            string file = @"C:Users\thecr\Downloads\Employees.txt\" ;
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string ln in lines) 
                {

                }
            }
        }
        public void EnterHours()
        {
            string file = @"C:\Users\thecr\Downloads\HoursWeek1.txt";
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string ln in lines) 
                {
                    
                }

            }
        }
    }
}