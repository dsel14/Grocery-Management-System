using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Security.AccessControl;

namespace JeighdyT_Assign2
{
    //1175 - 001
    //Jeighdy Tanamal, 300347511
    public partial class QuantitySoldLabelBut : Form
    {
        List<Info> InfoList = new List<Info>();
        public QuantitySoldLabelBut()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadAllUsersToListBox()
        {
            OutPutListBox.Items.Clear();
            OutPutListBox.Items.Add("ItemId\tItemName\tUnitPrice\tQtyMinForRestock\tInitialQty\tQtySold\tQtyRestocked");//header line added to the listbox
            foreach (Info user in InfoList)
            {
                OutPutListBox.Items.Add(user);
            }
        }

        private void LoadGroceryButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader myInputStream = new StreamReader("superstore.csv"))
                {
                    string eachLine;
                    if (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();//Reads first line
                        MessageBox.Show(eachLine);
                    }
                    while (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();
                        string[] eachUserFields = eachLine.Split(',');
                        string ItemCode = eachUserFields[0];
                        string ItemName = eachUserFields[1];
                        string UnitPrice = eachUserFields[2];
                        double.TryParse(UnitPrice, out double UnitP);
                        string QtyMinRestock = eachUserFields[3];
                        double.TryParse(QtyMinRestock, out double QtyMRestock);
                        string InitialQty = eachUserFields[4];
                        int.TryParse(InitialQty, out int InitialQ);
                        string QtySold = eachUserFields[5];
                        double.TryParse(QtySold, out double QtyS);
                        //double[] QtSold = new double[1];
                        //string[] QtyStrArray = QtySold.Split(',');
                        //for (int i = 0; i < QtyStrArray.Length; i++)
                        //{
                        //    double.TryParse(QtyStrArray[i], out QtSold[i]);
                        //}
                        ////double.TryParse(QtySold, out QtSold);

                        Info eachUser = new Info(ItemCode, ItemName, UnitP, QtyMRestock, InitialQ, QtyS, 0);
                        InfoList.Add(eachUser);

                        
                    }
                }
                LoadAllUsersToListBox();
                string time = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy hh:mm tt");
                //OutPutListBox.Items.Add(InfoList);
                //StatusLabel.Text = "Loaded " + InfoList.Count + " Users from the file";
                StatusLabel.Text = time;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void OutPutListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lbIndex = OutPutListBox.SelectedIndex;
            //QSoldTxtBox.Text = InfoList[lbIndex - 1].QtySold.ToString();
            //TxtBox.Text = string.Format("{0}", InfoList[lbIndex - 1].QtySold); 
        }

        private void DeleteGroItemButton_Click(object sender, EventArgs e)
        {
            int lbIndex = OutPutListBox.SelectedIndex;
            if(lbIndex < 0)
            {
                StatusLabel.Text = "Please select a Grocery Item to delete";
            }
            else if(InfoList.Count > 0)
            {
                StatusLabel.Text = "Deleted data for " + InfoList[lbIndex - 1].ItemName;

                InfoList.RemoveAt(lbIndex - 1);
                OutPutListBox.Items.RemoveAt(lbIndex);
                
            }

        }
        
        private void SaveGrocButton_Click(object sender, EventArgs e)
        {
            //USING STREAMWRITER
            //Get data from InfoList
            //using StreamWriter place data from InfoList to the file where StreamWriter is writing
            try
            {
                using(StreamWriter OutputStream = new StreamWriter("updatedgrocery.csv"))
                {
                    
                    string headerLine = "ItemCode,ItemName,UnitPrice,QtyMinForRestock,InitialQty,QtySold,QtyRestocked";
                    OutputStream.WriteLine(headerLine);
                    foreach(Info info in InfoList)
                    {
                        OutputStream.WriteLine(info.ItemCode + "," + info.ItemName + ","
                                               + info.UnitPrice + "," + info.QtyMinForRestock + "," +
                                               info.InitialQty + "," + info.QtySold + "," + info.QtyRestocked);
                    }

                    //Need to get the updated data
                    StatusLabel.Text = "Saved " +InfoList.Count +" records into the output inventory file";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateSoldButton_Click(object sender, EventArgs e)
        {
            if (OutPutListBox.SelectedIndex >= 0)
            {
                if (OutPutListBox.SelectedIndex == 0)
                {
                    StatusLabel.Text = "Please Select a grocery item to increment sold qty";
                }
                else if (!int.TryParse(QSoldTxtBox.Text, out int QSTxtBox) || QSTxtBox <= 0)
                {
                    StatusLabel.Text = "Please Input a number greater than 0";
                }
                else
                {

                    int lbIndex = OutPutListBox.SelectedIndex;



                    //QSoldTxtBox.Text = InfoList[lbIndex - 1].QtySold.ToString();

                    //StatusLabel.Text = "Sold Qty has been increased for the item with the item code " + InfoList[lbIndex - 1].ItemCode;
                    //double[] updatedQtySold = new double[1];
                    //double.TryParse(QSoldTxtBox.Text, out updatedQtySold[1];
                    //InfoList[lbIndex - 1].QtySold = updatedQtySold;
                    //QSoldTxtBox.Text = InfoList[lbIndex].QtySold[1].ToString();

                    //Parsed the text in the text box to be able to put in QtySold
                    double.TryParse(QSoldTxtBox.Text, out double Qsold);
                    //In the selected index the number in the textbox will be inputed to the QtySold of ith
                    InfoList[lbIndex - 1].QtySold = Qsold;
                    //Updates the information in ListBox
                    OutPutListBox.Items[lbIndex] = InfoList[lbIndex - 1];
                    //OutPutListBox.Items[lbIndex] = Updated;
                    StatusLabel.Text = "Sold Qty has been increased for the item code " + InfoList[lbIndex - 1].ItemCode + " To  " + InfoList[lbIndex - 1].QtySold;




                }
            }
        }

        private void UpdateRestockedButton_Click(object sender, EventArgs e)
        {
            if (OutPutListBox.SelectedIndex >= 0)
            {
                if (OutPutListBox.SelectedIndex == 0)
                {
                    StatusLabel.Text = "Please Select a grocery item to increment restocked qty";
                }
                else if (!int.TryParse(QRestockTxtBox.Text, out int QSTxtBox) || QSTxtBox <= 0)
                {
                    StatusLabel.Text = "Please Input a number greater than 0";
                }
                else
                {
                    int lbIndex = OutPutListBox.SelectedIndex;
                    //Parsing the text from the textbox
                    double.TryParse(QRestockTxtBox.Text, out double QR);
                    //putting the Parsed Text to the list for QtyRestocked
                    InfoList[lbIndex - 1].QtyRestocked = QR;
                    //Outputs updated Information to OutPutListBox
                    OutPutListBox.Items[lbIndex] = InfoList[lbIndex - 1];

                    StatusLabel.Text = "Increment Restocked Qty for item with item code " + InfoList[lbIndex - 1].ItemCode;
                }
            }
        }
        
        private void SortItemButton_Click(object sender, EventArgs e)
        {
            //Sort InfoList by descending order
            List<Info> SortedList = InfoList.OrderByDescending(sort => sort.totalsales).ToList();

            //SortedList = InfoList.OrderByDescending(sort => sort.totalsales).ToList();
            //Putting SortedList to renew Infolist
            InfoList = SortedList;

            //InfoList = SortedList;
            //LOAD ALL USERS
            LoadAllUsersToListBox();
            StatusLabel.Text = "Sorted Items in Descending order of Sales";
        }

        private void SaveSalesButton_Click(object sender, EventArgs e)
        {
            //Finds items in the list that has QtySold greater than 0
            //Also has been put to var for the purpose of freedom
            var info = from infos in InfoList where infos.QtySold > 0 select infos;

            try
            {
                using (StreamWriter writer = new StreamWriter("grocerysales.csv"))
                {
                    string headerLine = "ItemCode,ItemName,UnitPrice,QtySold,sales";
                    writer.WriteLine(headerLine);
                    foreach (Info infos in info)
                    {

                        writer.WriteLine(infos.ItemCode + "," + infos.ItemName + ","
                                                   + infos.UnitPrice + "," +
                                                   infos.QtySold + "," + infos.totalsales.ToString("C"));
                    }
                    StatusLabel.Text = "Saved " + info.Count() + " records into the output sales file";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //StatusLabel.Text = "Saved " + info.Count() + " records into the output sales file" ;
        }

        private void SaveRestockButton_Click(object sender, EventArgs e)
        {
            //Putting the LINQ to var info so that Im free to translate it to any dataType
            //Finds items in the list that has QtySold greater than 0
            var info = from infos in InfoList where infos.AvailableQty < infos.QtyMinForRestock select infos;

            try
            {
                using (StreamWriter writer = new StreamWriter("groceryrestock.csv"))
                {
                    string headerLine = "ItemCode,ItemName,AvailableQty,QtyMinForRestock";
                    writer.WriteLine(headerLine);
                    foreach (Info infos in info)
                    {

                        writer.WriteLine(infos.ItemCode + "," + infos.ItemName + ","
                                                   + infos.AvailableQty + "," +
                                                   infos.QtyMinForRestock);
                    }
                    StatusLabel.Text = "Saved " + info.Count() + " records into the restocks needed output file";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");

        }

        private void QSoldTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        //THANK YOU FOR THE GUIDANCE MS.PRIYA!
    }
}
