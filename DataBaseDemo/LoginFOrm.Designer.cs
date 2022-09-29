namespace DataBaseDemo
{
    partial class LoginForm
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
            this.LoginTLP = new System.Windows.Forms.TableLayoutPanel();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.LoginTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTLP
            // 
            this.LoginTLP.BackColor = System.Drawing.Color.Lime;
            this.LoginTLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.LoginTLP.ColumnCount = 2;
            this.LoginTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.53846F));
            this.LoginTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.46154F));
            this.LoginTLP.Controls.Add(this.PasswordTB, 1, 1);
            this.LoginTLP.Controls.Add(this.label1, 0, 0);
            this.LoginTLP.Controls.Add(this.label2, 0, 1);
            this.LoginTLP.Controls.Add(this.UsernameTB, 1, 0);
            this.LoginTLP.Controls.Add(this.LoginBTN, 1, 2);
            this.LoginTLP.Location = new System.Drawing.Point(12, 12);
            this.LoginTLP.Name = "LoginTLP";
            this.LoginTLP.RowCount = 3;
            this.LoginTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.LoginTLP.Size = new System.Drawing.Size(260, 86);
            this.LoginTLP.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PasswordTB.Location = new System.Drawing.Point(75, 32);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(179, 20);
            this.PasswordTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UsernameTB.Location = new System.Drawing.Point(75, 6);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(179, 20);
            this.UsernameTB.TabIndex = 2;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoginBTN.Location = new System.Drawing.Point(179, 58);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 22);
            this.LoginBTN.TabIndex = 4;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LoginTLP);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginTLP.ResumeLayout(false);
            this.LoginTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LoginTLP;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Button LoginBTN;
    }
}

