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
    public partial class Frm_OnePlayar : Form
    {
        public Frm_OnePlayar()
        {
            InitializeComponent();
        }

        private void borderPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borderPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMin frm = new FrmMin();
            frm.Show();

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

      //  List<Button> buttons;
       // Random rand = new Random();
       // int player1 = 0;
       // int player2 = 0;
      //  void loadbuttons()
      //  {
      //      buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

      //  }
          
                        
        private void Frm_OnePlayer_load(object sender, EventArgs e)
        {

        }
        private char currentPlayer = 'x';
        private void btn1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            //للتأكد من ان المربع غير محجوز بالفعل

            if (clickedButton.Text == "")
            {
                //تحديد نص المربع 
                clickedButton.Text = currentPlayer.ToString();
                //تغيير اللاعب الحالي
                currentPlayer = (currentPlayer == 'x') ? 'o' : 'x';
            }
        }
        
        private void btn2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            //للتأكد من ان المربع غير محجوز بالفعل

            if (clickedButton.Text == "")
            {
                //تحديد نص المربع 
                clickedButton.Text = currentPlayer.ToString();
                //تغيير اللاعب الحالي
                currentPlayer = (currentPlayer == 'x') ? 'o' : 'x';
            }

        }


    }
}
