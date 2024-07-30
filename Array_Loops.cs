using System;

namespace YourNamespace
{
    public class Array_Loops
    {
        private string[] fraudulentOrderIDs;

        public Array_Loops()
        {
            fraudulentOrderIDs = new string[3];
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
        }



        // Methode zum Ausgeben des Arrays
        public void PrintFraudulentOrderIDs()
        {
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
        }
    }
}
