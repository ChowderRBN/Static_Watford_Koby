using System; // Imports the System namespace for basic functionality like Console.

namespace Static_Watford_Koby // Declares a namespace to group related classes.
{
    static class Calculate // Declares a static class. Static means it cannot be instantiated.
    {
        public static float result; // A public static float field to hold the last result of a calculation.

        // Static constructor - runs only once when the class is first accessed.
        static Calculate()
        {
            result = 0.0f; // Initializes the result to 0.0f.
        }

        // Adds two integers and returns the result.
        public static int Add(int x, int y)
        {
            result = x + y; // Stores the result in the static 'result' field.
            return (int)result; // Returns the result as an integer.
        }

        // Subtracts y from x and returns the result.
        public static int Subtract(int x, int y)
        {
            result = x - y;
            return (int)result;
        }

        // Multiplies two integers and returns the result.
        public static int Multiply(int x, int y)
        {
            result = x * y;
            return (int)result;
        }

        // Divides x by y and returns the result.
        public static int Divide(int x, int y)
        {
            if (y != 0) // Prevents division by zero.
            {
                result = (float)x / y; // Casts to float for accuracy.
                return (int)result;
            }
            Console.WriteLine("Cannot divide by zero."); // Error message.
            return 0; // Safe fallback value.
        }

        // Overloaded Add method for float numbers.
        public static float Add(float x, float y)
        {
            result = x + y;
            return result;
        }

        // Overloaded Subtract method for float numbers.
        public static float Subtract(float x, float y)
        {
            result = x - y;
            return result;
        }

        // Overloaded Multiply method for float numbers.
        public static float Multiply(float x, float y)
        {
            result = x * y;
            return result;
        }

        // Overloaded Divide method for float numbers.
        public static float Divide(float x, float y)
        {
            if (y != 0.0f) // Prevents float division by zero.
            {
                result = x / y;
                return result;
            }
            Console.WriteLine("Cannot divide by zero."); // Error message.
            return 0.0f; // Safe fallback.
        }
    }
}
