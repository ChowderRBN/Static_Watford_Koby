using System; // Imports the System namespace.

namespace Static_Watford_Koby // Declares the namespace.
{
    class Program // Declares the Program class, the entry point of the app.
    {
        static void Main(string[] args) // Main method: where the program starts executing.
        {
            // -------- Integer operations --------
            Console.WriteLine("Integer Operations:"); // Prints header

            Console.WriteLine("Add: " + Calculate.Add(10, 5)); // Calls Add(int, int) and prints result.
            Console.WriteLine("Subtract: " + Calculate.Subtract(10, 5)); // Calls Subtract(int, int)
            Console.WriteLine("Multiply: " + Calculate.Multiply(10, 5)); // Calls Multiply(int, int)
            Console.WriteLine("Divide: " + Calculate.Divide(10, 5)); // Calls Divide(int, int)

            Console.WriteLine("Current result: " + Calculate.result); // Prints latest value of result.

            // -------- Float operations --------
            Console.WriteLine("\nFloat Operations:"); // Prints header

            Console.WriteLine("Add: " + Calculate.Add(10.5f, 5.2f)); // Calls Add(float, float)
            Console.WriteLine("Subtract: " + Calculate.Subtract(10.5f, 5.2f)); // Calls Subtract(float, float)
            Console.WriteLine("Multiply: " + Calculate.Multiply(10.5f, 5.2f)); // Calls Multiply(float, float)
            Console.WriteLine("Divide: " + Calculate.Divide(10.5f, 5.2f)); // Calls Divide(float, float)

            Console.WriteLine("Current result: " + Calculate.result); // Prints final result.
        }
    }
}
