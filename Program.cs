

namespace Tictactoe {

    class Programm
    {
        static string player1 = "";
        static string player2 = "";
        static char[] playField = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int repeat = 0;
        static int choice;
        static bool playing = true;
        static bool flag = false, correntInput = false;

        public static void Main(string[] args) //Main Methode
        {
            Console.WriteLine("Wie heißt Spieler-1?");
            player1 = Console.ReadLine();
            Console.WriteLine("Wie heißt Spieler-2?");
            player2 = Console.ReadLine();
            Console.WriteLine("{0} ist X und {1} ist O", player1, player2);
            Console.WriteLine("{0} fängt an!", player1);
            Console.ReadLine();
            Console.Clear();

            while(playing == true)
            {
                while(flag = false)
                {
                    Field();
                }
            }
        }

        public static void Field() //Spielfeld Methode
        {
            Console.Clear();
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1], playField[2], playField[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[4], playField[5], playField[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[7], playField[8], playField[9]);
            repeat++;
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
            else if (playField[1] != '1' && playField[2] != '2' && playField[3] != '3' && playField[4] != '4' && playField[5] != '5' && playField[6] != '6' && playField[7] != '7' && playField[8] != '8' && playField[9] != '9')
            {
                return false;
            }
            return false;
        }
    }
}