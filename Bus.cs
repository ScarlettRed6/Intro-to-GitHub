class Bus
{
   static void Main(string[] args)
        {
            //Initialize seat matrix (rows and columns)
            string[] rows = { "Row 1 ", "Row 2 ", "Row 3 ", "Row 4 ", "Row 5 ", "Row 6 ", "Row 7 ", "Row 8 ", "Row 9 ", "Row 10 " };
            string[,] table = {
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" },
                { "*", "*", "*", "*" }
            };

            bool continueReservation = true;

            do
            {
                //Display the bus seat layout
                Console.WriteLine("Welcome to the Bus Reservation System!");
                string[] columns = { "Col 1", "Col 2", "Col 3", "Col 4" };

                //Display column headers
                Console.Write("\t");
                foreach (var col in columns)
                {
                    Console.Write(col + "\t");
                }
                Console.WriteLine();

                //Display the rows and seats
                for (int row = 0; row < table.GetLength(0); row++)
                {
                    Console.Write(rows[row] + "\t");
                    for (int col = 0; col < table.GetLength(1); col++)
                    {
                        Console.Write(table[row, col] + "\t");
                    }
                    Console.WriteLine();
                }

                //Ask for user input (row and column)
                //Console.WriteLine("Enter the row and column number to reserve a seat separated by spaces (Enter a negative number to exit): ");
                //string[] userInput = Console.ReadLine().Split(' ');
                
                // Another way for user input 
                Console.WriteLine("Enter the row (Enter a negative number to exit): ");
                int.TryParse(Console.ReadLine(), out int selectedRow);
                Console.WriteLine("Enter the column (Enter a negative number to exit): ");
                int.TryParse(Console.ReadLine(), out int selectedCol);
                
                // int selectedRow = int.Parse(userInput[0]);
               // int selectedCol = int.Parse(userInput[1]);

                // Check if user wants to exit
                if (selectedRow == 0 || selectedCol == 0)
                {
                    continueReservation = false;
                }
                else
                {
                    // Reserve seat by marking with 'X'
                    if (table[selectedRow - 1, selectedCol - 1] == "X")
                    {
                        Console.WriteLine("Seat is Already Reserved!");
                    }
                    else
                    {
                        table[selectedRow - 1, selectedCol - 1] = "X";
                        Console.WriteLine("Seat reserved successfully!");
                    }
                    
                }

            } while (continueReservation);

            Console.WriteLine("Reservation process finished.");
        }
}
