using System;

namespace Day4Afternoon
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int width = 8;
            int height = 8;

            string[,] grid = new string[width, height];

            //INITIALIZE THE OCEAN
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    grid[i, j] = " ~ ";
                }
            }
            //Insert ships
            grid[0, 0] = "BOAT";
            grid[7, 7] = "BOAT";
            grid[3, 5] = "BOAT";
            grid[3, 6] = "BOAT";

            Console.WriteLine("--------------------");

            Console.Write("  ");
            //RADAR SCANNER
            for (int i = 0; i < width; i++)
            {
                Console.Write(" " + i + " ");
            }
            Console.WriteLine("");
            for (int i = 0; i < width; i++)
            {
                Console.Write(i + "|");
                for (int j = 0; j < height; j++)
                {
                    if (grid[i, j] == "BOAT")
                    {
                        Console.Write(" ~ ");
                    }
                    else
                        Console.Write(grid[i, j]);
                }
                Console.WriteLine("");
            }

            int row;
            int column;

            //SHOOTING TIME
            bool didYouWin = false;
            while (didYouWin == false)
            {
                //get input from user
                Console.WriteLine("Where do you want to shoot?");
                Console.WriteLine("Row:");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Column:");
                column = Convert.ToInt32(Console.ReadLine());


                //check if input from user hits boat
                if (grid[row, column] == "BOAT")
                {
                    int waterblocknumber = 0;

                    Console.WriteLine("YARR YE SUNK A BATTLESHIP!");
                    grid[row, column] = " X ";
                    Console.WriteLine("--------------------");
                    Console.WriteLine("THIS IS WHAT THE OCEAN LOOKS LIKE RIGHT NOW.");
                    Console.WriteLine("--------------------");
                    Console.Write("  ");
                    //RADAR SCANNER
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(" " + i + " ");
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(i + "|");
                        for (int j = 0; j < height; j++)
                        {
                            if (grid[i, j] == "BOAT")
                            {
                                Console.Write(" ~ ");
                            }
                            else
                                Console.Write(grid[i, j]);
                        }
                        Console.WriteLine("");
                    }

                    //WIN CONDITION CHECKER SCANNER 
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            if (grid[i, j] == " ~ ")
                            {
                                waterblocknumber++;
                                //Console.WriteLine("There are still more ships. Shoot again.");
                            }
                            else
                            {
                                // Console.WriteLine("WATER!!!!!!!!");
                            }
                            //Console.Write(grid[i, j]);


                        }
                        //Console.WriteLine("");
                    }

                    if (waterblocknumber == height * width)
                    {
                        Console.WriteLine("You win! Great job!");
                        didYouWin = true;
                    }
                    //   Console.WriteLine("the string stored at the location referred to by 'didYouWin' is: " + didYouWin);

                }
                else
                {
                    Console.Write("MISSED ... ");
                    grid[row, column] = "   ";

                    //Check nearby blocks for Boats
                    //1 Catch the edge cases

                    //2 Catch the rest
                    //if any of the 8 blocks around this block contain a boat
                    //CURRENT LINE
                    //row 0 and column 0
                    if ((row == 0) && (column == 0))
                    {
                        if (grid[row + 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }
                    else if ((row == height - 1) && (column == width - 1))
                    {
                        if (grid[row - 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row - 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }
                    else if ((row == 0) && (column == (width - 1)))
                    {


                        if (grid[row, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }

                        else if (grid[row + 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }

                    }
                    else if ((row == height - 1) && (column == 0))
                    {
                        if (grid[row - 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }

                        else if (grid[row - 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }

                    else if (row == (height - 1))
                    {
                        if (grid[row - 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }

                        else if (grid[row - 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }


                        else if (grid[row - 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }
                    else if (row == 0)
                    {

                        if (grid[row, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }

                        else if (grid[row + 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }

                        else if (grid[row, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }
                    else if (column == 0)
                    {
                        if (grid[row - 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row - 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }
                    else if (column == width - 1)
                    {
                        if (grid[row - 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row - 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }
                    //row 0 and column 7
                    //row 7 column 0
                    //row 7 column 7
                    //row 0
                    //row 7
                    //column 0
                    //column 7

                    else
                    {
                        if (grid[row - 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column - 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row - 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row + 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row - 1, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else if (grid[row, column + 1] == "BOAT")
                        {
                            Console.WriteLine("but you're close!");
                        }
                        else
                        {
                            Console.WriteLine("AND YOU'RE COLD!");
                        }
                    }
                    Console.WriteLine("--------------------");
                    Console.WriteLine("THIS IS WHAT THE OCEAN LOOKS LIKE RIGHT NOW.");
                    Console.WriteLine("--------------------");
                    Console.Write("  ");
                    //RADAR SCANNER
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(" " + i + " ");
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(i + "|");
                        for (int j = 0; j < height; j++)
                        {
                            if (grid[i, j] == "BOAT")
                            {
                                Console.Write(" ~ ");
                            }
                            else
                                Console.Write(grid[i, j]);
                        }
                        Console.WriteLine("");
                    }

                }
            }




            //Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)

            //When users shoot an enemy, clear the ship in that cell

            //When all enemies are gone, make the "game" end.

            // Bonus:

            // If user picks a cell next to a ship, say "close!"
        }
    }

}

