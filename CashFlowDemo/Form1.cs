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
using System.Threading;


namespace CashFlowDemo
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        Thread sh;
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        
        private void login_button_Click(object sender, EventArgs e)
        {
            string strID = login_id_lineedit.Text;
            string strPWD = login_pwd_lineedit.Text;

            if ((strID == "admin") && (strPWD == "admin"))
            {
                //MessageBox.Show("login okay");
                this.Close();

                sh = new Thread(opendashboardwindow);
                sh.SetApartmentState(ApartmentState.STA);
                sh.Start();

            }
            else
            {

                MessageBox.Show("Invalidate UserID or Passwrd!");
                login_id_lineedit.Text = "";
                login_pwd_lineedit.Text = "";
                
                return;
            }
        }

        private void opendashboardwindow()
        {
            Application.Run(new MainDashBoard());

            throw new NotImplementedException();
        }

        private void OnProcessLogin(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)

            {
                login_button.PerformClick();
            }
            
        }
    }
}
