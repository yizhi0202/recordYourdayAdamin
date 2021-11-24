using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAdmin
{
    public partial class mainAdaminPage : Form
    {
        public mainAdaminPage()
        {
            InitializeComponent();
        }

        private void mainAdaminPage_Load(object sender, EventArgs e)
        {

        }

        private void goUserInfo_Click(object sender, EventArgs e)
        {
            Users UsersPage = new Users();
            this.Hide();
            UsersPage.ShowDialog();
            this.Dispose();
        }

        private void goSpotInfo_Click(object sender, EventArgs e)
        {
            scenicSpotPage spot = new scenicSpotPage();
            this.Hide();
            spot.ShowDialog();
            this.Dispose();
        }

        private void goPaceNoteInfo_Click(object sender, EventArgs e)
        {
            paceNotePage paceNote = new paceNotePage();
            this.Hide();
            paceNote.ShowDialog();
            this.Dispose();
        }

        private void logOff_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Dispose();
        }

        private void goCommentInfo_Click(object sender, EventArgs e)
        {
            commentPage comPage = new commentPage();
            this.Hide();
            comPage.ShowDialog();
            this.Dispose();
        }
    }
}
