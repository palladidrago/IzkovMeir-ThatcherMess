using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IzkovMeir_ThatcherMess
{
    public partial class IdForm : Form
    {
        public IdForm()
        {
            InitializeComponent();
        }
        int doneButtonCount = 0;
            
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = (sender as HScrollBar).Value.ToString();
            if ((sender as HScrollBar).Value>99) { (sender as HScrollBar).Value = 99; }
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = (sender as HScrollBar).Value.ToString();
            if ((sender as HScrollBar).Value > 99) { (sender as HScrollBar).Value = 99; }

        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = (sender as HScrollBar).Value.ToString();
            if ((sender as HScrollBar).Value > 99) { (sender as HScrollBar).Value = 99; }

        }
        private void hScrollBar4_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = (sender as HScrollBar).Value.ToString();
            if ((sender as HScrollBar).Value > 99) { (sender as HScrollBar).Value = 99; }

        }

        private void hScrollBar5_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = (sender as HScrollBar).Value.ToString();
            if ((sender as HScrollBar).Value > 9) { (sender as HScrollBar).Value = 9; }

        }

        private void pleaseLabel_Click(object sender, EventArgs e)
        {
            if (doneButtonCount == 12) { setGlobalIdFromLabels(); this.DialogResult = DialogResult.OK; }
        }
        private void setGlobalIdFromLabels()
        {
            Globals.id = $"{label1.Text}{label2.Text}{label3.Text}{label4.Text}{label5.Text}";
        }
        private void doneButton_Click(object sender, EventArgs e)
        {
            doneButtonCount++;
            if(doneButtonCount == 42) doneButtonCount = 0;
        }
    }
}
