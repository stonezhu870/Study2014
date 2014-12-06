namespace ATMSolution.UserInfo
{
    partial class FrmUserInfoEdit
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
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbPid = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtTelPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(147, 98);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(53, 12);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "开户名：";
            // 
            // lbPid
            // 
            this.lbPid.AutoSize = true;
            this.lbPid.Location = new System.Drawing.Point(147, 153);
            this.lbPid.Name = "lbPid";
            this.lbPid.Size = new System.Drawing.Size(53, 12);
            this.lbPid.TabIndex = 0;
            this.lbPid.Text = "身份证：";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Location = new System.Drawing.Point(147, 208);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(53, 12);
            this.lbTelephone.TabIndex = 0;
            this.lbTelephone.Text = "电  话：";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(147, 263);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(53, 12);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "地  址：";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(206, 95);
            this.txtCustomerName.MaxLength = 10;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(285, 21);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(206, 150);
            this.txtPid.MaxLength = 18;
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(285, 21);
            this.txtPid.TabIndex = 1;
            // 
            // txtTelPhone
            // 
            this.txtTelPhone.Location = new System.Drawing.Point(206, 205);
            this.txtTelPhone.MaxLength = 20;
            this.txtTelPhone.Name = "txtTelPhone";
            this.txtTelPhone.Size = new System.Drawing.Size(285, 21);
            this.txtTelPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(206, 260);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 81);
            this.txtAddress.TabIndex = 3;
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
            this.lbTitle.Size = new System.Drawing.Size(60, 19);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "开 户";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(379, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关  闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmUserInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 437);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTelPhone);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.lbPid);
            this.Controls.Add(this.lbCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserInfoEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "开户";
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbPid;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtTelPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;

    }
}