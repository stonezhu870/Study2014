namespace ATMSolution.UserInfo
{
    partial class FrmTransEdit
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
            this.lbTransDate = new System.Windows.Forms.Label();
            this.lbCardNo = new System.Windows.Forms.Label();
            this.lbTransType = new System.Windows.Forms.Label();
            this.lbRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtTransDate = new System.Windows.Forms.DateTimePicker();
            this.cbxTransType = new System.Windows.Forms.ComboBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.nudMoney = new System.Windows.Forms.NumericUpDown();
            this.txtCardNo = new System.Windows.Forms.MaskedTextBox();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTransDate
            // 
            this.lbTransDate.AutoSize = true;
            this.lbTransDate.Location = new System.Drawing.Point(140, 98);
            this.lbTransDate.Name = "lbTransDate";
            this.lbTransDate.Size = new System.Drawing.Size(65, 12);
            this.lbTransDate.TabIndex = 0;
            this.lbTransDate.Text = "交易日期：";
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.Location = new System.Drawing.Point(147, 153);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(59, 12);
            this.lbCardNo.TabIndex = 0;
            this.lbCardNo.Text = "卡   号：";
            // 
            // lbTransType
            // 
            this.lbTransType.AutoSize = true;
            this.lbTransType.Location = new System.Drawing.Point(139, 208);
            this.lbTransType.Name = "lbTransType";
            this.lbTransType.Size = new System.Drawing.Size(65, 12);
            this.lbTransType.TabIndex = 0;
            this.lbTransType.Text = "交易类型：";
            // 
            // lbRemark
            // 
            this.lbRemark.AutoSize = true;
            this.lbRemark.Location = new System.Drawing.Point(146, 305);
            this.lbRemark.Name = "lbRemark";
            this.lbRemark.Size = new System.Drawing.Size(59, 12);
            this.lbRemark.TabIndex = 0;
            this.lbRemark.Text = "备   注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(206, 302);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(285, 81);
            this.txtRemark.TabIndex = 3;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.White;
            this.panTop.Controls.Add(this.lbTitle);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(661, 71);
            this.panTop.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.Location = new System.Drawing.Point(33, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(71, 19);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "交  易";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(212, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(371, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关  闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtTransDate
            // 
            this.dtTransDate.CustomFormat = "YYYY-MM-DD HH:mm:ss";
            this.dtTransDate.Location = new System.Drawing.Point(206, 92);
            this.dtTransDate.Name = "dtTransDate";
            this.dtTransDate.Size = new System.Drawing.Size(285, 21);
            this.dtTransDate.TabIndex = 6;
            // 
            // cbxTransType
            // 
            this.cbxTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTransType.FormattingEnabled = true;
            this.cbxTransType.Items.AddRange(new object[] {
            "存入",
            "支出"});
            this.cbxTransType.Location = new System.Drawing.Point(206, 205);
            this.cbxTransType.Name = "cbxTransType";
            this.cbxTransType.Size = new System.Drawing.Size(285, 20);
            this.cbxTransType.TabIndex = 7;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(139, 254);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(65, 12);
            this.lbMoney.TabIndex = 8;
            this.lbMoney.Text = "交易金额：";
            // 
            // nudMoney
            // 
            this.nudMoney.Location = new System.Drawing.Point(206, 252);
            this.nudMoney.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMoney.Name = "nudMoney";
            this.nudMoney.Size = new System.Drawing.Size(166, 21);
            this.nudMoney.TabIndex = 9;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(212, 150);
            this.txtCardNo.Mask = "9999 9999 9999";
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(279, 21);
            this.txtCardNo.TabIndex = 10;
            // 
            // FrmTransEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 501);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.nudMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.cbxTransType);
            this.Controls.Add(this.dtTransDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lbRemark);
            this.Controls.Add(this.lbTransType);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.lbTransDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "交易";
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTransDate;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.Label lbTransType;
        private System.Windows.Forms.Label lbRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtTransDate;
        private System.Windows.Forms.ComboBox cbxTransType;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.NumericUpDown nudMoney;
        private System.Windows.Forms.MaskedTextBox txtCardNo;

    }
}