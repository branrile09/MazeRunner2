
namespace MazeRunner2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //setting the players starting position.
            int playerRow = 1;
            int playerCol = 1;
            string[,] maze = defaultMaze();          


            //display the maze
            DisplayMaze(maze, playerRow,playerCol);

            while (true)
            {

                //prompt user for move
                //store movement
                int move = checkKeyPressed();
                //where we are moving towards
                int newRow = playerRow;
                int newCol = playerCol;

                if (move == 1)
                {
                    newRow--;
                }
                else if (move == 2)
                {
                    newRow++;
                }
                else if (move == 3)
                {
                    newCol--;
                }
                else if (move == 4)
                {
                    newCol++;
                }


                if (newCol < 0)
                {
                    newCol = 18;
                }
                else if (newCol > 18)
                {
                    newCol = 0;
                }

                if (maze[newRow, newCol] == " ")
                {//updating player postioning
                 //
                    playerRow = newRow;
                    playerCol = newCol;
                    DisplayMaze(maze, playerRow, playerCol);
                    Console.Write("use arrows or WASD to move");
                }

            }

        }




        static void DisplayMaze(string[,] maze, int playerRow, int playerCol)
        {
            Console.SetCursorPosition(0, 0);
            
            //display the maze with the players current position
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (row == playerRow && col == playerCol)
                    {
                        
                        Console.Write("&");
                    }
                    else
                    {                        
                        Console.Write(maze[row, col]);
                    }
                                 
                }
                
                Console.WriteLine();
            }
        }

        static int checkKeyPressed()
        {
            do
            {
                //cachine the variable
                ConsoleKey keypressed = Console.ReadKey(true).Key;

                //compare what the keystroke is
                if (keypressed == ConsoleKey.W || keypressed == ConsoleKey.UpArrow)
                {
                    return 1;
                }
                else if (keypressed == ConsoleKey.S || keypressed == ConsoleKey.DownArrow)
                {
                    return 2;
                }
                else if (keypressed == ConsoleKey.A || keypressed == ConsoleKey.LeftArrow)
                {
                    return 3;
                }
                else if (keypressed == ConsoleKey.D || keypressed == ConsoleKey.RightArrow)
                {
                    return 4;
                }
            }
            while (false);
            return 0;
        }

        static string[,] defaultMaze()
        {

            string[,] maze = {
                { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#","#", "#", "#", "#", "#", "#", "#", "#", "#" },//
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", "#"," ", " ", " ", " ", " ", " ", " ", " ", "#" },//
                { "#", " ", "#", "#", " ", "#", "#", "#", " ", "#"," ", "#", "#", "#", " ", "#", "#", " ", "#" },//
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " "," ", " ", " ", " ", " ", " ", " ", " ", "#" },//
                { "#", " ", "#", "#", " ", "#", " ", "#", "#", "#","#", "#", " ", "#", " ", "#", "#", " ", "#" },//
                { "#", " ", " ", " ", " ", "#", " ", " ", " ", "#"," ", " ", " ", "#", " ", " ", " ", " ", "#" },//
                { "#", "#", "#", "#", " ", "#", "#", "#", " ", "#"," ", "#", "#", "#", " ", "#", "#", "#", "#" },//
                { "#", "#", "#", "#", " ", "#", " ", " ", " ", " "," ", " ", " ", "#", " ", "#", "#", "#", "#" },//
                { "#", "#", "#", "#", " ", "#", " ", "#", "#", " ","#", "#", " ", "#", " ", "#", "#", "#", "#" },//
                { " ", " ", " ", " ", " ", " ", " ", "#", " ", " "," ", "#", " ", " ", " ", " ", " ", " ", " " },//
                { "#", "#", "#", "#", " ", "#", " ", "#", "#", "#","#", "#", " ", "#", " ", "#", "#", "#", "#" },//
                { "#", "#", "#", "#", " ", "#", " ", " ", " ", " "," ", " ", " ", "#", " ", "#", "#", "#", "#" },//
                { "#", "#", "#", "#", " ", "#", "#", "#", " ", "#"," ", "#", "#", "#", " ", "#", "#", "#", "#" },//
                { "#", " ", " ", " ", " ", "#", " ", " ", " ", "#"," ", " ", " ", "#", " ", " ", " ", " ", "#" },//
                { "#", " ", "#", "#", " ", "#", " ", "#", "#", "#","#", "#", " ", "#", " ", "#", "#", " ", "#" },//
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " "," ", " ", " ", " ", " ", " ", " ", " ", "#" },//
                { "#", " ", "#", "#", " ", "#", "#", "#", " ", "#"," ", "#", "#", "#", " ", "#", "#", " ", "#" },//
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", "#"," ", " ", " ", " ", " ", " ", " ", " ", "#" },//                
                { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#","#", "#", "#", "#", "#", "#", "#", "#", "#" },//     
            };
            return maze;

        }



    }
}