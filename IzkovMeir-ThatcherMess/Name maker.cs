using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IzkovMeir_ThatcherMess
{
    public partial class Name_maker : Form
    {
        public Name_maker()
        {
            InitializeComponent();
            doneButton.Enabled = false;
            Globals.name = "";
        }
        int letterCount = 0;
        private void RestartPick()
        {
            Globals.name = "";
            letterCount = 0;
            
            letterCountButton.Enabled = true;
            letterCountButton.Visible = true;
            doneButton.Visible = true;
            letterCountButton.Text = "0";
            

            letterLabel.Visible = false;
            letterLabel.Enabled = false;
            chooseLetterButton.Visible = false;
            chooseLetterButton.Enabled = false;
            
            

        }
        private void letterCountButton_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Text = (int.Parse(bt.Text) + 1).ToString(); letterCount++;
            doneButton.Enabled = true;
            
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            letterCountButton.Enabled = false;
            letterCountButton.Visible = false;
            doneButton.Enabled = false;
            doneButton.Visible = false;

            letterLabel.Visible = true;
            letterLabel.Enabled = true;
            chooseLetterButton.Visible = true;
            chooseLetterButton.Enabled = true;
            presentLabel.Text = "Input your name man please input your name pleaseee bro";
            
        }

        private void letterLabel_Click(object sender, EventArgs e)
        {
            Label lb = (sender as Label);
            int asciiValue = Convert.ToInt32(lb.Text[0]);
            if (asciiValue == 122) lb.Text = "a";
            else lb.Text = Convert.ToChar(asciiValue + 1).ToString();

        }

        private void chooseLetterButton_Click(object sender, EventArgs e)
        {
            Globals.name+=letterLabel.Text;
            if (Globals.name.Length == letterCount)
            {
                if (
                    MessageBox.Show(text: Globals.name, caption: "Are u sure this is what u wanted", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question)
                    ==
                    DialogResult.No) {this.DialogResult = DialogResult.OK;}
                else
                {
                    MessageBox.Show
                    ("Lol u stoopid stoopid stoopy stupid shoulda pressed no","stoopy",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    RestartPick();
                }
            }
        }
    }
}
