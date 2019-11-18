using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_master_harman
{
    public partial class Form1 : Form
    {
        //instance object of the working class for calling the variable and methods 
        checkEntries instance_record = new checkEntries();

        int flag1 = 0, flag2 = 0, flag3 = 0,winnerFlag=0;
        int player1 = 0, player2 = 0,player3=0;

        public Form1()
        {
            InitializeComponent();
            player1 = instance_record.player1;
            player2 = instance_record.player2;
            player3 = instance_record.player3;

        }

        public int  check()
        {
            if (choosePlayer.Text.ToString().Equals("") || ChooseDog.Text.ToString().Equals("") || fillBet.Text.ToString().Equals(""))
            {
                return 0;
            }
            else {
                return 1;
            }
        }

        private void ChoosePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setBet_Click(object sender, EventArgs e)
        {
            //check all the entries if we select all the entries then the else block will be execute otherwise the if block will work 
            if (check() == 0)
            {
                MessageBox.Show("select  the all entries of the game the you can start the game ");
            }
            else {
                // if all the entries are true then the race will start 
                //after that check  the bet value and then the size 
                if (Convert.ToInt32(fillBet.Text.ToString()) <= 50)
                {
                    if (choosePlayer.SelectedIndex == 0 && Convert.ToInt32(fillBet.Text.ToString()) <= player1)
                    {
                        Player1.Text = fillBet.Text + " Dollar bet amount set on dog " + ChooseDog.SelectedItem.ToString() + " by Player 1";
                        StartRace.Visible = true;
                        flag1 = 1;
                    }
                    else if (choosePlayer.SelectedIndex == 1 && Convert.ToInt32(fillBet.Text.ToString()) <= player2)
                    {
                        Player2.Text = fillBet.Text + " Dollar bet amount set on dog " + ChooseDog.SelectedItem.ToString() + " by Player 2";
                        StartRace.Visible = true;
                        flag2 = 2;
                    }
                    else if (choosePlayer.SelectedIndex == 2 && Convert.ToInt32(fillBet.Text.ToString()) <= player3)
                    {
                        Player3.Text = fillBet.Text + " Dollar bet amount set on dog " + ChooseDog.SelectedItem.ToString() + " by Player 3"; ;
                        StartRace.Visible = true;
                        flag3 = 3;
                    }
                    else {
                        MessageBox.Show("check your account blance first ");
                    }

                    //set the text box empty 
                    fillBet.Text = "";
                    choosePlayer.Text = "";
                    ChooseDog.Text = "";
                }
                else {
                    MessageBox.Show("Bet Amount must be less then the 50 dollar account ");
                }
            }
               



            
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            runningModule.Start();
        }

        private void runningModule_Tick(object sender, EventArgs e)
        {

            if (dog1.Top <=580)
            {
                dog1.Top += instance_record.genStep();
            }
            else {
                runningModule.Stop();
                winnerFlag = 1;
                
                callAcount();
            }

            if (dog2.Top <= 580)
            {
                dog2.Top += instance_record.genStep();
            }
            else
            {
                runningModule.Stop();
                winnerFlag = 2;
                
                callAcount();
            }

            if (dog3.Top <= 580)
            {
                dog3.Top += instance_record.genStep();
            }
            else
            {
                runningModule.Stop();
                winnerFlag = 3;
                
                callAcount();
            }

            if (dog4.Top <= 580)
            {
                dog4.Top += instance_record.genStep();
            }
            else
            {
                runningModule.Stop();
                winnerFlag = 4;
                
                callAcount();
            }


        }

        public void callAcount() {
            MessageBox.Show("Winner Dog is  "+winnerFlag);
            // flag are used to pass the record 
            if (flag1==1) {
                String[] entry =Player1.Text.ToString().Split(' ');
                // 0 index for amount  7 index for dog
                player1 = instance_record.resetAccount1(Convert.ToInt32(entry[0]), Convert.ToInt32(entry[7]),winnerFlag,flag1);
                
               // MessageBox.Show("Player1 account balance is==" + player1);
                
            }
            if (flag2 == 2) {
                String[] entry = Player2.Text.ToString().Split(' ');
                // 0 index for amount  7 index for dog
                player2 = instance_record.resetAccount2(Convert.ToInt32(entry[0]), Convert.ToInt32(entry[7]), winnerFlag, flag2);
                 
                //MessageBox.Show("Player2 account balance is==" + player2);

            }

            if (flag3 == 3) {
                String[] entry = Player3.Text.ToString().Split(' ');
                // 0 index for amount  7 index for dog
                player3 = instance_record.resetAccount3(Convert.ToInt32(entry[0]), Convert.ToInt32(entry[7]), winnerFlag, flag3);
                 
               // MessageBox.Show("Player3 account balance is==" + player3);

            }

            flag1 = 0;
            flag2 = 0;
            flag3 = 0;
            winnerFlag = 0;
            Player1.Text = "Amount "+player1+" is left in the first Player Account";
            Player2.Text= "Amount " + player2 + " is left in the second Player Account"; ;
            Player3.Text= "Amount " + player3 + " is left in the third Player Account";

            dog1.Top = 295;
            dog2.Top = 295;
            dog3.Top = 295;
            dog4.Top = 295;
            StartRace.Visible = false;
            
        }
    }
}
