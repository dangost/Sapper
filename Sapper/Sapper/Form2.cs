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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string count_str = textBox1.Text;
            int count = 3;

            try
            {
                count = Convert.ToInt32(count_str);
            }

            catch(FormatException)
            {
                MessageBox.Show("Input number!");
            }

            if(count < 0 || count > 25)
            {
                MessageBox.Show("Input true count (0-25)");
            }

            Sapper.count_of_bombs = count;
            this.Close();
            
            //Sapper.Creating(Sapper.count_of_bombs);
            /* Form1 Form1 = new Form1();
            Sapper.Creating();
            Form1.clicking_array();
            Sapper.score = 0;
            Form1.label1.Text = $"Score  {Sapper.score}";
            Form1.button1.Image = null;
            Form1.button2.Image = null;
            Form1.button3.Image = null;
            Form1.button4.Image = null;
            Form1.button5.Image = null;
            Form1.button6.Image = null;
            Form1.button7.Image = null;
            Form1.button8.Image = null;
            Form1.button9.Image = null;
            Form1.button10.Image = null;
            Form1.button11.Image = null;
            Form1.button12.Image = null;
            Form1.button13.Image = null;
            Form1.button14.Image = null;
            Form1.button15.Image = null;
            Form1.button16.Image = null;
            Form1.button17.Image = null;
            Form1.button18.Image = null;
            Form1.button19.Image = null;
            Form1.button20.Image = null;
            Form1.button21.Image = null;
            Form1.button22.Image = null;
            Form1.button23.Image = null;
            Form1.button24.Image = null;
            Form1.button25.Image = null;*/
        }
    }
}
