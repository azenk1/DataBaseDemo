namespace DataBaseDemo
{
    partial class EnterForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ActionCMB = new System.Windows.Forms.ComboBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.ChamberingTB = new System.Windows.Forms.TextBox();
            this.ModelTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MakeTB = new System.Windows.Forms.TextBox();
            this.SerialTB = new System.Windows.Forms.TextBox();
            this.TypeCMB = new System.Windows.Forms.ComboBox();
            this.PurchaseDTP = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lime;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ActionCMB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriceTB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ChamberingTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ModelTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MakeLBL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.MakeTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SerialTB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.TypeCMB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PurchaseDTP, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ActionCMB
            // 
            this.ActionCMB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionCMB.FormattingEnabled = true;
            this.ActionCMB.Items.AddRange(new object[] {
            "Single Shot",
            "O/U",
            "SxS",
            "Bolt",
            "Lever",
            "Pump",
            "Semi-Auto",
            "Single Action",
            "Double Action"});
            this.ActionCMB.Location = new System.Drawing.Point(188, 176);
            this.ActionCMB.Name = "ActionCMB";
            this.ActionCMB.Size = new System.Drawing.Size(121, 21);
            this.ActionCMB.TabIndex = 3;
            // 
            // PriceTB
            // 
            this.PriceTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceTB.Location = new System.Drawing.Point(198, 283);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(100, 20);
            this.PriceTB.TabIndex = 5;
            // 
            // ChamberingTB
            // 
            this.ChamberingTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChamberingTB.Location = new System.Drawing.Point(198, 230);
            this.ChamberingTB.Name = "ChamberingTB";
            this.ChamberingTB.Size = new System.Drawing.Size(100, 20);
            this.ChamberingTB.TabIndex = 4;
            // 
            // ModelTB
            // 
            this.ModelTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelTB.Location = new System.Drawing.Point(198, 71);
            this.ModelTB.Name = "ModelTB";
            this.ModelTB.Size = new System.Drawing.Size(100, 20);
            this.ModelTB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Action:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model:";
            // 
            // MakeLBL
            // 
            this.MakeLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakeLBL.AutoSize = true;
            this.MakeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLBL.Location = new System.Drawing.Point(43, 18);
            this.MakeLBL.Name = "MakeLBL";
            this.MakeLBL.Size = new System.Drawing.Size(52, 20);
            this.MakeLBL.TabIndex = 9;
            this.MakeLBL.Text = "Make:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chambering:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Purchase Date:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Serial Number:";
            // 
            // MakeTB
            // 
            this.MakeTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakeTB.Location = new System.Drawing.Point(198, 18);
            this.MakeTB.Name = "MakeTB";
            this.MakeTB.Size = new System.Drawing.Size(100, 20);
            this.MakeTB.TabIndex = 0;
            // 
            // SerialTB
            // 
            this.SerialTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialTB.Location = new System.Drawing.Point(198, 389);
            this.SerialTB.Name = "SerialTB";
            this.SerialTB.Size = new System.Drawing.Size(100, 20);
            this.SerialTB.TabIndex = 7;
            // 
            // TypeCMB
            // 
            this.TypeCMB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeCMB.FormattingEnabled = true;
            this.TypeCMB.Items.AddRange(new object[] {
            "Rifle",
            "Shotgun",
            "Pistol",
            "Revolver",
            "Other"});
            this.TypeCMB.Location = new System.Drawing.Point(188, 123);
            this.TypeCMB.Name = "TypeCMB";
            this.TypeCMB.Size = new System.Drawing.Size(121, 21);
            this.TypeCMB.TabIndex = 2;
            // 
            // PurchaseDTP
            // 
            this.PurchaseDTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurchaseDTP.Location = new System.Drawing.Point(148, 336);
            this.PurchaseDTP.Name = "PurchaseDTP";
            this.PurchaseDTP.Size = new System.Drawing.Size(200, 20);
            this.PurchaseDTP.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Lime;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.SubmitBTN, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(256, 453);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(117, 45);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitBTN.Location = new System.Drawing.Point(6, 6);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(105, 33);
            this.SubmitBTN.TabIndex = 8;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 510);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EnterForm";
            this.Text = "EnterForm";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MakeLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ActionCMB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox ChamberingTB;
        private System.Windows.Forms.TextBox ModelTB;
        private System.Windows.Forms.TextBox MakeTB;
        private System.Windows.Forms.TextBox SerialTB;
        private System.Windows.Forms.ComboBox TypeCMB;
        private System.Windows.Forms.DateTimePicker PurchaseDTP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SubmitBTN;
    }
}