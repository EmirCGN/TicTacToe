

using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Sources;

namespace Tictactoe {

    class Programm
    {
        static string player1 = "";
        static string player2 = "";
        static int score1 = 0, score2 = 0;
        static string[] playField = new string[10] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        static int repeat = 0;
        static int choice;
        static int turn = 1;
        static bool playing = true;
        static bool flag = false, correntInput = false;

        public static void Main(string[] args) //Main Methode
        {
            Console.WriteLine("  _______ _   _______      _______         \r\n |__   __(_) |__   __|    |__   __|        \r\n    | |   _  ___| | __ _  ___| | ___   ___ \r\n    | |  | |/ __| |/ _` |/ __| |/ _ \\ / _ \\\r\n    | |  | | (__| | (_| | (__| | (_) |  __/\r\n    |_|  |_|\\___|_|\\__,_|\\___|_|\\___/ \\___|\r\n                                           \r\n                                           ");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Wie heißt Spieler-1?");
            player1 = Console.ReadLine();
            Console.WriteLine("Wie heißt Spieler-2?");
            player2 = Console.ReadLine();
            Console.WriteLine("{0} ist X und {1} ist O", player1, player2);
            Console.WriteLine("{0} fängt an!", player1);
            Console.ReadLine();
            Console.Clear();

            while(playing == false)
            {
                while(flag = false) // Game-Loop
                {
                    Field();
                    Console.WriteLine("");

                    Console.WriteLine("Score: {0} - {1}     {2} - {3}", player1, score1, player2, score2);
                    if (turn== 1)
                    {
                        Console.WriteLine("{0} ist dran (X) ", player1);
                    }
                    if (turn == 2)
                    {
                        Console.WriteLine("{0} ist dran (O)", player2);
                    }
                    while(correntInput == false)
                    {
                        Console.WriteLine("Bitte wählen Sie ein Feld aus!");
                        choice = int.Parse(Console.ReadLine());
                        if (choice > 0 && choice < 10)
                        {
                            correntInput = true;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    correntInput = false; //Zurücksetzen

                    if (turn == 1)
                    {
                        if (playField[choice] == "X") //Überprüft ob das Feld besetzt ist
                        {
                            Console.WriteLine("Dieser Feld ist bereits besetzt!");
                            Console.ReadLine();
                            Console.Clear(); //Konsole wird einmal sauber gemacht
                            continue; //Beendet die Iteration und lässt direkt den nächsten beginnen
                        }
                        else
                        {
                            playField[choice] = "O";
                        }
                        if (turn == 2)
                        {
                            if(playField[choice] == "O") //Überprüft ob das Feld besetzt ist
                            {
                                Console.WriteLine("Dieser Feld ist bereits besetzt!");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                playField[choice] = "X";
                            }
                        }
                        flag = CheckWin();

                        if(flag == false)
                        {
                            if(turn == 1)
                            {
                                turn = 2;
                            }else if(turn == 2)
                            {
                                turn = 1;
                            }
                            Console.Clear();
                        }
                    }
                    Console.Clear();
                    Field();

                    for(int i = 1; i < 10; i++)
                    {
                        playField[i] = i.ToString();
                    }

                    if(flag == false)
                    {

                    }
                }
            }
        }

        public static void Field() //Spielfeld Methode
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1], playField[2], playField[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[4], playField[5], playField[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[7], playField[8], playField[9]);
            Console.WriteLine("     |     |      ");
            repeat++;

            //   |   |
            // 1 | 2 | 3
            //---+---+---
            // 4 | 5 | 6
            //---+---+---
            // 7 | 8 | 9
            //   |   |
        }

        public static bool CheckWin()
        {
            //Horizontal 
            if (playField[1] == playField[2] && playField[2] == playField[3]) //(Erste Reihe)
            {
                return true;
            }
            else if (playField[4] == playField[5] && playField[5] == playField[6]) //(Zweite Reihe)
            {
                return true;
            }
            else if (playField[6] == playField[7] && playField[7] == playField[8]) //(Dritte Reihe)
            {
                return true;
            }
            //Vertikal
            else if (playField[1] == playField[4] && playField[4] == playField[7]) //(Erste Reihe)
            {
                return true;
            }
            else if (playField[2] == playField[5] && playField[5] == playField[8]) //(Zweite Reihe)
            {
                return true;
            }
            else if (playField[3] == playField[6] && playField[6] == playField[9]) //(Dritte Reihe)
            {
                return true;
            }
            //Diagonal 
            else if (playField[1] == playField[5] && playField[5] == playField[9])
            {
                return true;
            }
            else if (playField[3] == playField[5] && playField[5] == playField[7])
            {
                return true;
            }
            //Unentschieden 
            else if (playField[1] != "1" && playField[2] != "2" && playField[3] != "3" && playField[4] != "4" && playField[5] != "5" && playField[6] != "6" && playField[7] != "7" && playField[8] != "8" && playField[9] != "9")
            {
                return false;
            }
            return true;

        }
    }
}
