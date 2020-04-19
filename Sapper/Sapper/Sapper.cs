using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Sapper
{
    class Sapper
    {
        public static int count_of_buttons = 25;
        public static bool winds = true;

        public static int score = 0;
        public static int count_of_bombs = 3;
        public static int max_score = count_of_buttons - count_of_bombs;

        
        public static int[] bombs;



        public static int[] images = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };



        public static void Creating(int count_of_bombs)
        {
            max_score = count_of_buttons - count_of_bombs;
            Random random = new Random();
            bombs = new int[count_of_bombs];
            bool alreadyThere;
            for (int i = 0; i < bombs.Length;)
            {
                alreadyThere = false;
                int bomb = random.Next(1, 26);

                for (int j = 0; j < i; j++)
                {
                    if (bombs[j] == bomb)
                    {
                        alreadyThere = true;
                        break;
                    }
                }

                if (!alreadyThere)
                {
                    bombs[i] = bomb;
                    i++;
                }

            }
        }

        public static void gover(bool res)
        {
            if (res == true)
            {
                MessageBox.Show(
                        "\n\n\n                GAME OVER!        \n" +
                        "\n\n\n\n\n\n" +
                $"                        Your score: {Sapper.score}");
                
            }



        }

        public static void Congrat(bool res)
        {
            if (res == true)
            {
                MessageBox.Show(
                            "\n\n\n                 YOU WIN!         \n" +
                            "\n\n\n\n\n\n" +
                    $"                        Your score: {Sapper.score}\n" +
                    $"\n\n\n(rus: С Победой!)");
            }
        }

        



    }

    
}
