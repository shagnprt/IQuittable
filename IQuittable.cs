using System;

namespace Polymorphis
{
    // Define the interface IQuittable
    public interface IQuittable
    {
        // Define a void method Quit
        void Quit();
    }

    // Create an Employee class that implements IQuittable
    public class Employee : IQuittable
    {
        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee has quit
            Console.WriteLine("Employee has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = new Employee();

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();
        }
    }
}
