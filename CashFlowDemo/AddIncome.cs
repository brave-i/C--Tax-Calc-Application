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




namespace CashFlowDemo
{
    public partial class AddIncome : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        

        string[] frequency_str = { "Weekly", "Monthly", "Yearly" };
        string DATABASE_NAME = "Data Source=abc.sqlite;Version=3;";
        string INCOMETB_NAME = "incoming_tax";

        public AddIncome()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            for (int i = 0; i < 3; i++)
                m_frequency.Items.Add(frequency_str[i]);
            m_frequency.SelectedIndex = 0;
        }

        public bool RunInsertQuery(string dbname, string tablename, string description, string datetime, string kindstr, string amount)
        {
            try
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection(dbname);
                string addsql = "insert into " + tablename + " (name, date, kind, amount) values (";
                m_dbConnection.Open();

                addsql = addsql + "'" + description + "'" + ", ";
                addsql = addsql + "'" + datetime + "'" + ", ";
                addsql = addsql + "'" + kindstr + "'" + ", ";
                addsql = addsql + "'" + amount + "'" + ")";

                SQLiteCommand command = new SQLiteCommand(m_dbConnection);

                command.CommandText = addsql;
                command.ExecuteNonQuery();

                m_dbConnection.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            

            return true;
        }

        private void m_confirm_Click(object sender, EventArgs e)
        {
            
            string description = m_description.Text;

            if (description == "")
            {
                MessageBox.Show("You must enter description!");
                m_description.Focus();
                return;
            }

            string datepicker = m_datepicker.Text;

            if (datepicker == "")
            {
                MessageBox.Show("You must enter description!");
                m_datepicker.Focus();
                return;
            }

            string frqstring = m_frequency.Text;

            if (frqstring == "")
            {
                MessageBox.Show("You must enter Frequency!");
                m_frequency.Focus();
                return;
            }

            string amount = m_amount.Text;

            try
            {
                int temp = Convert.ToInt32(amount);
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only");
                m_amount.Focus();
                return;
            }

            if (amount == "")
            {
                MessageBox.Show("You must enter Amount!");
                m_amount.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to Add these Information?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(Globals.form.getIncomeCountOfListView() == 5)
                {
                    MessageBox.Show("You have limited Adding Income Tax Data. Only Less than 5 available in this Demo Version!");
                    return;
                }

                if (RunInsertQuery(DATABASE_NAME, INCOMETB_NAME, description, datepicker, frqstring, amount) == true)
                {

                    MessageBox.Show("Added successfully your infomation!");
                    Globals.form.refreshIncome();
                }
                else
                {
                    MessageBox.Show("Sorry failed to save your information!");
                }
                this.Close();
            }

            else if (dialogResult == DialogResult.No)
            {

            }

            

        }

        private void m_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
