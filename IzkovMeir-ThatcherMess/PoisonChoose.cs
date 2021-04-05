using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzkovMeir_ThatcherMess
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Mess_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IdCardMaker().ShowDialog();
            this.Close();  


            
        }

        private void MapZone_Click(object sender, EventArgs e)
        {

        }
    }
}
