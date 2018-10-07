using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SQLite;
using CashFlowDemo;



namespace CashFlowDemo
{
    
    public partial class MainDashBoard : MaterialSkin.Controls.MaterialForm
    {
        
        public class Product
        {
            public string ProductID { get; set; }
            public string ProductName { get; set; }
            public string ProductDate { get; set; }
            public string ProductKind { get; set; }
            public string ProductPrice { get; set; }

        }

        private readonly MaterialSkinManager materialSkinManager;

        public string DATABASE_NAME = "Data Source=abc.sqlite;Version=3;";
        public string INCOMETAX_NAME = "incoming_tax";
        public string EXPENSESTAX_NAME = "expenses_tax";


        public MainDashBoard()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitializeComponent();

            InitIncomeTaxControls();
            InitExpensesTaxControls();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            //add combonox
            comboBox1.Items.Clear();
            for (int startYear = 2016; startYear < 2016 + 7; startYear++)
                comboBox1.Items.Add(startYear.ToString());
            comboBox1.SelectedIndex = 2;

            InitCashFlow();

        }
        public void InitCashFlow()
        {

            List<Product> rowIncomelist = GetProducts(DATABASE_NAME, INCOMETAX_NAME);//getIncomeList();
            List<Product> rowExpenlist = GetProducts(DATABASE_NAME, EXPENSESTAX_NAME);//getExpenList();

            int nIncProductCnt = rowIncomelist.Count;
            int nExpProudctCnt = rowExpenlist.Count;

            int nComboYear = Int32.Parse(comboBox1.Text.ToString());
            cashflow_listview.Items.Clear();

            for (int i = 0; i < nIncProductCnt + 2 + 2 + nExpProudctCnt; i++)
            {

                ListViewItem lvitem = new ListViewItem();
                Product p = new Product();


                if (i == 0)
                {//first row
                    lvitem.Text = "Cash on Hand ($)";

                    int index = 0;
                    while (index < 12)
                    {
                        lvitem.SubItems.Add("");
                        index++;
                    }
                }
                else if (i == 1)
                {//income row
                    lvitem.Text = "Income";

                    int index = 0;
                    while (index < 12)
                    {
                        lvitem.SubItems.Add("0");
                        index++;
                    }
                }
                else if (i == 2 + nIncProductCnt)//exp row
                {
                    lvitem.Text = "";

                    int index = 0;
                    while (index < 12)
                    {
                        lvitem.SubItems.Add("");
                        index++;
                    }
                }
                else if (i == 2 + nIncProductCnt + 1)//exp row
                {
                    lvitem.Text = "Expenses";

                    int index = 0;
                    while (index < 12)
                    {
                        lvitem.SubItems.Add("0");
                        index++;
                    }
                }

                else
                {
                    if (i > 2 + nIncProductCnt + 1)
                        p = rowExpenlist[i - 4 - nIncProductCnt];//change
                    else
                        p = rowIncomelist[i - 2];//change


                    lvitem.Text = p.ProductName;

                    string[] datestr = p.ProductDate.Split(',');
                    int nStartMonth = NotifyMonth(datestr[1]);
                    int nStartYear = Int32.Parse(datestr[2]);
                    int nStartDate = NotifyDate(datestr[1]);
                    int amount = Int32.Parse(p.ProductPrice);
                    int nColumn = 0;

                    switch (p.ProductKind)
                    {
                        case "Yearly":
                            while (nColumn < 12)
                            {
                                if (nComboYear >= nStartYear)
                                {
                                    if (nColumn == nStartMonth - 1)
                                        lvitem.SubItems.Add(amount.ToString());
                                    else
                                        lvitem.SubItems.Add("0");
                                }

                                else
                                    lvitem.SubItems.Add("0");

                                nColumn++;
                            }

                            break;

                        case "Monthly":
                            while (nColumn < 12)
                            {
                                if (nComboYear >= nStartYear)
                                {
                                    if (nComboYear == nStartYear)
                                    {
                                        if (nColumn + 1 >= nStartMonth)
                                            lvitem.SubItems.Add(amount.ToString());
                                        else
                                            lvitem.SubItems.Add("0");
                                    }
                                    else
                                        lvitem.SubItems.Add(amount.ToString());
                                }

                                else
                                    lvitem.SubItems.Add("0");

                                nColumn++;
                            }

                            break;

                        case "Weekly":
                            amount = amount * 4;
                            while (nColumn < 12)
                            {
                                if (nComboYear >= nStartYear)
                                {
                                    if (nComboYear == nStartYear)
                                    {
                                        if (nColumn + 1 >= nStartMonth)
                                            lvitem.SubItems.Add(amount.ToString());
                                        else
                                            lvitem.SubItems.Add("0");
                                    }
                                    else
                                        lvitem.SubItems.Add(amount.ToString());
                                }

                                else
                                    lvitem.SubItems.Add("0");

                                nColumn++;
                            }

                            break;
                    }
                }

                cashflow_listview.Items.Add(lvitem);

            }


            // check sum income

            for (int k = 1; k < 12 + 1; k++)
            {
                int check_amount = 0;
                for (int j = 2; j < nIncProductCnt + 2; j++)
                {
                    check_amount += Int32.Parse(cashflow_listview.Items[j].SubItems[k].Text);
                }
                cashflow_listview.Items[1].SubItems[k].Text = check_amount.ToString();
            }

            // check sum income

            for (int k = 1; k < 12 + 1; k++)
            {
                int check_amount = 0;
                for (int j = 2 + nIncProductCnt + 2; j < 2 + nIncProductCnt + 2 + nExpProudctCnt; j++)
                {
                    check_amount += Int32.Parse(cashflow_listview.Items[j].SubItems[k].Text);
                }
                cashflow_listview.Items[1 + nIncProductCnt + 2].SubItems[k].Text = check_amount.ToString();
            }

            //CashOnHandAmountofMonth, check sum cashonHand

            for (int k = 1; k < 12 + 1; k++)
            {
                int checkin_amount = 0;
                int checkout_amount = 0;
                int check_amount = 0;

                int nCurrentYear = nComboYear;
                int nCurrentMonth = k;

                //List<Product> list1 = GetProducts(DATABASE_NAME, INCOMETAX_NAME);

                foreach (Product p in rowIncomelist)
                {
                    int nStartYear = Int32.Parse(p.ProductDate.Split(',')[2].ToString());
                    int nStartMonth = NotifyMonth(p.ProductDate.Split(',')[1].ToString());
                    int Amount = Int32.Parse(p.ProductPrice);
                    string Frequency = p.ProductKind;

                    checkin_amount += CashOnHandAmountofMonth(nStartYear, nStartMonth, nCurrentYear, nCurrentMonth, Amount, Frequency);
                }

                //List<Product> list2 = GetProducts(DATABASE_NAME, EXPENSESTAX_NAME);

                foreach (Product p in rowExpenlist)
                {
                    int nStartYear = Int32.Parse(p.ProductDate.Split(',')[2].ToString());
                    int nStartMonth = NotifyMonth(p.ProductDate.Split(',')[1].ToString());
                    int Amount = Int32.Parse(p.ProductPrice);
                    string Frequency = p.ProductKind;

                    checkout_amount += CashOnHandAmountofMonth(nStartYear, nStartMonth, nCurrentYear, nCurrentMonth, Amount, Frequency);
                }

                check_amount = checkin_amount - checkout_amount;
                cashflow_listview.Items[0].SubItems[k].Text = check_amount.ToString();
            }

        }

