namespace CashFlowDemo
{
    partial class MainDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public static bool brefresh2 = false;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }
        public void refereshList()
        {
            income_listview.Items.Clear();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.dash_cashflow = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cashflow_listview = new MaterialSkin.Controls.MaterialListView();
            this.listview_field_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_field_12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_incometax = new System.Windows.Forms.TabPage();
            this.income_listview = new MaterialSkin.Controls.MaterialListView();
            this.m_column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_column4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_column5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_deletebutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.expenses_listview = new MaterialSkin.Controls.MaterialListView();
            this.expen_column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expen_column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expen_column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expen_column4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expen_column5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenses_DelBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.expenses_AddBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.dash_changetheme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dash_changecolor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.dash_cashflow.SuspendLayout();
            this.m_incometax.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.dash_cashflow);
            this.materialTabControl1.Controls.Add(this.m_incometax);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 138);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1354, 616);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.Tab_IndexChanged);
            // 
            // dash_cashflow
            // 
            this.dash_cashflow.Controls.Add(this.comboBox1);
            this.dash_cashflow.Controls.Add(this.cashflow_listview);
            this.dash_cashflow.Location = new System.Drawing.Point(4, 22);
            this.dash_cashflow.Name = "dash_cashflow";
            this.dash_cashflow.Padding = new System.Windows.Forms.Padding(3);
            this.dash_cashflow.Size = new System.Drawing.Size(1346, 590);
            this.dash_cashflow.TabIndex = 0;
            this.dash_cashflow.Text = "Cash Flow";
            this.dash_cashflow.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.OnSelChangeComboYear);
            // 
            // cashflow_listview
            // 
            this.cashflow_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashflow_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cashflow_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listview_field_0,
            this.listview_field_1,
            this.listview_field_2,
            this.listview_field_3,
            this.listview_field_4,
            this.listview_field_5,
            this.listview_field_6,
            this.listview_field_7,
            this.listview_field_8,
            this.listview_field_9,
            this.listview_field_10,
            this.listview_field_11,
            this.listview_field_12});
            this.cashflow_listview.Depth = 0;
            this.cashflow_listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cashflow_listview.FullRowSelect = true;
            this.cashflow_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.cashflow_listview.Location = new System.Drawing.Point(6, 17);
            this.cashflow_listview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cashflow_listview.MouseState = MaterialSkin.MouseState.OUT;
            this.cashflow_listview.Name = "cashflow_listview";
            this.cashflow_listview.OwnerDraw = true;
            this.cashflow_listview.Size = new System.Drawing.Size(1335, 576);
            this.cashflow_listview.TabIndex = 0;
            this.cashflow_listview.UseCompatibleStateImageBehavior = false;
            this.cashflow_listview.View = System.Windows.Forms.View.Details;
            // 
            // listview_field_0
            // 
            this.listview_field_0.Text = "Year";
            this.listview_field_0.Width = 200;
            // 
            // listview_field_1
            // 
            this.listview_field_1.Text = "Jan";
            this.listview_field_1.Width = 95;
            // 
            // listview_field_2
            // 
            this.listview_field_2.Text = "Feb";
            this.listview_field_2.Width = 95;
            // 
            // listview_field_3
            // 
            this.listview_field_3.Text = "Mar";
            this.listview_field_3.Width = 95;
            // 
            // listview_field_4
            // 
            this.listview_field_4.Text = "Apr";
            this.listview_field_4.Width = 95;
            // 
            // listview_field_5
            // 
            this.listview_field_5.Text = "May";
            this.listview_field_5.Width = 95;
            // 
            // listview_field_6
            // 
            this.listview_field_6.Text = "Jun";
            this.listview_field_6.Width = 95;
            // 
            // listview_field_7
            // 
            this.listview_field_7.Text = "Jul";
            this.listview_field_7.Width = 95;
            // 
            // listview_field_8
            // 
            this.listview_field_8.Text = "Aug";
            this.listview_field_8.Width = 95;
            // 
            // listview_field_9
            // 
            this.listview_field_9.Text = "Sep";
            this.listview_field_9.Width = 95;
            // 
            // listview_field_10
            // 
            this.listview_field_10.Text = "Oct";
            this.listview_field_10.Width = 95;
            // 
            // listview_field_11
            // 
            this.listview_field_11.Text = "Nov";
            this.listview_field_11.Width = 95;
            // 
            // listview_field_12
            // 
            this.listview_field_12.Text = "Dec";
            this.listview_field_12.Width = 98;
            // 
            // m_incometax
            // 
            this.m_incometax.Controls.Add(this.income_listview);
            this.m_incometax.Controls.Add(this.m_deletebutton);
            this.m_incometax.Controls.Add(this.materialRaisedButton1);
            this.m_incometax.Location = new System.Drawing.Point(4, 22);
            this.m_incometax.Name = "m_incometax";
            this.m_incometax.Padding = new System.Windows.Forms.Padding(3);
            this.m_incometax.Size = new System.Drawing.Size(1346, 590);
            this.m_incometax.TabIndex = 1;
            this.m_incometax.Text = "Income Tax";
            this.m_incometax.UseVisualStyleBackColor = true;
            this.m_incometax.Click += new System.EventHandler(this.m_incometax_Click);
            // 
            // income_listview
            // 
            this.income_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.income_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_column1,
            this.m_column2,
            this.m_column3,
            this.m_column4,
            this.m_column5});
            this.income_listview.Depth = 0;
            this.income_listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.income_listview.FullRowSelect = true;
            this.income_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.income_listview.Location = new System.Drawing.Point(82, 82);
            this.income_listview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.income_listview.MouseState = MaterialSkin.MouseState.OUT;
            this.income_listview.Name = "income_listview";
            this.income_listview.OwnerDraw = true;
            this.income_listview.Size = new System.Drawing.Size(1150, 453);
            this.income_listview.TabIndex = 1;
            this.income_listview.UseCompatibleStateImageBehavior = false;
            this.income_listview.View = System.Windows.Forms.View.Details;
            // 
            // m_column1
            // 
            this.m_column1.Text = "NO";
            this.m_column1.Width = 70;
            // 
            // m_column2
            // 
            this.m_column2.Text = "Description";
            this.m_column2.Width = 400;
            // 
            // m_column3
            // 
            this.m_column3.Text = "Starting Date";
            this.m_column3.Width = 300;
            // 
            // m_column4
            // 
            this.m_column4.Text = "Frequency";
            this.m_column4.Width = 200;
            // 
            // m_column5
            // 
            this.m_column5.Text = "Amount";
            this.m_column5.Width = 180;
            // 
            // m_deletebutton
            // 
            this.m_deletebutton.AutoSize = true;
            this.m_deletebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_deletebutton.Depth = 0;
            this.m_deletebutton.Icon = null;
            this.m_deletebutton.Location = new System.Drawing.Point(1238, 21);
            this.m_deletebutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_deletebutton.Name = "m_deletebutton";
            this.m_deletebutton.Primary = true;
            this.m_deletebutton.Size = new System.Drawing.Size(69, 36);
            this.m_deletebutton.TabIndex = 0;
            this.m_deletebutton.Text = "Delete";
            this.m_deletebutton.UseVisualStyleBackColor = true;
            this.m_deletebutton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(1151, 21);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(81, 36);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Add New";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.expenses_listview);
            this.tabPage1.Controls.Add(this.expenses_DelBtn);
            this.tabPage1.Controls.Add(this.expenses_AddBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 590);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Expenses tax";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // expenses_listview
            // 
            this.expenses_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenses_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expen_column1,
            this.expen_column2,
            this.expen_column3,
            this.expen_column4,
            this.expen_column5});
            this.expenses_listview.Depth = 0;
            this.expenses_listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.expenses_listview.FullRowSelect = true;
            this.expenses_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.expenses_listview.Location = new System.Drawing.Point(82, 82);
            this.expenses_listview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.expenses_listview.MouseState = MaterialSkin.MouseState.OUT;
            this.expenses_listview.Name = "expenses_listview";
            this.expenses_listview.OwnerDraw = true;
            this.expenses_listview.Size = new System.Drawing.Size(1150, 453);
            this.expenses_listview.TabIndex = 6;
            this.expenses_listview.UseCompatibleStateImageBehavior = false;
            this.expenses_listview.View = System.Windows.Forms.View.Details;
            // 
            // expen_column1
            // 
            this.expen_column1.Text = "NO";
            this.expen_column1.Width = 70;
            // 
            // expen_column2
            // 
            this.expen_column2.Text = "Description";
            this.expen_column2.Width = 400;
            // 
            // expen_column3
            // 
            this.expen_column3.Text = "Starting Date";
            this.expen_column3.Width = 300;
            // 
            // expen_column4
            // 
            this.expen_column4.Text = "Frequency";
            this.expen_column4.Width = 200;
            // 
            // expen_column5
            // 
            this.expen_column5.Text = "Amount";
            this.expen_column5.Width = 180;
            // 
            // expenses_DelBtn
            // 
            this.expenses_DelBtn.AutoSize = true;
            this.expenses_DelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.expenses_DelBtn.Depth = 0;
            this.expenses_DelBtn.Icon = null;
            this.expenses_DelBtn.Location = new System.Drawing.Point(1238, 21);
            this.expenses_DelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.expenses_DelBtn.Name = "expenses_DelBtn";
            this.expenses_DelBtn.Primary = true;
            this.expenses_DelBtn.Size = new System.Drawing.Size(69, 36);
            this.expenses_DelBtn.TabIndex = 5;
            this.expenses_DelBtn.Text = "DELETE";
            this.expenses_DelBtn.UseVisualStyleBackColor = true;
            this.expenses_DelBtn.Click += new System.EventHandler(this.OnExpenses_DelButton);
            // 
            // expenses_AddBtn
            // 
            this.expenses_AddBtn.AutoSize = true;
            this.expenses_AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.expenses_AddBtn.Depth = 0;
            this.expenses_AddBtn.Icon = null;
            this.expenses_AddBtn.Location = new System.Drawing.Point(1151, 21);
            this.expenses_AddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.expenses_AddBtn.Name = "expenses_AddBtn";
            this.expenses_AddBtn.Primary = true;
            this.expenses_AddBtn.Size = new System.Drawing.Size(81, 36);
            this.expenses_AddBtn.TabIndex = 5;
            this.expenses_AddBtn.Text = "Add New";
            this.expenses_AddBtn.UseVisualStyleBackColor = true;
            this.expenses_AddBtn.Click += new System.EventHandler(this.OnExpenses_AddButton);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 65);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1366, 73);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // dash_changetheme
            // 
            this.dash_changetheme.AutoSize = true;
            this.dash_changetheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dash_changetheme.Depth = 0;
            this.dash_changetheme.Icon = null;
            this.dash_changetheme.Location = new System.Drawing.Point(1006, 85);
            this.dash_changetheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.dash_changetheme.Name = "dash_changetheme";
            this.dash_changetheme.Primary = true;
            this.dash_changetheme.Size = new System.Drawing.Size(125, 36);
            this.dash_changetheme.TabIndex = 0;
            this.dash_changetheme.Text = "CHANGE THEME";
            this.dash_changetheme.UseVisualStyleBackColor = true;
            this.dash_changetheme.Click += new System.EventHandler(this.dash_changetheme_Click);
            // 
            // dash_changecolor
            // 
            this.dash_changecolor.AutoSize = true;
            this.dash_changecolor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dash_changecolor.Depth = 0;
            this.dash_changecolor.Icon = null;
            this.dash_changecolor.Location = new System.Drawing.Point(1154, 85);
            this.dash_changecolor.MouseState = MaterialSkin.MouseState.HOVER;
            this.dash_changecolor.Name = "dash_changecolor";
            this.dash_changecolor.Primary = true;
            this.dash_changecolor.Size = new System.Drawing.Size(181, 36);
            this.dash_changecolor.TabIndex = 0;
            this.dash_changecolor.Text = "CHANGE COLOR SCHEME";
            this.dash_changecolor.UseVisualStyleBackColor = true;
            this.dash_changecolor.Click += new System.EventHandler(this.dash_changecolor_Click);
            // 
            // MainDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dash_changecolor);
            this.Controls.Add(this.dash_changetheme);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "MainDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main - DashBoard";
            this.Load += new System.EventHandler(this.MainDashBoard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.dash_cashflow.ResumeLayout(false);
            this.m_incometax.ResumeLayout(false);
            this.m_incometax.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage dash_cashflow;
        private System.Windows.Forms.TabPage m_incometax;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton dash_changetheme;
        private MaterialSkin.Controls.MaterialRaisedButton dash_changecolor;
        private MaterialSkin.Controls.MaterialListView cashflow_listview;
        private System.Windows.Forms.ColumnHeader listview_field_1;
        private System.Windows.Forms.ColumnHeader listview_field_2;
        private System.Windows.Forms.ColumnHeader listview_field_3;
        private System.Windows.Forms.ColumnHeader listview_field_4;
        private System.Windows.Forms.ColumnHeader listview_field_5;
        private System.Windows.Forms.ColumnHeader listview_field_6;
        private System.Windows.Forms.ColumnHeader listview_field_7;
        private System.Windows.Forms.ColumnHeader listview_field_8;
        private System.Windows.Forms.ColumnHeader listview_field_9;
        private System.Windows.Forms.ColumnHeader listview_field_10;
        private System.Windows.Forms.ColumnHeader listview_field_11;
        private System.Windows.Forms.ColumnHeader listview_field_12;
        private System.Windows.Forms.ColumnHeader listview_field_0;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton expenses_AddBtn;
        public MaterialSkin.Controls.MaterialListView income_listview;
        private System.Windows.Forms.ColumnHeader m_column1;
        private System.Windows.Forms.ColumnHeader m_column2;
        private System.Windows.Forms.ColumnHeader m_column3;
        private System.Windows.Forms.ColumnHeader m_column4;
        private System.Windows.Forms.ColumnHeader m_column5;
        private MaterialSkin.Controls.MaterialRaisedButton m_deletebutton;
        public MaterialSkin.Controls.MaterialListView expenses_listview;
        private System.Windows.Forms.ColumnHeader expen_column1;
        private System.Windows.Forms.ColumnHeader expen_column2;
        private System.Windows.Forms.ColumnHeader expen_column3;
        private System.Windows.Forms.ColumnHeader expen_column4;
        private System.Windows.Forms.ColumnHeader expen_column5;
        private MaterialSkin.Controls.MaterialRaisedButton expenses_DelBtn;
    }
}