namespace ATMSolution.CardInfo
{
    partial class FrmCardInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCurType = new System.Windows.Forms.Label();
            this.lbSavingTypr = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.rbtSavingTyprCurrent = new System.Windows.Forms.RadioButton();
            this.rbtSavingTyprRegular = new System.Windows.Forms.RadioButton();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnCardInfosave = new System.Windows.Forms.Button();
            this.btnCardInfoclose = new System.Windows.Forms.Button();
            this.laCurType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserInfo = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "开 卡";
            // 
            // lbCurType
            // 
            this.lbCurType.AutoSize = true;
            this.lbCurType.Location = new System.Drawing.Point(122, 229);
            this.lbCurType.Name = "lbCurType";
            this.lbCurType.Size = new System.Drawing.Size(47, 12);
            this.lbCurType.TabIndex = 2;
            this.lbCurType.Text = "币 种：";
            // 
            // lbSavingTypr
            // 
            this.lbSavingTypr.AutoSize = true;
            this.lbSavingTypr.Location = new System.Drawing.Point(104, 264);
            this.lbSavingTypr.Name = "lbSavingTypr";
            this.lbSavingTypr.Size = new System.Drawing.Size(65, 12);
            this.lbSavingTypr.TabIndex = 3;
            this.lbSavingTypr.Text = "存款类型：";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(104, 300);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(65, 12);
            this.lbBalance.TabIndex = 4;
            this.lbBalance.Text = "存款余额：";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(122, 194);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(47, 12);
            this.lbPass.TabIndex = 5;
            this.lbPass.Text = "密 码：";
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.Location = new System.Drawing.Point(122, 155);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(47, 12);
            this.lbCardNo.TabIndex = 6;
            this.lbCardNo.Text = "卡 号：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(175, 152);
            this.txtCardNo.MaxLength = 14;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(342, 21);
            this.txtCardNo.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(175, 191);
            this.txtPass.MaxLength = 6;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(342, 21);
            this.txtPass.TabIndex = 8;
            // 
            // rbtSavingTyprCurrent
            // 
            this.rbtSavingTyprCurrent.AutoSize = true;
            this.rbtSavingTyprCurrent.Location = new System.Drawing.Point(183, 264);
            this.rbtSavingTyprCurrent.Name = "rbtSavingTyprCurrent";
            this.rbtSavingTyprCurrent.Size = new System.Drawing.Size(47, 16);
            this.rbtSavingTyprCurrent.TabIndex = 10;
            this.rbtSavingTyprCurrent.Text = "活期";
            this.rbtSavingTyprCurrent.UseVisualStyleBackColor = true;
            // 
            // rbtSavingTyprRegular
            // 
            this.rbtSavingTyprRegular.AutoSize = true;
            this.rbtSavingTyprRegular.Location = new System.Drawing.Point(281, 264);
            this.rbtSavingTyprRegular.Name = "rbtSavingTyprRegular";
            this.rbtSavingTyprRegular.Size = new System.Drawing.Size(47, 16);
            this.rbtSavingTyprRegular.TabIndex = 11;
            this.rbtSavingTyprRegular.TabStop = true;
            this.rbtSavingTyprRegular.Text = "定期";
            this.rbtSavingTyprRegular.UseVisualStyleBackColor = true;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(176, 297);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(342, 21);
            this.txtBalance.TabIndex = 12;
            // 
            // btnCardInfosave
            // 
            this.btnCardInfosave.Location = new System.Drawing.Point(183, 357);
            this.btnCardInfosave.Name = "btnCardInfosave";
            this.btnCardInfosave.Size = new System.Drawing.Size(75, 23);
            this.btnCardInfosave.TabIndex = 13;
            this.btnCardInfosave.Text = "保 存";
            this.btnCardInfosave.UseVisualStyleBackColor = true;
            this.btnCardInfosave.Click += new System.EventHandler(this.btnCardInfosave_Click);
            // 
            // btnCardInfoclose
            // 
            this.btnCardInfoclose.Location = new System.Drawing.Point(320, 356);
            this.btnCardInfoclose.Name = "btnCardInfoclose";
            this.btnCardInfoclose.Size = new System.Drawing.Size(75, 23);
            this.btnCardInfoclose.TabIndex = 14;
            this.btnCardInfoclose.Text = "关 闭";
            this.btnCardInfoclose.UseVisualStyleBackColor = true;
            this.btnCardInfoclose.Click += new System.EventHandler(this.btnCardInfoclose_Click);
            // 
            // laCurType
            // 
            this.laCurType.AutoSize = true;
            this.laCurType.Location = new System.Drawing.Point(175, 229);
            this.laCurType.Name = "laCurType";
            this.laCurType.Size = new System.Drawing.Size(29, 12);
            this.laCurType.TabIndex = 15;
            this.laCurType.Text = "RMVB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "用 户：";
            // 
            // txtUserInfo
            // 
            this.txtUserInfo.Location = new System.Drawing.Point(175, 112);
            this.txtUserInfo.MaxLength = 14;
            this.txtUserInfo.Name = "txtUserInfo";
            this.txtUserInfo.ReadOnly = true;
            this.txtUserInfo.Size = new System.Drawing.Size(342, 21);
            this.txtUserInfo.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(533, 110);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "浏览";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FrmCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 437);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.laCurType);
            this.Controls.Add(this.btnCardInfoclose);
            this.Controls.Add(this.btnCardInfosave);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.rbtSavingTyprRegular);
            this.Controls.Add(this.rbtSavingTyprCurrent);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserInfo);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbSavingTypr);
            this.Controls.Add(this.lbCurType);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCardInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "开卡";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCurType;
        private System.Windows.Forms.Label lbSavingTypr;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton rbtSavingTyprCurrent;
        private System.Windows.Forms.RadioButton rbtSavingTyprRegular;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnCardInfosave;
        private System.Windows.Forms.Button btnCardInfoclose;
        private System.Windows.Forms.Label laCurType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserInfo;
        private System.Windows.Forms.Button btnFind;

    }
}