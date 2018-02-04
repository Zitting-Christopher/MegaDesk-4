using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ChrisZitting
{
    public class DeskQuote
    {
        private const double BASE_PRICE = 200;
        private const double COST_DRAWER = 50;
        private const double AREA_THRESHOLD = 1000; //Inches squared for the area of desk
        private const double EXCESS_SURF_AREA = 1; //Cost per square inch over threshold
        private const int RUSH1 = 3;
        private const int RUSH2 = 5;
        private const int RUSH3 = 7;
        private const int RUSH_THRESHOLD = 2000; //Inches squared area of desk

        //Desk quote variables
        private string CustomerName;
        private DateTime QuoteDate;
        private int RushDays;
        private Desk Desk = new Desk();
        private double QuoteAmount;

        //local variables
        private double SurfaceArea = 0;

        public DeskQuote(string customerName, int rushDays, double width, double depth, int numOfDrawers, string material)
        {
            CustomerName = customerName;
            RushDays = rushDays;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumDrawers = numOfDrawers;
            Desk.Material = material;

            //Calculate SurfaceArea
            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public double CalculateAreaCost()
        {
            if (Desk.Width * Desk.Depth > AREA_THRESHOLD)
            {
                return (Desk.Width * Desk.Depth - AREA_THRESHOLD) * EXCESS_SURF_AREA;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateDrawerCost()
        {
            return Desk.NumDrawers * COST_DRAWER;
        }

        public double SurfaceMaterialCost()
        {
            //Desk.Material result;
            //if Desk.Material.TryParse()
            //switch (result)
            return 1;

        }

        

        public double RushCost(int rush)
        {
            switch (rush)
            {
                case 0:
                    return 0;

                case 1:
                    return RUSH1;

                case 2:
                    return RUSH2;

                case 3:
                    return RUSH3;

                default:
                    return 0;
            }

        }



            public double CaculateQuoteTotal()
        {
            //Need to add Area cost, drawers, material, rush fee
            return BASE_PRICE + CalculateAreaCost() + CalculateDrawerCost() + SurfaceMaterialCost() + RushCost(RushDays);
        }
    }
}
