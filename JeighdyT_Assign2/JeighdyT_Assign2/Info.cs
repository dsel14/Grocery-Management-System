using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeighdyT_Assign2
{
    internal class Info
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public double QtyMinForRestock { get; set; }
        public double InitialQty { get; set; }
        public double QtySold { get; set; }
        public double QtyRestocked { get; set; }
        public Info(string ItemC, string ItemN, double UnitP, double QtyMinFRestock, double InitialQ, double QSold, double QRestock)
        {
            ItemCode = ItemC;
            ItemName = ItemN;
            UnitPrice = UnitP;
            QtyMinForRestock = QtyMinFRestock;
            InitialQty = InitialQ;
            QtySold = QSold;
            QtyRestocked = QRestock;
            
        }
        public double AvailableQty { get
            {
                
                //double EQ = InitialQty + QtyRestocked;
                //double Available = EQ;
                //foreach (double amount in QtySold)
                //{
                //    EQ -= amount;
                //}

                return InitialQty - QtySold + QtyRestocked;
            } }

        public double totalsales
        {
            get
            {
                //double unitprice = 0; 
                //foreach (double amount in QtySold)
                //{
                //    unitprice *= amount;
                //}
                //double sum = unitprice;

                return QtySold * UnitPrice;
            }
        }


        public override string ToString()
        {
            string ItemC = string.Format("{0, -20}", ItemCode);
            string ItemN = string.Format("{0, 20}", ItemName);
            string UnitP = string.Format("{0, 20}", UnitPrice);
            string QMFR = string.Format("{0, 20}", QtyMinForRestock);
            string InitialQ = string.Format("{0, 20}", InitialQty);

            string QS = string.Format("{0, 20}", QtySold);
            string QR = string.Format("{0, 20}", QtyRestocked);
            string AvailableQ = string.Format("{0, 20}", AvailableQty);
            string sales = string.Format("{0, 20}", totalsales.ToString("C"));

            string OutputStr = ItemC + ItemN + UnitP +
                                QMFR + InitialQ + QS;

            //OutputStr += "\t";
            //for (int i = 0; i < QtySold.Length; i++)
            //{
            //    OutputStr += string.Format("{0, 20}", QtySold[i].ToString());
                
            //}
            

            OutputStr += QR += AvailableQ += sales;



            return OutputStr;
        }
    }
}
