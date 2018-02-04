using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ChrisZitting
{
    public partial class AddQuote : Form
    {

        string CustomerName = String.Empty;
        double DeskWidth = 0;
        double DeskDepth = 0;
        Drawers = int.Parse(dd_aq_drawers.SelectedItem.ToString());
        Material = dd_aq_surfMat.SelectedItem.ToString();
        int RushOrderDays = 0;
        double DeskQuoteTotal = 0;

        //var dict = new Dictionary<int, bool>();
        //dict.Add(1, true);
        //dict.Add(2, false);
            
        //List<SurfaceMaterial> sm = new List<SurfaceMaterial(dict.Keys);
        //foreach(SurfaceMaterial sm in sms)
        //    {
        //        Console.WriteLine(sm);
        //    }

        //sm.Add("Laminate");
        //sm.Add("Oak");
        //sm.Add("Rosewood");
        //sm.Add("Veneer");
        //sm.Add("Pine");

        //dd_aq_surfMat.DataSource = SurfaceMaterial;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void btn_aq_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void tb_aq_width_Validating(object sender, CancelEventArgs e)
        {
            if (tb_aq_width.Text.Length == 0)
                return;

            if (double.Parse(tb_aq_width.Text) < Desk.MIN_WIDTH || double.Parse(tb_aq_width.Text) > Desk.MAX_WIDTH)
            {
                tb_aq_width.BackColor = System.Drawing.Color.PaleVioletRed;
                tb_aq_width.Focus();
                MessageBox.Show("The value you entered is not within the allowed width, please enter a value between 24 and 96.");
                tb_aq_width.Text = "";
            }
            else
            {
                tb_aq_width.BackColor = System.Drawing.Color.Aquamarine;
            }
        }

        private void tb_aq_depth_Validating(object sender, CancelEventArgs e)
        {
            if (tb_aq_depth.Text.Length == 0)
                return;

            if (double.Parse(tb_aq_depth.Text) < Desk.MIN_DEPTH || double.Parse(tb_aq_depth.Text) > Desk.MAX_DEPTH)
            {
                tb_aq_depth.BackColor = System.Drawing.Color.PaleVioletRed;
                tb_aq_depth.Focus();
                MessageBox.Show("The value you entered is not within the allowed width, please enter a value between 12 and 48.");
                tb_aq_depth.Text = "";
            }
            else
            {
                tb_aq_depth.BackColor = System.Drawing.Color.Aquamarine;
            }
        }

        private void btn_aq_submit_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName = tb_aq_customer_name.Text;
                DeskWidth = double.Parse(tb_aq_width.Text);
                DeskDepth = double.Parse(tb_aq_depth.Text);
                Drawers = int.Parse(dd_aq_numDrawers.Text);
                Material = dd_aq_surfMat.Text;

                //get the expedite preference
                if (rb_aq_rush1.Checked)
                {
                    RushOrderDays = 3;
                }

                if (rb_aq_rush2.Checked)
                {
                    RushOrderDays = 5;
                }

                if (rb_aq_rush3.Checked)
                {
                    RushOrderDays = 7;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input methods");
                throw;
            }

            DeskQuote NewOrder = new DeskQuote(CustomerName, RushOrderDays, DeskWidth, DeskDepth, Drawers, Material);
            DeskQuoteTotal = NewOrder.CaculateQuoteTotal();

            //Give user a confirmation page
            var MainMenu = (MainMenu)Tag;
            DeskQuoteView newOrderView = new DeskQuoteView(CustomerName, DateTime.Now.Date, DeskWidth, DeskDepth, Drawers, Material, RushOrderDays, DeskQuoteTotal) { Tag = MainMenu };
            newOrderView.Show();
            this.Close();

            try
            {
                var record = CustomerName + ", " +  DateTime.Now.Date + ", " + DeskWidth + ", " + DeskDepth + ", " + Drawers + ", " + Material + ", " + RushOrderDays + ", " + DeskQuoteTotal;


                List<Quotes> deskQuotes = new List<Orders>();
                deskOrders.Add(newQuote);

                //File parameters
                string outputFile = @"quotes.txt";
                if(!File.Exists(outputFile))
                {
                    using (StreamWriter sw = File.CreateText("quotes.txt"))
                    {
                        sw.WriteLine("MegaDesk Desk Quotes");
                        sw.WriteLine("************************");

                    }
                }
                using (StreamWriter sw = File.AppendText("quotes.txt"))
                {
                    sw.WriteLine(record);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot ouput file");
            }

        }
    }
}
