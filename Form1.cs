using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Media;
using WMPLib;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private bool isPlayerOneTurn ;
        private int buttonClickCount;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
         //SoundPlayer sp = new SoundPlayer();
        //System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
       
        public Form1()
        {
            InitializeComponent();

            //sp.SoundLocation = "s.mp3";
            player.URL = "s.mp3";

            label5.Text = DateTime.Now.ToLongTimeString();
        }


        //jb start game p click kro to ye ay
        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.controls.play();

            EnableButton(true);

            startNewGameToolStripMenuItem.Enabled = false;
            resetToolStripMenuItem.Enabled = true;
            EnablePlayerOption(false);

            isPlayerOneTurn = playeronestartradioButton.Checked; // start kha sy lna ha ye usky lye code ha player one k two sy
            //jsko check yni jsko select krygy wo player one hoga

            buttonClickCount = 0;

        }
        private void EnableButton(bool enable) {
            b1button.Enabled = enable;
            b2button.Enabled = enable;
            b3button.Enabled = enable;
            b4button.Enabled = enable;
            b5button.Enabled = enable;
            b6button.Enabled = enable;
            b7button.Enabled = enable;
            b8button.Enabled = enable;
            b9button.Enabled = enable;
        }




        //exit k lye code
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Application.Exit();
        }

        /// <summary>
        /// ABOUT K LYE CODE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Right Reserved With hassanmalik.com", "About Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        //form load ho to ye diable ho
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            timer1.Interval = 20;
            //WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();
            //player.URL = @"C:\Users\Hassan\Downloads\Music\s";
            //sp.Play();
            EnableButton(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetToolStripMenuItem.Enabled = false;

        }

  




        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://allice9554.000webhostapp.com/");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            player.controls.stop();

            EnableButton(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetToolStripMenuItem.Enabled = false;
            EnablePlayerOption(true);

            clearButton();

        }

        private void clearButton()
        {
            b1button.Text = "";
            b2button.Text = "";
            b3button.Text = "";
            b4button.Text = "";
            b5button.Text = "";
            b6button.Text = "";
            b7button.Text = "";
            b8button.Text = "";
            b9button.Text = "";
        }





        private void EnablePlayerOption(bool enable)
        {
            playersnamegroupBox.Enabled=enable;
            selectxgroupBox.Enabled = enable;
            startplayergroupBox.Enabled = enable;


        }

        private void button_click(object sender, EventArgs e) //sb buttons ko slect krky kse ak pr click krdia
        {
            //botton k lye kia ha k jo btn dbay usi ka event ho
            //sender k zrye ye kam kryga r sender microsoft ka obj ha built in
            Button b = (Button)sender;
            if (isPlayerOneTurn == true)
            {
                if (playeronexradioButton.Checked) //x ksky sath ana chaia ye usky lye ha
                    // x ksko mly r 0 kskko ye uska code ha 4 lines ka
                    b.Text = "X";
                else
                    b.Text = "0";



                isPlayerOneTurn = false;
                b.Enabled = false;
            }
            else
            {
                if (playertwoxradioButton.Checked) // x ksko mly r 0 kskko ye uska code ha 4 lines ka
                    b.Text = "X";
                else
                    b.Text = "0";


                isPlayerOneTurn = true;
                b.Enabled = false;
            }
            buttonClickCount++; //jb sb button 9 tk full hojay to ye kam kryga 

            CheckTheWinner();
        }

        private void CheckTheWinner()
        {
            bool isWinner = false;

            if (buttonClickCount == 9)
            {
                MessageBox.Show("The Game is draw, please reset the game !!!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame(); //game reset hojay ye jo uper method bnaya ta usko call ki ha idr
            }
            else
            {
                //IDR SY START KRNA HA

                if ((b1button.Text == b2button.Text) && (b2button.Text == b3button.Text)/*&& (!b1button.Enabled)*/)
                    isWinner = true;
                else
                    if ((b4button.Text == b5button.Text) && (b5button.Text == b6button.Text) && (!b4button.Enabled))
                        isWinner = true;
                else    if ((b7button.Text == b8button.Text) && (b8button.Text == b9button.Text) && (!b7button.Enabled))
                    isWinner = true;
                        //ab colom k lye
                else if ((b1button.Text == b4button.Text) && (b4button.Text == b7button.Text) && (!b7button.Enabled))
                        isWinner = true;
                else if ((b2button.Text == b5button.Text) && (b5button.Text == b8button.Text) && (!b8button.Enabled))
                        isWinner = true;
                else if ((b3button.Text == b6button.Text) && (b6button.Text == b9button.Text) && (!b9button.Enabled))
                        isWinner = true;
                //ab cross ma combination k lye
                else if ((b1button.Text == b5button.Text) && (b5button.Text == b9button.Text) && (!b1button.Enabled))
                        isWinner = true;
                    else if ((b3button.Text == b6button.Text) && (b6button.Text == b7button.Text) && (!b7button.Enabled))
                        isWinner = true;




                if (isWinner == true)
                {
                    if (isPlayerOneTurn == false)
                       //essageBox.Show("Player ONE is The Winner !!! ", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(playeronenametextBox.Text + " is The Winner !!! ", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                       //essageBox.Show("Player TWO is The Winner !!! ", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(playertwonametextBox.Text + " is The Winner !!! ", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                
                }
            
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (marquelabel5.Left < 0 && (Math.Abs(marquelabel5.Left) > marquelabel5.Width))
                marquelabel5.Left = this.Width;

            marquelabel5.Left -= 1;

            label5.Text = DateTime.Now.ToLongTimeString();
        }
    }
} 







