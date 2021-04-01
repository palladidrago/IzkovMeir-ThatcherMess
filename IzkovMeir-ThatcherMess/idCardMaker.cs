using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace IzkovMeir_ThatcherMess
{
    public partial class idCardMaker : Form
    {
        public idCardMaker() 
        {
            InitializeComponent();



        }
        DateTime sep11 = new DateTime(2001,09,11);
        bool isDateTimeChangeSep11 = false;
        bool addedPic = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            (sender as DateTimePicker).Value = sep11; isDateTimeChangeSep11 = true;
            if (!isDateTimeChangeSep11)
            {
                colorDialog1.ShowDialog();
                this.BackColor = colorDialog1.Color;
                Random rnd = new Random();
                this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }
        }

        private void AskIfStupid() {
            if (MessageBox.Show(text: "Are u stupid?", caption: "Are u?", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                AskIfStupid();
            }
        }

        private void idButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IdForm().ShowDialog();
            if (Globals.id != "") {
                idButton.Visible = false; idButton.Enabled = false;
                this.Height -= idButton.Height;
            }
            idLabel.Text = Globals.id;
            this.Show();
            ShowDoneButton();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Name_maker().ShowDialog();
            if (Globals.name != "")
            {
                nameButton.Visible = false; nameButton.Enabled = false;
                this.Width -= nameButton.Width;
            }
            nameLabel.Text = Globals.name;
            this.Show();
            ShowDoneButton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AskIfStupid();
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pics (*.png)|*.png|pics (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            (sender as PictureBox).ImageLocation = openFileDialog1.FileName;
            addedPic = true;
            ShowDoneButton();
        }
        private void ShowDoneButton()
        {
            if (addedPic && Globals.name != "" && Globals.id != "")
            {
                saveToImgButton.Visible = true;
                saveToImgButton.Enabled = true;
            }
        }

        private void saveToImgButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "pics (*.png)|*.png|pics (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                bmp.Save(saveFileDialog1.FileName+".png", ImageFormat.Png); 
            }
        }
    }
}
