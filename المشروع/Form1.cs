using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace المشروع
{
    public partial class Form1 : Form

         


    {
        public SoundPlayer tmsound;
       
        public SoundPlayer game;

        public SoundPlayer SWINN;

        public Form1()
        {
            InitializeComponent();

            SWINN = new SoundPlayer("SWIN.WAV");
            tmsound = new SoundPlayer("countdown.WAV");
            game = new SoundPlayer ("Game1.WAV");
           
           
        }
       

         
        public void hiddingnumbers()
        {
            foreach (Label item in this.groupBox1.Controls)
            {
                item.Text = "";
            }
        }

        

     

       public void show()
        {
            lb1.Text = num1.ToString();
            lb2.Text = num2.ToString();
            lb3.Text = num3.ToString();
            lb4.Text = num4.ToString();
        }
       
        public void GetNumbers()
        {
             Random r = new Random();
            while (true)
            {
                num1 = r.Next(0, 9);
                num2 = r.Next(0, 9);
                num3 = r.Next(0, 9);
                num4 = r.Next(0, 9);

                if( num1 !=num2 && num1!=num3 && num1!=num4 && num2!=num3 && num2!=num4 && num3!=num4 )
                {
                    break;
                }
            }
        }
       
        public void DeleteNum()
        {
            foreach (TextBox item in this.groupBox2.Controls)
            {
                item.Text = " ";
                item.BackColor = Color.White;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int num1, num2, num3, num4;
        private void NewGame_click(object sender, EventArgs e)
        {
            
            GetNumbers();
            hiddingnumbers();
            DeleteNum();
            Display.Enabled = true;
            Hide.Enabled = true;
            Check.Enabled = true;
            tx1.Enabled = true;
            tx2.Enabled = true;
            tx3.Enabled = true;
            tx4.Enabled = true;
            this.BackColor =Color.FromName("Control");
            
            i = 30;
            tm.Start();
           
                tmsound.Stop();
             
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hiddingnumbers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //game.Play();
            GetNumbers();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           //----------------tx1
            if (tx1.Text == num1.ToString())
            {
                tx1.BackColor = Color.Green;
            }
            else if (tx1.Text == num2.ToString() || tx1.Text == num3.ToString() || tx1.Text == num4.ToString())
            {
                tx1.BackColor = Color.Yellow;
            }
            else
            {
                tx1.BackColor = Color.Red;
            }

            //----------------tx2
            if (tx2.Text == num2.ToString())
            {
                tx2.BackColor = Color.Green;
            }
            else if (tx2.Text == num1.ToString() || tx2.Text == num3.ToString() || tx2.Text == num4.ToString())
            {
                tx2.BackColor = Color.Yellow;
            }
            else
            {
                tx2.BackColor = Color.Red;
            }

            //----------------tx3
            if (tx3.Text == num3.ToString())
            {
                tx3.BackColor = Color.Green;
            }
            else if (tx3.Text == num1.ToString() || tx3.Text == num2.ToString() || tx3.Text == num4.ToString())
            {
                tx3.BackColor = Color.Yellow;
            }
            else
            {
                tx3.BackColor = Color.Red;
            }
            
                  //----------------tx4
            if (tx4.Text == num4.ToString())
            {
                tx4.BackColor = Color.Green;
            }
            else if (tx4.Text == num1.ToString() || tx4.Text == num3.ToString() || tx4.Text == num2.ToString())
            {
                tx4.BackColor = Color.Yellow;
            }
            else
            {
                tx4.BackColor = Color.Red;
            }

            if (tx1.Text==num1.ToString() && tx2.Text==num2.ToString() && tx3.Text==num3.ToString () && tx4.Text==num4.ToString() )
            {
                game.Stop();
               
                
                tmsound.Stop();
                SWINN.Play();
                show();
                tm.Stop();
                MessageBox.Show(" GREAT ");
                Display.Enabled = false;
                Hide.Enabled = false;
                Check.Enabled = false;
                tx1.Enabled = false;
                tx2.Enabled = false;
                tx3.Enabled = false;
                tx4.Enabled = false;

            }
            }


        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int i = 30;
       
            
    
        private void tm_Tick(object sender, EventArgs e)
        {
            i--;
            lbt.Text = i.ToString();

            while(i==29)
            {
                game.Play();
                break;
            }
           

            if (i == 6)

            {
                game.Stop();
                tmsound.Play();
             
               
            }
           
           
            
            if (i == 0)
            {
                tm.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show(" Time is Up");
                Display.Enabled = false;
                Hide.Enabled = false;
                Check.Enabled = false;
                tx1.Enabled = false;
                tx2.Enabled = false;
                tx3.Enabled = false;
                tx4.Enabled = false;
                show();

            }
        }

        private void lbt_Click(object sender, EventArgs e)
        {
           
        }

        private void tx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show(" Please Enter Valid Value ");
            }
        }

        private void tx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show(" Please Enter Valid Value ");
            }
        }

        private void tx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show(" Please Enter Valid Value ");
            }
        }

        private void tx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show(" Please Enter Valid Value ");
            }
        }

        private void tx3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx4_TextChanged(object sender, EventArgs e)
        {

        }

        public SoundPlayer win_ { get; set; }
    }
}
