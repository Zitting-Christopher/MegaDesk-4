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
    public partial class DeskQuoteView : Form
    {
        public DeskQuoteView(string customerName, DateTime quoteDate, double width, double depth, int numOfDrawers, string DesktopMaterial, int rushOrderDays, int deskQuote)       
        {
            InitializeComponent();
            CustomerName.Text = customerName;
            OrderDate.Text = quoteDate.ToString("dd MMM yyyy");
            DeskWidth.Text = width.ToString() + " inches";
            DeskDepth.Text = depth.ToString() + " inches";
            Drawers.Text = numOfDrawers.ToString();
            Material.Text = DesktopMaterial;

            if (rushOrderDays == 0)
            {
                RushDays.Text = "None";
            }

            else
            {
                RushDays.Text = rushOrderDays.ToString() + " days";
            }
            QuoteTotal.Text = String.Format("{0:C}", deskQuote);
        }

        private void DeskOrderView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_vdq_close_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenu().Show();
        }
    }
}
