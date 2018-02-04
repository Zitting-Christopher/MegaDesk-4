using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ChrisZitting
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void btn_vaq_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}