        public int getIncomeCountOfListView()
        {
            return income_listview.Items.Count;
        }

        public int getExpenCountOfListView()
        {
            return expenses_listview.Items.Count;
        }
        public void  refreshIncome()
        {
            InitIncomeTaxControls();
        }
        public void refreshExpenses()
        {
            InitExpensesTaxControls();
        }
        public void InitIncomeTaxControls()
        {
            //string dbname = "Data Source=D:/abc.sqlite;Version=3;";
            //string tablename = "incoming_tax";

            income_listview.Items.Clear();
            List<Product> list = GetProducts(DATABASE_NAME, INCOMETAX_NAME);//Retrieve data from products table

            foreach (Product p in list)
            {
                ListViewItem item = new ListViewItem(p.ProductID);//Add data to Material ListView

                item.SubItems.Add(p.ProductName);
                item.SubItems.Add(p.ProductDate);
                item.SubItems.Add(p.ProductKind);
                item.SubItems.Add(p.ProductPrice);

                income_listview.Items.Add(item);
            }

        }

        public void InitExpensesTaxControls()
        {
            //string dbname = "Data Source=D:/abc.sqlite;Version=3;";
            //string tablename = "incoming_tax";

            expenses_listview.Items.Clear();
            List<Product> list = GetProducts(DATABASE_NAME, EXPENSESTAX_NAME);//Retrieve data from products table

            foreach (Product p in list)
            {
                ListViewItem item = new ListViewItem(p.ProductID);//Add data to Material ListView

                item.SubItems.Add(p.ProductName);
                item.SubItems.Add(p.ProductDate);
                item.SubItems.Add(p.ProductKind);
                item.SubItems.Add(p.ProductPrice);

                expenses_listview.Items.Add(item);
            }

        }

