namespace CashFlowDemo
{
    partial class AddExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_close = new MaterialSkin.Controls.MaterialRaisedButton();
            this.m_confirm = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.m_frequency = new System.Windows.Forms.ComboBox();
            this.m_datepicker = new System.Windows.Forms.DateTimePicker();
            this.m_amount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.m_description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // m_close
            // 
            this.m_close.AutoSize = true;
            this.m_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_close.Depth = 0;
            this.m_close.Icon = null;
            this.m_close.Location = new System.Drawing.Point(317, 305);
            this.m_close.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_close.Name = "m_close";
            this.m_close.Primary = true;
            this.m_close.Size = new System.Drawing.Size(63, 36);
            this.m_close.TabIndex = 13;
            this.m_close.Text = "Close";
            this.m_close.UseVisualStyleBackColor = true;
            this.m_close.Click += new System.EventHandler(this.OnExpenses_Close);
            // 
            // m_confirm
            // 
            this.m_confirm.AutoSize = true;
            this.m_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_confirm.Depth = 0;
            this.m_confirm.Icon = null;
            this.m_confirm.Location = new System.Drawing.Point(176, 305);
            this.m_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_confirm.Name = "m_confirm";
            this.m_confirm.Primary = true;
            this.m_confirm.Size = new System.Drawing.Size(81, 36);
            this.m_confirm.TabIndex = 14;
            this.m_confirm.Text = "Confirm";
            this.m_confirm.UseVisualStyleBackColor = true;
            this.m_confirm.Click += new System.EventHandler(this.OnExpenses_Confirm);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(65, 262);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(66, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Amount:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(49, 214);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Frequency:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(87, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Date:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(41, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Description:";
            // 
            // m_frequency
            // 
            this.m_frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.m_frequency.FormattingEnabled = true;
            this.m_frequency.Location = new System.Drawing.Point(176, 205);
            this.m_frequency.Name = "m_frequency";
            this.m_frequency.Size = new System.Drawing.Size(204, 28);
            this.m_frequency.TabIndex = 8;
            // 
            // m_datepicker
            // 
            this.m_datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_datepicker.Location = new System.Drawing.Point(176, 155);
            this.m_datepicker.Name = "m_datepicker";
            this.m_datepicker.Size = new System.Drawing.Size(200, 20);
            this.m_datepicker.TabIndex = 7;
            // 
            // m_amount
            // 
            this.m_amount.Depth = 0;
            this.m_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.m_amount.Hint = "";
            this.m_amount.Location = new System.Drawing.Point(176, 258);
            this.m_amount.MaxLength = 32767;
            this.m_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_amount.Name = "m_amount";
            this.m_amount.PasswordChar = '\0';
            this.m_amount.SelectedText = "";
            this.m_amount.SelectionLength = 0;
            this.m_amount.SelectionStart = 0;
            this.m_amount.Size = new System.Drawing.Size(204, 23);
            this.m_amount.TabIndex = 5;
            this.m_amount.TabStop = false;
            this.m_amount.UseSystemPasswordChar = false;
            // 
            // m_description
            // 
            this.m_description.Depth = 0;
            this.m_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.m_description.Hint = "";
            this.m_description.Location = new System.Drawing.Point(176, 101);
            this.m_description.MaxLength = 32767;
            this.m_description.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_description.Name = "m_description";
            this.m_description.PasswordChar = '\0';
            this.m_description.SelectedText = "";
            this.m_description.SelectionLength = 0;
            this.m_description.SelectionStart = 0;
            this.m_description.Size = new System.Drawing.Size(204, 23);
            this.m_description.TabIndex = 6;
            this.m_description.TabStop = false;
            this.m_description.UseSystemPasswordChar = false;
            // 
            // AddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 374);
            this.Controls.Add(this.m_close);
            this.Controls.Add(this.m_confirm);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.m_frequency);
            this.Controls.Add(this.m_datepicker);
            this.Controls.Add(this.m_amount);
            this.Controls.Add(this.m_description);
            this.Name = "AddExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton m_close;
        private MaterialSkin.Controls.MaterialRaisedButton m_confirm;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox m_frequency;
        private System.Windows.Forms.DateTimePicker m_datepicker;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_amount;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_description;
    }
}