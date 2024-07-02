using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        bool XTurn = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void ClearGame(string win)
        {
            MessageBox.Show(win);
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (XTurn==true) 
            {
                button.Text = "X";
                button.Enabled = false;
                XTurn=false;
            }
            else
            {
                button.Text = "0";
                button.Enabled = false;
                XTurn=true;
            }
            CheckWin();
        }
        private void CheckWin()
        {
            //if (button1.Text == button2.Text & button1.Text == button3.Text & button1.Text == "X") ClearGame("X победил");
            //else if (button1.Text == button2.Text & button1.Text == button3.Text & button1.Text == "0") ClearGame("0 победил");
            //else if (button4.Text == button5.Text & button4.Text == button6.Text & button4.Text == "X") ClearGame("X победил");
            //else if (button4.Text == button5.Text & button4.Text == button6.Text & button4.Text == "0") ClearGame("0 победил");
            //else if (button7.Text == button8.Text & button7.Text == button9.Text & button7.Text == "X") ClearGame("X победил");
            //else if (button7.Text == button8.Text & button7.Text == button9.Text & button7.Text == "0") ClearGame("0 победил");

            //else if (button1.Text == button4.Text & button1.Text == button7.Text & button1.Text == "X") ClearGame("X победил");
            //else if (button1.Text == button4.Text & button1.Text == button7.Text & button1.Text == "0") ClearGame("0 победил");
            //else if (button2.Text == button5.Text & button2.Text == button8.Text & button2.Text == "X") ClearGame("X победил");
            //else if (button2.Text == button5.Text & button2.Text == button8.Text & button2.Text == "0") ClearGame("0 победил");
            //else if (button3.Text == button6.Text & button3.Text == button9.Text & button3.Text == "X") ClearGame("X победил");
            //else if (button3.Text == button6.Text & button3.Text == button9.Text & button3.Text == "0") ClearGame("0 победил");

            //else if (button1.Text == button5.Text & button1.Text == button9.Text & button1.Text == "X") ClearGame("X победил");
            //else if (button1.Text == button5.Text & button1.Text == button9.Text & button1.Text == "0") ClearGame("0 победил");
            //else if (button3.Text == button5.Text & button3.Text == button7.Text & button3.Text == "X") ClearGame("X победил");
            //else if (button3.Text == button5.Text & button3.Text == button7.Text & button3.Text == "0") ClearGame("0 победил");

            ////else if (button1.Text != " " & button2.Text != " " & button3.Text != " " & button4.Text != " " & button5.Text != " " & button6.Text != " " & button7.Text != " " & button8.Text != " " & button9.Text != " ") ClearGame("Ничья");
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
        }
    }
}
