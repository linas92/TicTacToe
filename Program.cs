using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[,] playField =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            string stringInput;
            bool isInputValid = true;

            SetField();

            #region//Check for the winning condition


            #endregion
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }

                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                SetField();
#region //Test if field is already taken
                do
                {
                    Console.WriteLine($"Player {player} please choose the field.");

                    isInputValid = int.TryParse(stringInput = Console.ReadLine(), out input);

                    if (input == 1 && playField[0, 0] == '1')
                    {
                        isInputValid = true;
                    }

                    else if (input == 2 && playField[0, 1] == '2')
                    {
                        isInputValid = true;
                    }

                    else if (input == 3 && playField[0, 2] == '3')
                    {
                        isInputValid = true;
                    }

                    else if (input == 4 && playField[1, 0] == '4')
                    {
                        isInputValid = true;
                    }

                    else if (input == 5 && playField[1, 1] == '5')
                    {
                        isInputValid = true;
                    }

                    else if (input == 6 && playField[1, 2] == '6')
                    {
                        isInputValid = true;
                    }

                    else if (input == 7 && playField[2, 0] == '7')
                    {
                        isInputValid = true;
                    }

                    else if (input == 8 && playField[2, 1] == '8')
                    {
                        isInputValid = true;
                    }

                    else if (input == 9 && playField[2, 2] == '9')
                    {
                        isInputValid = true;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect input. Please use a field that is empty");
                        isInputValid = false;
                    }

                } while (isInputValid != true);
#endregion 

            } while (isInputValid);
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {playField[0, 0]}  |  {playField[0, 1]}  |  {playField[0, 2]} ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {playField[1, 0]}  |  {playField[1, 1]}  |  {playField[1, 2]} ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {playField[2, 0]}  |  {playField[2, 1]}  |  {playField[2, 2]} ");
            Console.WriteLine("     |     |     ");
        }
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
            {
                playerSign = 'X';
            }
            else if (player == 2)
            {
                playerSign = 'O';
            }
            switch (input)
            {
                case 1:
                    playField[0, 0] = playerSign;
                    break;
                case 2:
                    playField[0, 1] = playerSign;
                    break;
                case 3:
                    playField[0, 2] = playerSign;
                    break;
                case 4:
                    playField[1, 0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1, 2] = playerSign;
                    break;
                case 7:
                    playField[2, 0] = playerSign;
                    break;
                case 8:
                    playField[2, 1] = playerSign;
                    break;
                case 9:
                    playField[2, 2] = playerSign;
                    break;
            }
        }
    }
}

