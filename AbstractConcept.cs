namespace OOPSConcept
{
    public class AbstractConcept
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("what is diff between abtract class and interface");
            PermentEmployee permentEmployee = new PermentEmployee();
             permentEmployee.Project();
             permentEmployee.Project1();
             permentEmployee.Role();
             permentEmployee.Project();
              Console.ReadLine();
        }

    }
    public abstract class Employees
    {
      
         public Employees()
        {

        }
        public string Name;
        public abstract void Project(); //Method Declared
        public void Role() //Method Defined
        {
            Console.WriteLine("Software Engineer");
            //body present in this method 
        }
    }
    interface IEmployee
    {
        //only Declaration allow
        public void Project();
        public void Role();
    }
    interface IEmployee1
    {
        //only Declaration allow
        public void Project1();
        public void Role1();
    }
    public class PermentEmployee : Employees, IEmployee,IEmployee1
    {
        public override void Project()
        {
            Console.WriteLine("Project CITY Bank");
        }
        public void Role()
        {
            Console.WriteLine("Manager");
        }
        public  void Project1()
        {
            Console.WriteLine("Project Sun");
        }
        public void Role1()
        {
            Console.WriteLine("Devloper");
        }
    }
}