        public bool DeleteProduct(string dbname, string tablename, string description)
        {
            
            try
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection(dbname);
                m_dbConnection.Open();

                //DELETE FROM incoming_tax WHERE name='aaa'

                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                string sql = "DELETE FROM " + tablename + " WHERE name='" + description + "'";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                m_dbConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public List<Product> GetProducts(string dbname, string tablename)
        {
            List<Product> temp = new List<Product>();

            SQLiteConnection m_dbConnection = new SQLiteConnection(dbname);
            m_dbConnection.Open();

            SQLiteCommand command = new SQLiteCommand(m_dbConnection);
            string sql = "SELECT * FROM " + tablename;
            command.CommandText = sql;
            command.ExecuteNonQuery();

            SQLiteDataReader rdr = command.ExecuteReader();

            int index = 0;

            while (rdr.Read())
            {
                
                index++;
                /*Console.WriteLine(rdr["name"]);
                Console.WriteLine(rdr["date"]);
                Console.WriteLine(rdr["kind"]);
                Console.WriteLine(rdr["amount"]);*/
                Product p = new Product();
                p.ProductID = index.ToString();
                p.ProductName = rdr["name"].ToString();
                p.ProductDate = rdr["date"].ToString();
                p.ProductKind = rdr["kind"].ToString();
                p.ProductPrice = rdr["amount"].ToString();

                temp.Add(p);

            }
            rdr.Close();
            m_dbConnection.Close();

            return temp;
        }


        public void addLineControls(string description, string timepicker, string combobox, string amount)
        {
            int xstartpos = 60;
            int ystartpos = 100;

            int nHeightSpace = 80;


            for (int i = 0; i < 5; i++)
            {

                //draw label for tax info.
                Label label = new MaterialSkin.Controls.MaterialLabel();
                label.Text = description;//"Salary";
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                label.Location = new System.Drawing.Point(xstartpos, ystartpos + i * nHeightSpace);
                m_incometax.Controls.Add(label);

                //draw datetime picker.
                DateTimePicker dpicker = new DateTimePicker();
                dpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                dpicker.Size = new System.Drawing.Size(270, 30);
                dpicker.Location = new System.Drawing.Point(xstartpos + 310, ystartpos + i * nHeightSpace);
                m_incometax.Controls.Add(dpicker);

                //draw combobox.
                ComboBox comboitem = new ComboBox();
                comboitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                comboitem.Size = new System.Drawing.Size(100, 28);
                comboitem.Location = new System.Drawing.Point(xstartpos + 700, ystartpos + i * nHeightSpace);
                m_incometax.Controls.Add(comboitem);

                //draw label for tax info.
                Label label2 = new MaterialSkin.Controls.MaterialLabel();
                label2.Text = "Salary";
                label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                label2.Location = new System.Drawing.Point(xstartpos + 900, ystartpos + i * nHeightSpace);
                m_incometax.Controls.Add(label2);
            }
        }
        
        private void seedListViewIncome()
        {
            
            
            //Define
            var data = new[]
            {
                new []{"Cash on Hand", "1000$", "800", "400","1000","1000","1000","-5000$","1000","1000","1000","1000", "1000"},

                new []{"Income", "1000", "1000", "1000","1000","1000","1000","1000","1000","1000","1000","1000", "1000"},
                new []{"Salary", "500", "500", "500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500"},
                new []{"Bonus", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50"},
                new []{"Freelance", "375", "0.0", "0.0","375","375","375","375","375","375","375","375","375"},
                new []{"Others", "408", "3.2","375", "375", "375", "375", "375", "375", "375", "375", "375", "5" },
                new []{""},
                new []{"Expenses", "800", "800", "800","800","800","800","800","800","800","800","800", "800"},
                new []{"Car", "500", "500", "500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500" ,"500"},
                new []{"CreditCard Payment", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50"},
                new []{"Food", "375", "0.0", "0.0","375","375","375","375","375","375","375","375","375"},
                new []{"Rent,Utilities", "408", "3.2","375", "375", "375", "375", "375", "375", "375", "375", "375", "5" },
                //new []{"Grocerles", "408", "3.2","375", "375", "375", "375", "375", "375", "375", "375", "375", "5" },
                new []{"Others", "408", "3.2","375", "375", "375", "375", "375", "375", "375", "375", "375", "5" }
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                
                cashflow_listview.Items.Add(item);
                
            }
            
            

        }

        public int NotifyDate(string str)
        {
            string date = null;
            date = str.Split(' ')[2].ToString();
            return Int32.Parse(date);
        }
        public int NotifyMonth(string str)
        {
            int month = 0;
            string temp = str.Split(' ')[1].ToString();
            switch (temp)
            {
                case "January":
                    month = 1;
                    break;
                case "February":
                    month = 2;
                    break;
                case "March":
                    month = 3;
                    break;
                case "April":
                    month = 4;
                    break;
                case "May":
                    month = 5;
                    break;
                case "June":
                    month = 6;
                    break;
                case "July":
                    month = 7;
                    break;
                case "August":
                    month = 8;
                    break;
                case "September":
                    month = 9;
                    break;
                case "October":
                    month = 10;
                    break;
                case "November":
                    month = 11;
                    break;
                case "December":
                    month = 12;
                    break;


            }
            return month;
        }

        public int CashOnHandAmountofMonth(int startYear, int startMonth, int currentYear, int currentMonth, int Amount, string frquency)
        {
            int cash_amount = 0;
            int lengthMonth = (currentYear - startYear) * 12 + (currentMonth - startMonth)+1;
            int lengthYear = (int)(lengthMonth / 12);

            switch (frquency)
            {
                case "Yearly":

                    if(lengthYear > 0)
                        cash_amount = Amount * lengthYear;

                    break;

                case "Monthly":

                    if(lengthMonth > 0)
                        cash_amount = Amount * lengthMonth;

                    break;

                case "Weekly":

                    if (lengthMonth > 0)
                        cash_amount = Amount * lengthMonth *4;
                    
                    break;
                    
            }

            return cash_amount;
        }

        public void Fill_IncomeField()
        {   
            int nComboYear = Int32.Parse(comboBox1.Text.ToString());
            cashflow_listview.Items.Clear();
            //header
            
            List<Product> rowIncomelist = getIncomeList();
            List<Product> rowExpenlist = getExpenList();

            int nIncProductCnt = rowIncomelist.Count;
            int nExpProudctCnt = rowExpenlist.Count;

            for (int i = 0; i < nIncProductCnt + 2 + 2 + nExpProudctCnt; i++){

                ListViewItem lvitem = new ListViewItem();
                Product p = new Product();

               
                if (i==0){//first row
                    lvitem.Text = "Cash on Hand ($)";

                    int index = 0;
                    while (index < 12)
                    {
                        lvitem.SubItems.Add("");
                        index++;
                    }
                }
                else if(i == 1){//income row
                    lvitem.Text = "Income";

                    int index = 0;
                    while(index < 12)
                    {
                        lvitem.SubItems.Add("0");
                        index++;
                    }
                }
                else if (i == 2 + nIncProductCnt)//exp row
                {
                    lvitem.Text = "";

                    int index = 0;
                    while (index < 12)
                    {
                        lvitem.SubItems.Add("");
                        index++;
                    }
                }
                else if (i == 2+ nIncProductCnt +1)//exp row
                {
                    lvitem.Text = "Expenses";

                    int index = 0;
                    while (index < 12)
                    {
                        lvitem.SubItems.Add("0");
                        index++;
                    }
                }

                else
                {
                    if(i > 2 + nIncProductCnt + 1)
                        p = rowExpenlist[i - 4 - nIncProductCnt];//change
                    else
                        p = rowIncomelist[i - 2];//change


                    lvitem.Text = p.ProductName;

                    string[] datestr = p.ProductDate.Split(',');
                    int nStartMonth = NotifyMonth(datestr[1]);
                    int nStartYear = Int32.Parse(datestr[2]);
                    int nStartDate = NotifyDate(datestr[1]);
                    int amount = Int32.Parse(p.ProductPrice);
                    int nColumn = 0;

                    switch (p.ProductKind)
                    {
                        case "Yearly":
                            while(nColumn < 12)
                            {
                                if (nComboYear >=nStartYear)
                                {
                                    if (nColumn == nStartMonth - 1)
                                        lvitem.SubItems.Add(amount.ToString());
                                    else
                                        lvitem.SubItems.Add("0");
                                }
                                    
                                else
                                    lvitem.SubItems.Add("0");

                                nColumn++;
                            }
                            
                            break;

                        case "Monthly":
                            while (nColumn < 12)
                            {
                                if (nComboYear>=nStartYear)
                                {
                                    if(nComboYear == nStartYear)
                                    {
                                        if (nColumn + 1 >= nStartMonth)
                                            lvitem.SubItems.Add(amount.ToString());
                                        else
                                            lvitem.SubItems.Add("0");
                                    }
                                    else
                                        lvitem.SubItems.Add(amount.ToString());
                                }
                                else
                                    lvitem.SubItems.Add("0");

                                nColumn++;
                            }

                            break;

                        case "Weekly":
                            amount = amount * 4;
                            while (nColumn < 12)
                            {
                                if (nComboYear >= nStartYear)
                                {
                                    if (nComboYear == nStartYear)
                                    {
                                        if (nColumn + 1 >= nStartMonth)
                                            lvitem.SubItems.Add(amount.ToString());
                                        else
                                            lvitem.SubItems.Add("0");
                                    }
                                    else
                                        lvitem.SubItems.Add(amount.ToString());
                                }

                                else
                                    lvitem.SubItems.Add("0");

                                nColumn++;
                            }

                            break;
                    }
                }

                cashflow_listview.Items.Add(lvitem);

            }


            // check sum income
            
            for (int k = 1; k < 12 + 1; k++)
            {
                int check_amount = 0;
                for (int j = 2; j < nIncProductCnt + 2; j++) 
                {
                    check_amount += Int32.Parse(cashflow_listview.Items[j].SubItems[k].Text);
                }
                cashflow_listview.Items[1].SubItems[k].Text = check_amount.ToString();
            }

            // check sum income

            for (int k = 1; k < 12 + 1; k++)
            {
                int check_amount = 0;
                for (int j = 2 + nIncProductCnt + 2; j < 2 + nIncProductCnt + 2 + nExpProudctCnt; j++)
                {
                    check_amount += Int32.Parse(cashflow_listview.Items[j].SubItems[k].Text);
                }
                cashflow_listview.Items[1+nIncProductCnt+2].SubItems[k].Text = check_amount.ToString();
            }
            //CashOnHandAmountofMonth, check sum cashonHand

            for (int k = 1; k < 12 + 1; k++)
            {
                int checkin_amount = 0;
                int checkout_amount = 0;
                int check_amount = 0;

                int nCurrentYear = nComboYear;
                int nCurrentMonth = k;

                //List<Product> list1 = GetProducts(DATABASE_NAME, INCOMETAX_NAME);

                foreach (Product p in rowIncomelist)
                {
                    int nStartYear = Int32.Parse(p.ProductDate.Split(',')[2].ToString());
                    int nStartMonth = NotifyMonth(p.ProductDate.Split(',')[1].ToString());
                    int Amount = Int32.Parse(p.ProductPrice);
                    string Frequency = p.ProductKind;

                    checkin_amount += CashOnHandAmountofMonth(nStartYear, nStartMonth, nCurrentYear, nCurrentMonth, Amount, Frequency);
                }

                //List<Product> list2 = GetProducts(DATABASE_NAME, EXPENSESTAX_NAME);

                foreach (Product p in rowExpenlist)
                {
                    int nStartYear = Int32.Parse(p.ProductDate.Split(',')[2].ToString());
                    int nStartMonth = NotifyMonth(p.ProductDate.Split(',')[1].ToString());
                    int Amount = Int32.Parse(p.ProductPrice);
                    string Frequency = p.ProductKind;

                    checkout_amount += CashOnHandAmountofMonth(nStartYear, nStartMonth, nCurrentYear, nCurrentMonth, Amount, Frequency);
                }

                check_amount = checkin_amount - checkout_amount;
                cashflow_listview.Items[0].SubItems[k].Text = check_amount.ToString();
            }

        }

        public void checksum_incomeLine()
        {

        }

        public void Fill_ExpensesField()
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        public void dash_changetheme_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private int colorSchemeIndex;
        private void dash_changecolor_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2) colorSchemeIndex = 0;

            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    //materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
            }
        }

