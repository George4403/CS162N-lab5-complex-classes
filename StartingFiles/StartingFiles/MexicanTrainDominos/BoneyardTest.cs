using System;
using DominoClasses;

namespace DominoTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBoneyard();
        }

        static void TestBoneyard()
        {
            // Create a boneyard with max dots 6
            Boneyard boneyard = new Boneyard(6);

            // Display the boneyard
            Console.WriteLine("Initial Boneyard:");
            Console.WriteLine(boneyard);

            // Test count
            Console.WriteLine($"Number of dominos: {boneyard.Count}");

            // Draw a domino
            Domino drawnDomino = boneyard.Draw();
            Console.WriteLine($"Drawn domino: {drawnDomino}");

            // Display the boneyard after drawing
            Console.WriteLine("Boneyard after drawing one domino:");
            Console.WriteLine(boneyard);

            // Test if boneyard is empty
            Console.WriteLine($"Is boneyard empty? {boneyard.IsEmpty()}");

            // Shuffle the boneyard
            boneyard.Shuffle();
            Console.WriteLine("Boneyard after shuffling:");
            Console.WriteLine(boneyard);

            // Test accessing and modifying a domino
            Console.WriteLine($"Domino at index 0: {boneyard[0]}");
            boneyard[0] = new Domino(9, 9);
            Console.WriteLine($"Modified domino at index 0: {boneyard[0]}");

            // Display the final state of the boneyard
            Console.WriteLine("Final Boneyard:");
            Console.WriteLine(boneyard);
        }
    }
}
