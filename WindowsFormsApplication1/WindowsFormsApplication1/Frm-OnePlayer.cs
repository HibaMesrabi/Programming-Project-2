using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_OnePlayer : Form
    {

        public Frm_OnePlayer()
        {
            InitializeComponent();
        }
        public bool checkWIn()
        {

            return true;
        }

        private char currentPlayer = 'X';
        private void button13_Click(object sender, EventArgs e)
        {
            //التأكد من ان المربع غير محجوز 
           if (btn1.Text == "")
            {
               //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn1.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer =( currentPlayer  == 'X' ) ? 'O' : 'X' ;
                if ((btn1.Text == "O" && btn2.Text == "O" &&  btn3.Text == "O") || (btn1.Text == "X" && btn2.Text == "X" &&  btn3.Text == "X")) 
                {
                    btn1.BackColor = Color.Red;
                    btn3.BackColor = Color.Red;
                    btn2.BackColor = Color.Red;
                    finishGame();
                }

                if ((btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") || (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X"))
                {
                    btn1.BackColor = Color.Red;
                    btn4.BackColor = Color.Red;
                    btn7.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X"))
                {
                    btn1.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
         
            //التأكد من ان المربع غير محجوز 
             if (btn2.Text == "")
             {
                 //تحديث نص المربع لبكون اما x او o حسب اللاعب
                 btn2.Text = currentPlayer.ToString();
                 // تغيير اللاعب الحالي 
                 currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                 if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X"))
                 {
                     btn1.BackColor = Color.Red;
                     btn2.BackColor = Color.Red;
                     btn3.BackColor = Color.Red;
                     finishGame();
                 }

                 if ((btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") || (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X"))
                 {
                     btn2.BackColor = Color.Red;
                     btn5.BackColor = Color.Red;
                     btn8.BackColor = Color.Red;
                     finishGame();
                 }
                 
             }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn3.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';

                if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X"))
                {
                    btn1.BackColor = Color.Red;
                    btn3.BackColor = Color.Red;
                    btn2.BackColor = Color.Red;
                    finishGame();
                }

                if ((btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") || (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X"))
                {
                    btn6.BackColor = Color.Red;
                    btn6.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                {
                    btn3.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn7.BackColor = Color.Red;
                    finishGame();
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn4.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                if ((btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") || (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X"))
                {
                    btn1.BackColor = Color.Red;
                    btn4.BackColor = Color.Red;
                    btn7.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn5.Text == "X" && btn4.Text == "X" && btn6.Text == "X"))
                {
                    btn4.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn6.BackColor = Color.Red;
                    finishGame();
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn5.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';

                if ((btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                {
                    btn3.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn7.BackColor = Color.Red;
                    finishGame();
                }
                
                if ((btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X"))
                {
                    btn1.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }

                if ((btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") || (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X"))
                {
                    btn2.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn8.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn5.Text == "X" && btn4.Text == "X" && btn6.Text == "X"))
                {
                    btn4.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn6.BackColor = Color.Red;
                    finishGame();
                }
            }
        }
        
        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn6.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                if ((btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") || (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X"))
                {
                    btn6.BackColor = Color.Red;
                    btn3.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn5.Text == "X" && btn4.Text == "X" && btn6.Text == "X"))
                {
                    btn4.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn6.BackColor = Color.Red;
                    finishGame();
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn7.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                if ((btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") || (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X"))
                {
                    btn1.BackColor = Color.Red;
                    btn4.BackColor = Color.Red;
                    btn7.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X"))
                {
                    btn7.BackColor = Color.Red;
                    btn8.BackColor = Color.Red;
                    finishGame();
                    btn9.BackColor = Color.Red;
                }
                if ((btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                {
                    btn5.BackColor = Color.Red;
                    btn3.BackColor = Color.Red;
                    btn7.BackColor = Color.Red;
                    finishGame();
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn8.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                if ((btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X"))
                {
                    btn7.BackColor = Color.Red;
                    btn8.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") || (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X"))
                {
                    btn5.BackColor = Color.Red;
                    btn2.BackColor = Color.Red;
                    btn8.BackColor = Color.Red;
                    finishGame();
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                //تحديث نص المربع لبكون اما x او o حسب اللاعب
                btn9.Text = currentPlayer.ToString();
                // تغيير اللاعب الحالي 
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                if ((btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") || (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X"))
                {
                    btn6.BackColor = Color.Red;
                    btn3.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X"))
                {
                    btn7.BackColor = Color.Red;
                    btn8.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }
                if ((btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X"))
                {
                    btn1.BackColor = Color.Red;
                    btn5.BackColor = Color.Red;
                    btn9.BackColor = Color.Red;
                    finishGame();
                }
            }
        }
        private void finishGame()
        {
            if (btn1.BackColor == Color.Red)
            {
                if (btn1.Text == "X")
                {
                    labelP1.Text = (Convert.ToInt32(labelP1.Text) + 1).ToString();
                }
                else
                {
                    labelP2.Text = (Convert.ToInt32(labelP2.Text) + 1).ToString();
                }
            }
            else if (btn5.BackColor == Color.Red)
            {
                if (btn5.Text == "X")
                {
                    labelP1.Text = (Convert.ToInt32(labelP1.Text) + 1).ToString();
                }
                else
                {
                    labelP2.Text = (Convert.ToInt32(labelP2.Text) + 1).ToString();
                }
            }
            else if (btn9.BackColor == Color.Red)
            {
                if (btn9.Text == "X")
                {
                    labelP1.Text = (Convert.ToInt32(labelP1.Text) + 1).ToString();
                }
                else
                {
                    labelP2.Text = (Convert.ToInt32(labelP2.Text) + 1).ToString();
                }
            }
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
        }
        private void button29_Click(object sender, EventArgs e)
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = null;
            btn1.BackColor = btn2.BackColor = btn3.BackColor = btn4.BackColor = btn5.BackColor = btn6.BackColor = btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.Transparent;
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
