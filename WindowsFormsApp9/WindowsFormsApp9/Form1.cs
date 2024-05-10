using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            isTurnX = true;
            isWin = false;
            turnO.Visible = false;
        }

        private bool isTurnX;
        private bool isWin;

        private void Turn()
        {
            if (isTurnX)
            {
                turnX.Visible = true;
                turnO.Visible = false;

            }
            else
            {
                turnX.Visible = false;
                turnO.Visible = true;
            }
        }
        private void WhoWin(string text)
        {
            if (text == "O")
            {
                winOLabel.Visible = true;
            }
            else
            {
                wnXLabel.Visible = true;
            }
        }
        private void Win(int isWinGame)
        {
            switch (isWinGame)
            {
                case 1:
                    end1.Visible = true;
                    WhoWin(upLeftL.Text);
                    panel1.Enabled = false;
                    break;
                case 2:
                    end2.Visible = true;
                    WhoWin(leftL.Text);
                    panel1.Enabled = false;

                    break;
                case 3:
                    end3.Visible = true;
                    WhoWin(downLeftL.Text);
                    panel1.Enabled = false;
                    break;
                case 4:
                    end4.Visible = true;
                    WhoWin(downLeftL.Text);
                    panel1.Enabled = false;
                    break;
                case 5:
                    end5.Visible = true;
                    WhoWin(upL.Text);
                    panel1.Enabled = false;
                    break;
                case 6:
                    end6.Visible = true;
                    WhoWin(upRightL.Text);
                    panel1.Enabled = false;
                    break;
                case 7:
                    end71.Visible = true;
                    end72.Visible = true;
                    end73.Visible = true;
                    WhoWin(upRightL.Text);
                    panel1.Enabled = false;
                    break;
                case 8:
                    end81.Visible = true;
                    end82.Visible = true;
                    end83.Visible = true;
                    WhoWin(upLeftL.Text);
                    panel1.Enabled = false;
                    break;
                case 0:
                    lostLabel.Visible = true;
                    panel1.Enabled = false;
                    break;

            }
        }

        private int IsWinGame()
        {
            if (!upLeft.Enabled && !up.Enabled && !upRight.Enabled && (upLeftL.Text == upL.Text && upL.Text == upRightL.Text))
            {
                return 1;
            }
            if (!left.Enabled && !center.Enabled && !right.Enabled && (leftL.Text == centerL.Text && centerL.Text == RightL.Text))
            {
                return 2;
            }
            if (!downLeft.Enabled && !down.Enabled && !downRight.Enabled && (downLeftL.Text == downL.Text && downL.Text == downRightL.Text))
            {
                return 3;
            }
            if (!downLeft.Enabled && !left.Enabled && !upLeft.Enabled && (downLeftL.Text == leftL.Text && leftL.Text == upLeftL.Text))
            {
                return 4;
            }
            if (!up.Enabled && !center.Enabled && !down.Enabled && (upL.Text == centerL.Text && centerL.Text == downL.Text))
            {
                return 5;
            }
            if (!upRight.Enabled && !right.Enabled && !downRight.Enabled && (upRightL.Text == RightL.Text && RightL.Text == downRightL.Text))
            {
                return 6;
            }
            if (!upRight.Enabled && !center.Enabled && !downLeft.Enabled && (upRightL.Text == centerL.Text && centerL.Text == downLeftL.Text))
            {
                return 7;
            }
            if (!upLeft.Enabled && !center.Enabled && !downRight.Enabled && (upLeftL.Text == centerL.Text && centerL.Text == downRightL.Text))
            {
                return 8;
            }
            if(!upLeft.Enabled && !up.Enabled && !upRight.Enabled && !left.Enabled && !center.Enabled && !right.Enabled && !downLeft.Enabled && !down.Enabled && downRight.Enabled)
            { 
                return 0;
            }
            return 9;
        }

        private void upLeft_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                upLeftL.Text = "X";
                isTurnX = false;
            }
            else
            {
                upLeftL.Text = "O";
                isTurnX = true;
            }
            Turn();
            upLeft.Enabled = false;
            Win(IsWinGame());
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                upL.Text = "X";
                isTurnX = false;
            }
            else
            {
                upL.Text = "O";
                isTurnX = true;
            }
            Turn();
            up.Enabled = false;
            Win(IsWinGame());
        }

        private void upRight_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                upRightL.Text = "X";
                isTurnX = false;
            }
            else
            {
                upRightL.Text = "O";
                isTurnX = true;
            }
            Turn();
            upRight.Enabled = false;
            Win(IsWinGame());
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                leftL.Text = "X";
                isTurnX = false;
            }
            else
            {
                leftL.Text = "O";
                isTurnX = true;
            }
            Turn();
            left.Enabled = false;
            Win(IsWinGame());
        }

        private void center_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                centerL.Text = "X";
                isTurnX = false;
            }
            else
            {
                centerL.Text = "O";
                isTurnX = true;
            }
            Turn();
            center.Enabled = false;
            Win(IsWinGame());
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                RightL.Text = "X";
                isTurnX = false;
            }
            else
            {
                RightL.Text = "O";
                isTurnX = true;
            }
            Turn();
            right.Enabled = false;
            Win(IsWinGame());
        }

        private void downLeft_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                downLeftL.Text = "X";
                isTurnX = false;
            }
            else
            {
                downLeftL.Text = "O";
                isTurnX = true;
            }
            Turn();
            downLeft.Enabled = false;
            Win(IsWinGame());
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                downL.Text = "X";
                isTurnX = false;
            }
            else
            {
                downL.Text = "O";
                isTurnX = true;
            }
            Turn();
            down.Enabled = false;
            Win(IsWinGame());
        }

        private void downRight_Click(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                downRightL.Text = "X";
                isTurnX = false;
            }
            else
            {
                downRightL.Text = "O";
                isTurnX = true;
            }
            Turn();
            downRight.Enabled = false;
            Win(IsWinGame());
        }
    }
}