        private void m_incometax_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            AddIncome addform= new AddIncome();
            addform.Show();
            
        }

        private void MainDashBoard_Load(object sender, EventArgs e)
        {
            Globals.form = this;
        }

        public List<Product> getIncomeList()
        {
            List<Product> list = new List<Product>();
            int nRowCnt = income_listview.Items.Count;

            for(int i = 0; i < nRowCnt; i++)
            {
                Product p = new Product();
                p.ProductID = (i + 1).ToString();

                var productobj = income_listview.Items[i];
                p.ProductName = productobj.SubItems[1].Text.ToString();
                p.ProductDate = productobj.SubItems[2].Text.ToString();
                p.ProductKind = productobj.SubItems[3].Text.ToString();
                p.ProductPrice = productobj.SubItems[4].Text.ToString();

                list.Add(p);

            }

            return list;
        }

        public List<Product> getExpenList()
        {
            List<Product> list = new List<Product>();
            int nRowCnt = expenses_listview.Items.Count;

            for (int i = 0; i < nRowCnt; i++)
            {
                Product p = new Product();
                p.ProductID = (i + 1).ToString();

                var productobj = expenses_listview.Items[i];
                p.ProductName = productobj.SubItems[1].Text.ToString();
                p.ProductDate = productobj.SubItems[2].Text.ToString();
                p.ProductKind = productobj.SubItems[3].Text.ToString();
                p.ProductPrice = productobj.SubItems[4].Text.ToString();

                list.Add(p);

            }

            return list;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            

            if (income_listview.FocusedItem == null)
            {
                MessageBox.Show("There is no selected Row Information. Please select one!", "Message", MessageBoxButtons.OK);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to delete this row?", "Message", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                
                //[1];
                int x = income_listview.FocusedItem.Index;
                string description = income_listview.Items[x].SubItems[1].Text.ToString();


                //MessageBox.Show(description);

                //string dbname = "Data Source=D:/abc.sqlite;Version=3;";
                //string tablename = "incoming_tax";

                DeleteProduct(DATABASE_NAME, INCOMETAX_NAME, description);
                refreshIncome();


            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void OnExpenses_AddButton(object sender, EventArgs e)
        {
            AddExpenses addform = new AddExpenses();
            addform.Show();
        }

        private void OnExpenses_DelButton(object sender, EventArgs e)
        {
            if (expenses_listview.FocusedItem == null)
            {
                MessageBox.Show("There is no selected Row Information. Please select one!", "Message", MessageBoxButtons.OK);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to delete this row?", "Message", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                
                //[1];
                int x = expenses_listview.FocusedItem.Index;
                string description = expenses_listview.Items[x].SubItems[1].Text.ToString();


                //MessageBox.Show(description);

                //string dbname = "Data Source=D:/abc.sqlite;Version=3;";
                //string tablename = "incoming_tax";

                DeleteProduct(DATABASE_NAME, EXPENSESTAX_NAME, description);
                refreshExpenses();


            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        

        private void Tab_IndexChanged(object sender, EventArgs e)
        {

            if (materialTabControl1.SelectedTab == materialTabControl1.Controls[0])
            {

                //MessageBox.Show("1");
                Fill_IncomeField();
            }

            if (materialTabControl1.SelectedTab == materialTabControl1.Controls[1])
            {
                //MessageBox.Show("2");

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.Controls[2])
            {

                //MessageBox.Show("3");
            }

            
        }

        private void OnSelChangeComboYear(object sender, EventArgs e)
        {
            Fill_IncomeField();
        }
    }
}

class Globals
{
    public static MainDashBoard form;
}
