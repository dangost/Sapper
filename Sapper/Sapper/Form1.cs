using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
            MessageBox.Show("Dev. by FAFAFA");
            Sapper.Creating(Sapper.count_of_bombs);
            clicking_array();
            
        }

        static int count_of_buttons = 26;  //+0
        public static bool[] clicked = new bool[count_of_buttons];

        public static void clicking_array(bool res = false)
        {
            for (int i = 0; i < clicked.Length; i++)
            {
                clicked[i] = res;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int button_id = 1;

            if (clicked[button_id] == false)
            {

                
                bool is_bomb = false;

                for (int i = 0; i < Sapper.bombs.Length; i++)
                {
                    if (button_id == Sapper.bombs[i])
                    {
                        is_bomb = true;
                    }
                }

                if (is_bomb != true)
                {
                    Random random = new Random();
                    int ico = random.Next(1, 24);

                    button1.Image = Image.FromFile($"Icons\\{ico}.png");
                    Sapper.score++;
                    label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
                else if (is_bomb == true)
                {
                    button1.Image = Image.FromFile(@"Icons\0.png");
                    Sapper.gover(Sapper.winds);

                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch(bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }


            }
            clicked[button_id] = true;

            

        }

        public void button2_Click(object sender, EventArgs e)
        {
            int button_id = 2;
            if (clicked[button_id] == false)
            {
                bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button2.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button2.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);



                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }

                }
            }
            clicked[button_id] = true;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            int button_id = 3;
                if (clicked[button_id] == false)
                {
                    bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button3.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button3.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);


                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            int button_id = 4;
                    if (clicked[button_id] == false)
                    {
                        bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button4.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button4.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            int button_id = 5;
                        if (clicked[button_id] == false)
                        {
                            bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button5.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button5.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }


            }
            clicked[button_id] = true;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            int button_id = 6;
                            if (clicked[button_id] == false)
                            {
                                bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button6.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)

            {
                button6.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            int button_id = 7;
                                if (clicked[button_id] == false)
                                {
                                    bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button7.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button7.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            int button_id = 8;
                                    if (clicked[button_id] == false)
                                    {
                                        bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button8.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button8.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            int button_id = 9;
                                        if (clicked[button_id] == false)
                                        {
                                            bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button9.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button9.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button10_Click(object sender, EventArgs e)
        {
            int button_id = 10;
                                            if (clicked[button_id] == false)
                                            {
                                                bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button10.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button10.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            int button_id = 11;
                                                if (clicked[button_id] == false)
                                                {
                                                    bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button11.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button11.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button12_Click(object sender, EventArgs e)
        {
            int button_id = 12;
                                                    if (clicked[button_id] == false)
                                                    { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button12.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button12.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button13_Click(object sender, EventArgs e)
        {
            int button_id = 13; if (clicked[button_id] == false)
            { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button13.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button13.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }

            }
            clicked[button_id] = true;
        }

        public void button14_Click(object sender, EventArgs e)
        {
            int button_id = 14;
                                                        if (clicked[button_id] == false)
                                                        { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button14.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button14.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button15_Click(object sender, EventArgs e)
        {
            int button_id = 15;
                                                            if (clicked[button_id] == false)
                                                            { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button15.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button15.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button16_Click(object sender, EventArgs e)
        {
            int button_id = 16; if (clicked[button_id] == false)
                                                                { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button16.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button16.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button17_Click(object sender, EventArgs e)
        {
            int button_id = 17; if (clicked[button_id] == false)
                                                                    { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button17.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button17.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button18_Click(object sender, EventArgs e)
        {
            int button_id = 18; if (clicked[button_id] == false)
                                                                        { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button18.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);

                    }
                }
            else if (is_bomb == true)
            {
                button18.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button19_Click(object sender, EventArgs e)
        {
            int button_id = 19; if (clicked[button_id] == false)
                                                                            { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button19.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button19.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button20_Click(object sender, EventArgs e)
        {
            int button_id = 20; if (clicked[button_id] == false)
                                                                                { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button20.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);

                    }
                }
            else if (is_bomb == true)
            {
                button20.Image = Image.FromFile(@"Icons\0.png");
                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button21_Click(object sender, EventArgs e)
        {
            int button_id = 21; if (clicked[button_id] == false)
                                                                                    { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button21.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button21.Image = Image.FromFile(@"Icons\0.png");

                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button22_Click(object sender, EventArgs e)
        {
            int button_id = 22; if (clicked[button_id] == false)
                                                                                        { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button22.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button22.Image = Image.FromFile(@"Icons\0.png");

                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button23_Click(object sender, EventArgs e)
        {
            int button_id = 23; if (clicked[button_id] == false)
                                                                                            { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button23.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button23.Image = Image.FromFile(@"Icons\0.png");

                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;

        }

        public void button24_Click(object sender, EventArgs e)
        {
            int button_id = 24; if (clicked[button_id] == false)
                                                                                                { bool is_bomb = false;

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {
                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button24.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button24.Image = Image.FromFile(@"Icons\0.png");

                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            clicked[button_id] = true;
        }

        public void button25_Click(object sender, EventArgs e)
        {
            bool is_bomb = false; int button_id = 25; if (clicked[button_id] == false)
            {

            for (int i = 0; i < Sapper.bombs.Length; i++)
            {
                if (button_id == Sapper.bombs[i])
                {

                    is_bomb = true;
                }
            }

            if (is_bomb != true)
            {
                Random random = new Random();
                int ico = random.Next(1, 24);

                button25.Image = Image.FromFile($"Icons\\{ico}.png");
                Sapper.score++;
                label1.Text = $"Score  {Sapper.score}";
                    if (Sapper.score == Sapper.max_score)
                    {
                        Sapper.Congrat(Sapper.winds);
                        clicking_array(true);
                    }
                }
            else if (is_bomb == true)
            {
                button25.Image = Image.FromFile(@"Icons\0.png");

                Sapper.gover(Sapper.winds);
                    clicking_array(true);

                    for (int bid = 1; bid <= Sapper.count_of_buttons; bid++)
                    {
                        for (int i = 0; i < Sapper.bombs.Length; i++)
                        {
                            if (bid == Sapper.bombs[i]) // it a bomb
                            {
                                switch (bid)
                                {

                                    case 1:
                                        button1.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 2:
                                        button2.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 3:
                                        button3.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 4:
                                        button4.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 5:
                                        button5.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 6:
                                        button6.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 7:
                                        button7.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 8:
                                        button8.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 9:
                                        button9.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 10:
                                        button10.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 11:
                                        button11.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 12:
                                        button12.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 13:
                                        button13.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 14:
                                        button14.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 15:
                                        button15.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 16:
                                        button16.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 17:
                                        button17.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 18:
                                        button18.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 19:
                                        button19.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 20:
                                        button20.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 21:
                                        button21.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 22:
                                        button22.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 23:
                                        button23.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 24:
                                        button24.Image = Image.FromFile(@"Icons\0.png");
                                        break;

                                    case 25:
                                        button25.Image = Image.FromFile(@"Icons\0.png");
                                        break;
                                }
                            }
                        }
                    }

                }
            }
            clicked[button_id] = true;
        }

        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "  Developed by FAFAFA Inc." +
                "\n");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sapper.Creating(Sapper.count_of_bombs);
            clicking_array();
            Sapper.score = 0;
            label1.Text = $"Score  {Sapper.score}";
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            button10.Image = null;
            button11.Image = null;
            button12.Image = null;
            button13.Image = null;
            button14.Image = null;
            button15.Image = null;
            button16.Image = null;
            button17.Image = null;
            button18.Image = null;
            button19.Image = null;
            button20.Image = null;
            button21.Image = null;
            button22.Image = null;
            button23.Image = null;
            button24.Image = null;
            button25.Image = null;
        }

        private void bombsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }
    }
}
