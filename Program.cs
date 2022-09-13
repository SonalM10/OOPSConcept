namespace OOPSConcept
{
    public class Employee //class --- //base class / parent class / super class
    {
        public Employee() //constructor
        { 
            //code
        }
      
        private float experince;// field 
        public float Experince //properties
        {
            get { return experince; }
            set { experince = value; }
        }
        public void CalculateSalary() //method
        {
            int salary = (int)Experince * 300000;
            Console.WriteLine("Salary: {0}",salary);
        }
        public class PermentEmployee : Employee //Derive/child/ sub class
        {

        }
        public class ContractEmployee : Employee //Derive/child/ sub class
        {

        }
        static void Main(string[] args)
        {
            PermentEmployee employee = new PermentEmployee();
            Console.WriteLine("Please Enter the Experince:");
            employee.Experince = (float)Convert.ToDecimal(Console.ReadLine());
            //employee.Experince = 10;
            employee.CalculateSalary();
            Console.ReadKey();
        }

       
    }
   
}