
namespace IzkovMeir_ThatcherMess
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mess = new System.Windows.Forms.Button();
            this.MapZone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mess
            // 
            this.Mess.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Mess.Location = new System.Drawing.Point(13, 17);
            this.Mess.Name = "Mess";
            this.Mess.Size = new System.Drawing.Size(186, 107);
            this.Mess.TabIndex = 0;
            this.Mess.Text = "Mess";
            this.Mess.UseVisualStyleBackColor = true;
            this.Mess.Click += new System.EventHandler(this.Mess_Click);
            // 
            // MapZone
            // 
            this.MapZone.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapZone.Location = new System.Drawing.Point(205, 17);
            this.MapZone.Name = "MapZone";
            this.MapZone.Size = new System.Drawing.Size(237, 107);
            this.MapZone.TabIndex = 0;
            this.MapZone.Text = "MapZone";
            this.MapZone.UseVisualStyleBackColor = true;
            this.MapZone.Click += new System.EventHandler(this.MapZone_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(456, 145);
            this.Controls.Add(this.MapZone);
            this.Controls.Add(this.Mess);
            this.Name = "Start";
            this.Text = "Choose your poison";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mess;
        private System.Windows.Forms.Button MapZone;
    }
}

