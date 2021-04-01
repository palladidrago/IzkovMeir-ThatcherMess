
namespace IzkovMeir_ThatcherMess
{
    partial class Name_maker
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
            this.letterCountButton = new System.Windows.Forms.Button();
            this.presentLabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.letterLabel = new System.Windows.Forms.Label();
            this.chooseLetterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // letterCountButton
            // 
            this.letterCountButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letterCountButton.Location = new System.Drawing.Point(21, 64);
            this.letterCountButton.Name = "letterCountButton";
            this.letterCountButton.Size = new System.Drawing.Size(482, 348);
            this.letterCountButton.TabIndex = 0;
            this.letterCountButton.Text = "0";
            this.letterCountButton.UseVisualStyleBackColor = true;
            this.letterCountButton.Click += new System.EventHandler(this.letterCountButton_Click);
            // 
            // presentLabel
            // 
            this.presentLabel.AutoSize = true;
            this.presentLabel.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.presentLabel.Location = new System.Drawing.Point(21, 9);
            this.presentLabel.Name = "presentLabel";
            this.presentLabel.Size = new System.Drawing.Size(748, 52);
            this.presentLabel.TabIndex = 1;
            this.presentLabel.Text = "How long is your name?(Click to increment)";
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doneButton.Location = new System.Drawing.Point(908, 55);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(286, 426);
            this.doneButton.TabIndex = 2;
            this.doneButton.Text = "I\'m done bro";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // letterLabel
            // 
            this.letterLabel.AutoSize = true;
            this.letterLabel.Enabled = false;
            this.letterLabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letterLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.letterLabel.Location = new System.Drawing.Point(262, 169);
            this.letterLabel.Name = "letterLabel";
            this.letterLabel.Size = new System.Drawing.Size(131, 167);
            this.letterLabel.TabIndex = 3;
            this.letterLabel.Text = "a";
            this.letterLabel.Visible = false;
            this.letterLabel.Click += new System.EventHandler(this.letterLabel_Click);
            // 
            // chooseLetterButton
            // 
            this.chooseLetterButton.Enabled = false;
            this.chooseLetterButton.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseLetterButton.Location = new System.Drawing.Point(851, 146);
            this.chooseLetterButton.Name = "chooseLetterButton";
            this.chooseLetterButton.Size = new System.Drawing.Size(343, 309);
            this.chooseLetterButton.TabIndex = 4;
            this.chooseLetterButton.Text = "Choose letter";
            this.chooseLetterButton.UseVisualStyleBackColor = true;
            this.chooseLetterButton.Visible = false;
            this.chooseLetterButton.Click += new System.EventHandler(this.chooseLetterButton_Click);
            // 
            // Name_maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IzkovMeir_ThatcherMess.Properties.Resources.morgx;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 522);
            this.Controls.Add(this.letterLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.presentLabel);
            this.Controls.Add(this.chooseLetterButton);
            this.Controls.Add(this.letterCountButton);
            this.Name = "Name_maker";
            this.Text = "Hol\' up... IS THAT MY BOY MORGAN???";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button letterCountButton;
        private System.Windows.Forms.Label presentLabel;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label letterLabel;
        private System.Windows.Forms.Button chooseLetterButton;
    }
}