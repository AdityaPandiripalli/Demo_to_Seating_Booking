using System;

class Program
{
    static void Main()
    {
        // Step 1: Declare a 2D array for seating arrangement with rows and columns
        int rows = 3;
        int cols = 4;
        string[,] seats = new string[rows, cols];

        // Step 2: Initialize the 2D array with seat numbers and availability status
        int seatNumber = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                seats[i, j] = "S" + seatNumber; // Example: S1, S2, etc.
                seatNumber++;
            }
        }

        // Step 3: Display the seating arrangement after initialization and before booking
        Console.WriteLine("Initial Seating Arrangement:");
        DisplaySeating(seats);

        // Step 4: Allow users to book seats by selecting a seat number
        Console.Write("\nEnter the seat number to book (e.g., S3): ");
        string selectedSeat = Console.ReadLine();

        bool booked = false;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (seats[i, j].Equals(selectedSeat, StringComparison.OrdinalIgnoreCase))
                {
                    seats[i, j] = "X"; // Mark as booked
                    booked = true;
                    break;
                }
            }
            if (booked)
                break;
        }

        if (booked)
            Console.WriteLine("\nSeat booked successfully!");
        else
            Console.WriteLine("\nSeat not found or already booked.");

        // Step 5: Display the seating arrangement after booking
        Console.WriteLine("\nUpdated Seating Arrangement:");
        DisplaySeating(seats);
    }

    static void DisplaySeating(string[,] seats)
    {
        int rows = seats.GetLength(0);
        int cols = seats.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(seats[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}