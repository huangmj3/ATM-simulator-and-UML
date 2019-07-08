namespace ATM_simulator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.insertButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.oneHundredButton = new System.Windows.Forms.Button();
            this.threeHundredButton = new System.Windows.Forms.Button();
            this.fiveHundredButton = new System.Windows.Forms.Button();
            this.thousandButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.withdralAmountBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.AccountAndPasswordPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.AccountLable = new System.Windows.Forms.Label();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.transferPanel = new System.Windows.Forms.Panel();
            this.transferCheckButton = new System.Windows.Forms.Button();
            this.transferResetButton = new System.Windows.Forms.Button();
            this.transferAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transferAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayCreditPanel = new System.Windows.Forms.Panel();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountAndPasswordPanel.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.transferPanel.SuspendLayout();
            this.displayCreditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(53, 364);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(148, 49);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "插卡";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(53, 207);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(148, 49);
            this.transferButton.TabIndex = 1;
            this.transferButton.Text = "转账";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(53, 124);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(148, 49);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "取款";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(53, 287);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(148, 49);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "显示余额";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(53, 364);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(148, 49);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "取卡";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(53, 39);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(148, 49);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // oneHundredButton
            // 
            this.oneHundredButton.Location = new System.Drawing.Point(602, 73);
            this.oneHundredButton.Name = "oneHundredButton";
            this.oneHundredButton.Size = new System.Drawing.Size(148, 49);
            this.oneHundredButton.TabIndex = 6;
            this.oneHundredButton.Text = "100";
            this.oneHundredButton.UseVisualStyleBackColor = true;
            this.oneHundredButton.Click += new System.EventHandler(this.oneHundredButton_Click);
            // 
            // threeHundredButton
            // 
            this.threeHundredButton.Location = new System.Drawing.Point(602, 158);
            this.threeHundredButton.Name = "threeHundredButton";
            this.threeHundredButton.Size = new System.Drawing.Size(148, 49);
            this.threeHundredButton.TabIndex = 7;
            this.threeHundredButton.Text = "300";
            this.threeHundredButton.UseVisualStyleBackColor = true;
            this.threeHundredButton.Click += new System.EventHandler(this.threeHundredButton_Click);
            // 
            // fiveHundredButton
            // 
            this.fiveHundredButton.Location = new System.Drawing.Point(602, 246);
            this.fiveHundredButton.Name = "fiveHundredButton";
            this.fiveHundredButton.Size = new System.Drawing.Size(148, 49);
            this.fiveHundredButton.TabIndex = 8;
            this.fiveHundredButton.Text = "500";
            this.fiveHundredButton.UseVisualStyleBackColor = true;
            this.fiveHundredButton.Click += new System.EventHandler(this.fiveHundredButton_Click);
            // 
            // thousandButton
            // 
            this.thousandButton.Location = new System.Drawing.Point(602, 332);
            this.thousandButton.Name = "thousandButton";
            this.thousandButton.Size = new System.Drawing.Size(148, 49);
            this.thousandButton.TabIndex = 9;
            this.thousandButton.Text = "1000";
            this.thousandButton.UseVisualStyleBackColor = true;
            this.thousandButton.Click += new System.EventHandler(this.thousandButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amountLabel.Location = new System.Drawing.Point(43, 24);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(287, 25);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "请选择或者输入取款金额";
            // 
            // withdralAmountBox
            // 
            this.withdralAmountBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.withdralAmountBox.Location = new System.Drawing.Point(116, 79);
            this.withdralAmountBox.Name = "withdralAmountBox";
            this.withdralAmountBox.Size = new System.Drawing.Size(144, 36);
            this.withdralAmountBox.TabIndex = 0;
            this.withdralAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.withdralAmountBox.TextChanged += new System.EventHandler(this.amountBox_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(21, 148);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(148, 49);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "更正";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(216, 148);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(148, 49);
            this.checkButton.TabIndex = 12;
            this.checkButton.Text = "确认";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // AccountAndPasswordPanel
            // 
            this.AccountAndPasswordPanel.Controls.Add(this.LoginButton);
            this.AccountAndPasswordPanel.Controls.Add(this.passwordBox);
            this.AccountAndPasswordPanel.Controls.Add(this.PasswordLable);
            this.AccountAndPasswordPanel.Controls.Add(this.accountNumberBox);
            this.AccountAndPasswordPanel.Controls.Add(this.AccountLable);
            this.AccountAndPasswordPanel.Location = new System.Drawing.Point(280, 82);
            this.AccountAndPasswordPanel.Name = "AccountAndPasswordPanel";
            this.AccountAndPasswordPanel.Size = new System.Drawing.Size(240, 235);
            this.AccountAndPasswordPanel.TabIndex = 13;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("宋体", 15F);
            this.LoginButton.Location = new System.Drawing.Point(59, 178);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(128, 35);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(88, 124);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(130, 25);
            this.passwordBox.TabIndex = 17;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Font = new System.Drawing.Font("宋体", 13F);
            this.PasswordLable.Location = new System.Drawing.Point(6, 126);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(54, 22);
            this.PasswordLable.TabIndex = 16;
            this.PasswordLable.Text = "密码";
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Location = new System.Drawing.Point(88, 70);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(130, 25);
            this.accountNumberBox.TabIndex = 15;
            this.accountNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountLable
            // 
            this.AccountLable.AutoSize = true;
            this.AccountLable.Font = new System.Drawing.Font("宋体", 13F);
            this.AccountLable.Location = new System.Drawing.Point(6, 71);
            this.AccountLable.Name = "AccountLable";
            this.AccountLable.Size = new System.Drawing.Size(54, 22);
            this.AccountLable.TabIndex = 14;
            this.AccountLable.Text = "账号";
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.Controls.Add(this.amountLabel);
            this.withdrawPanel.Controls.Add(this.checkButton);
            this.withdrawPanel.Controls.Add(this.withdralAmountBox);
            this.withdrawPanel.Controls.Add(this.resetButton);
            this.withdrawPanel.Location = new System.Drawing.Point(217, 124);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(374, 212);
            this.withdrawPanel.TabIndex = 18;
            // 
            // transferPanel
            // 
            this.transferPanel.Controls.Add(this.transferCheckButton);
            this.transferPanel.Controls.Add(this.transferResetButton);
            this.transferPanel.Controls.Add(this.transferAmount);
            this.transferPanel.Controls.Add(this.label2);
            this.transferPanel.Controls.Add(this.transferAccount);
            this.transferPanel.Controls.Add(this.label1);
            this.transferPanel.Location = new System.Drawing.Point(306, 65);
            this.transferPanel.Name = "transferPanel";
            this.transferPanel.Size = new System.Drawing.Size(358, 316);
            this.transferPanel.TabIndex = 19;
            // 
            // transferCheckButton
            // 
            this.transferCheckButton.Location = new System.Drawing.Point(172, 236);
            this.transferCheckButton.Name = "transferCheckButton";
            this.transferCheckButton.Size = new System.Drawing.Size(148, 49);
            this.transferCheckButton.TabIndex = 13;
            this.transferCheckButton.Text = "确定";
            this.transferCheckButton.UseVisualStyleBackColor = true;
            this.transferCheckButton.Click += new System.EventHandler(this.transferCheckButton_Click);
            // 
            // transferResetButton
            // 
            this.transferResetButton.Location = new System.Drawing.Point(12, 236);
            this.transferResetButton.Name = "transferResetButton";
            this.transferResetButton.Size = new System.Drawing.Size(148, 49);
            this.transferResetButton.TabIndex = 12;
            this.transferResetButton.Text = "更正";
            this.transferResetButton.UseVisualStyleBackColor = true;
            this.transferResetButton.Click += new System.EventHandler(this.transferResetButton_Click);
            // 
            // transferAmount
            // 
            this.transferAmount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.transferAmount.Location = new System.Drawing.Point(162, 162);
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.Size = new System.Drawing.Size(158, 36);
            this.transferAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "转入金额";
            // 
            // transferAccount
            // 
            this.transferAccount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.transferAccount.Location = new System.Drawing.Point(162, 96);
            this.transferAccount.Name = "transferAccount";
            this.transferAccount.Size = new System.Drawing.Size(157, 36);
            this.transferAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "转入账户";
            // 
            // displayCreditPanel
            // 
            this.displayCreditPanel.Controls.Add(this.displayBox);
            this.displayCreditPanel.Controls.Add(this.label3);
            this.displayCreditPanel.Location = new System.Drawing.Point(238, 98);
            this.displayCreditPanel.Name = "displayCreditPanel";
            this.displayCreditPanel.Size = new System.Drawing.Size(512, 252);
            this.displayCreditPanel.TabIndex = 14;
            // 
            // displayBox
            // 
            this.displayBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.displayBox.Location = new System.Drawing.Point(130, 139);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(248, 36);
            this.displayBox.TabIndex = 1;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(163, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "你现在的余额为";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayCreditPanel);
            this.Controls.Add(this.transferPanel);
            this.Controls.Add(this.thousandButton);
            this.Controls.Add(this.fiveHundredButton);
            this.Controls.Add(this.threeHundredButton);
            this.Controls.Add(this.oneHundredButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.withdrawPanel);
            this.Controls.Add(this.AccountAndPasswordPanel);
            this.Controls.Add(this.removeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AccountAndPasswordPanel.ResumeLayout(false);
            this.AccountAndPasswordPanel.PerformLayout();
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.transferPanel.ResumeLayout(false);
            this.transferPanel.PerformLayout();
            this.displayCreditPanel.ResumeLayout(false);
            this.displayCreditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button oneHundredButton;
        private System.Windows.Forms.Button threeHundredButton;
        private System.Windows.Forms.Button fiveHundredButton;
        private System.Windows.Forms.Button thousandButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox withdralAmountBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Panel AccountAndPasswordPanel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.Label AccountLable;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Panel transferPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transferAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transferAccount;
        private System.Windows.Forms.Button transferCheckButton;
        private System.Windows.Forms.Button transferResetButton;
        private System.Windows.Forms.Panel displayCreditPanel;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Label label3;
    }
}

