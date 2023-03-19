using System.Net.NetworkInformation;

namespace Demo
{
    public class program
    {
        public static void Main(String[] args)
        {

            //ConstructorDemo obj= new ConstructorDemo(10,"Raj");
            //Console.WriteLine(obj.age);
            //Console.WriteLine(obj.name);

            //Dog dog = new Dog();  
            //dog.animalSound();

        // Method call for Access Modifiers
            AccessModifierDemo person = new AccessModifierDemo();
            Console.WriteLine(person.id);//created object for public class
           // Console.WriteLine(person.name);//created object for private class
            Console.WriteLine(person.RollNumber);//created object for internal class

           // Console.WriteLine(person.username);//created object for protected class
            Employee employee = new Employee();
            employee.Print(); 





        }
    }
}