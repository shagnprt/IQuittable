Explanation:
Interface IQuittable: This interface defines a contract with a Quit() method that any class implementing the interface must provide.
Employee Class: Inherits from IQuittable and implements the Quit() method. This method can be customized in any way (e.g., printing a message).
Polymorphism: The object quittableEmployee is created with the type IQuittable but instantiated as an Employee. This demonstrates polymorphism because although the object is of type IQuittable, it uses the implementation of the Quit() method from the Employee class.
Calling the Method: The Quit() method is called on the quittableEmployee object, and it runs the implementation defined in the Employee class.
