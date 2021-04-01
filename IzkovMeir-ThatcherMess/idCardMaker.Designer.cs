
namespace IzkovMeir_ThatcherMess
{
    partial class idCardMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.birthdayPresentLabel = new System.Windows.Forms.Label();
            this.nameButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idButton = new System.Windows.Forms.Button();
            this.idPresentLabel = new System.Windows.Forms.Label();
            this.namePresentLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.saveToImgButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(422, 40);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // birthdayPresentLabel
            // 
            this.birthdayPresentLabel.AutoSize = true;
            this.birthdayPresentLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthdayPresentLabel.ForeColor = System.Drawing.Color.Lime;
            this.birthdayPresentLabel.Location = new System.Drawing.Point(0, 5);
            this.birthdayPresentLabel.Name = "birthdayPresentLabel";
            this.birthdayPresentLabel.Size = new System.Drawing.Size(138, 39);
            this.birthdayPresentLabel.TabIndex = 1;
            this.birthdayPresentLabel.Text = "Birthday:";
            // 
            // nameButton
            // 
            this.nameButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameButton.Location = new System.Drawing.Point(639, 11);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(139, 349);
            this.nameButton.TabIndex = 2;
            this.nameButton.Text = "Enter Ur Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameLabel.Location = new System.Drawing.Point(428, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(205, 42);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Ur name here";
            // 
            // idButton
            // 
            this.idButton.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idButton.Location = new System.Drawing.Point(0, 337);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(344, 78);
            this.idButton.TabIndex = 5;
            this.idButton.Text = "Enter your id";
            this.idButton.UseVisualStyleBackColor = true;
            this.idButton.Click += new System.EventHandler(this.idButton_Click);
            // 
            // idPresentLabel
            // 
            this.idPresentLabel.AutoSize = true;
            this.idPresentLabel.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idPresentLabel.Location = new System.Drawing.Point(0, 132);
            this.idPresentLabel.Name = "idPresentLabel";
            this.idPresentLabel.Size = new System.Drawing.Size(75, 52);
            this.idPresentLabel.TabIndex = 6;
            this.idPresentLabel.Text = "Id:";
            // 
            // namePresentLabel
            // 
            this.namePresentLabel.AutoSize = true;
            this.namePresentLabel.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namePresentLabel.Location = new System.Drawing.Point(428, 5);
            this.namePresentLabel.Name = "namePresentLabel";
            this.namePresentLabel.Size = new System.Drawing.Size(167, 67);
            this.namePresentLabel.TabIndex = 7;
            this.namePresentLabel.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.Color.Orange;
            this.idLabel.Location = new System.Drawing.Point(0, 240);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(271, 67);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "Ur Id here";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 18000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Image = global::IzkovMeir_ThatcherMess.Properties.Resources.photoadd;
            this.photoPictureBox.Location = new System.Drawing.Point(413, 117);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(207, 221);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 9;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // saveToImgButton
            // 
            this.saveToImgButton.Enabled = false;
            this.saveToImgButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveToImgButton.Location = new System.Drawing.Point(224, 132);
            this.saveToImgButton.Name = "saveToImgButton";
            this.saveToImgButton.Size = new System.Drawing.Size(157, 96);
            this.saveToImgButton.TabIndex = 10;
            this.saveToImgButton.Text = "Save to image";
            this.saveToImgButton.UseVisualStyleBackColor = true;
            this.saveToImgButton.Visible = false;
            this.saveToImgButton.Click += new System.EventHandler(this.saveToImgButton_Click);
            // 
            // idCardMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(780, 424);
            this.Controls.Add(this.saveToImgButton);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.namePresentLabel);
            this.Controls.Add(this.idPresentLabel);
            this.Controls.Add(this.idButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.birthdayPresentLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "idCardMaker";
            this.Text = "Shucks, what a mess this is";
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label birthdayPresentLabel;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button idButton;
        private System.Windows.Forms.Label idPresentLabel;
        private System.Windows.Forms.Label namePresentLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button saveToImgButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}