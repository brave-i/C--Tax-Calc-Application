namespace CashFlowDemo
{
    partial class Form1
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
            this.login_id_lineedit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.login_pwd_lineedit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.login_remember_checkbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.login_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.login_title_label = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // login_id_lineedit
            // 
            this.login_id_lineedit.Depth = 0;
            this.login_id_lineedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_id_lineedit.Hint = "";
            this.login_id_lineedit.Location = new System.Drawing.Point(59, 132);
            this.login_id_lineedit.MaxLength = 32767;
            this.login_id_lineedit.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_id_lineedit.Name = "login_id_lineedit";
            this.login_id_lineedit.PasswordChar = '\0';
            this.login_id_lineedit.SelectedText = "";
            this.login_id_lineedit.SelectionLength = 0;
            this.login_id_lineedit.SelectionStart = 0;
            this.login_id_lineedit.Size = new System.Drawing.Size(254, 23);
            this.login_id_lineedit.TabIndex = 0;
            this.login_id_lineedit.TabStop = false;
            this.login_id_lineedit.UseSystemPasswordChar = false;
            // 
            // login_pwd_lineedit
            // 
            this.login_pwd_lineedit.Depth = 0;
            this.login_pwd_lineedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_pwd_lineedit.Hint = "";
            this.login_pwd_lineedit.Location = new System.Drawing.Point(59, 172);
            this.login_pwd_lineedit.MaxLength = 32767;
            this.login_pwd_lineedit.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_pwd_lineedit.Name = "login_pwd_lineedit";
            this.login_pwd_lineedit.PasswordChar = '\0';
            this.login_pwd_lineedit.SelectedText = "";
            this.login_pwd_lineedit.SelectionLength = 0;
            this.login_pwd_lineedit.SelectionStart = 0;
            this.login_pwd_lineedit.Size = new System.Drawing.Size(254, 23);
            this.login_pwd_lineedit.TabIndex = 1;
            this.login_pwd_lineedit.TabStop = false;
            this.login_pwd_lineedit.UseSystemPasswordChar = true;
            this.login_pwd_lineedit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnProcessLogin);
            // 
            // login_remember_checkbox
            // 
            this.login_remember_checkbox.Depth = 0;
            this.login_remember_checkbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.login_remember_checkbox.Location = new System.Drawing.Point(59, 236);
            this.login_remember_checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.login_remember_checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.login_remember_checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_remember_checkbox.Name = "login_remember_checkbox";
            this.login_remember_checkbox.Ripple = true;
            this.login_remember_checkbox.Size = new System.Drawing.Size(254, 18);
            this.login_remember_checkbox.TabIndex = 2;
            this.login_remember_checkbox.Text = "Remember Me!";
            this.login_remember_checkbox.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.AutoSize = false;
            this.login_button.Depth = 0;
            this.login_button.Icon = null;
            this.login_button.Location = new System.Drawing.Point(59, 271);
            this.login_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_button.Name = "login_button";
            this.login_button.Primary = true;
            this.login_button.Size = new System.Drawing.Size(254, 36);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_title_label
            // 
            this.login_title_label.AutoSize = true;
            this.login_title_label.Depth = 0;
            this.login_title_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.login_title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_title_label.Location = new System.Drawing.Point(154, 85);
            this.login_title_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_title_label.Name = "login_title_label";
            this.login_title_label.Size = new System.Drawing.Size(72, 19);
            this.login_title_label.TabIndex = 4;
            this.login_title_label.Text = "Welcome";
            this.login_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 370);
            this.Controls.Add(this.login_title_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_remember_checkbox);
            this.Controls.Add(this.login_pwd_lineedit);
            this.Controls.Add(this.login_id_lineedit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField login_id_lineedit;
        private MaterialSkin.Controls.MaterialSingleLineTextField login_pwd_lineedit;
        private MaterialSkin.Controls.MaterialCheckBox login_remember_checkbox;
        private MaterialSkin.Controls.MaterialRaisedButton login_button;
        private MaterialSkin.Controls.MaterialLabel login_title_label;
    }
}

