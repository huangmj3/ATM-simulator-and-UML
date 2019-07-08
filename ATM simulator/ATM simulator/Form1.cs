using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_simulator
{
    
    public partial class Form1 : Form
    {

        double money = 0;
        string accountNumber1 = "622266222662266226";
        int password1 = 123456;
        double money1 = 10000;
        string accountNumber2 = "62226622662266227";
        int password2 = 123456;
        double money2 = 10000;
        int amount;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
            insertButton.Visible = true;
            AccountAndPasswordPanel.Visible = false;
            returnButton.Visible = false;
            withdrawButton.Visible = false;
            transferButton.Visible = false;
            displayButton.Visible = false;
            amountLabel.Visible = false;
            withdralAmountBox.Visible = false;
            resetButton.Visible = false;
            checkButton.Visible = false;
            oneHundredButton.Visible = false;
            threeHundredButton.Visible = false;
            fiveHundredButton.Visible = false;
            thousandButton.Visible = false;
            removeButton.Visible = false;
            withdrawPanel.Visible = false;
            transferPanel.Visible = false;
            displayCreditPanel.Visible = false;
        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            withdralAmountBox.Text = "";
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            accountNumberBox.Text = "";
            passwordBox.Text = "";
            AccountAndPasswordPanel.Visible = true;
            insertButton.Visible = false;
            withdrawPanel.Visible = false;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            withdrawButton.Visible = true;
            withdrawPanel.Visible = true;
            amountLabel.Visible = true;
            withdralAmountBox.Visible = true;
            resetButton.Visible = true;
            checkButton.Visible = true;
            oneHundredButton.Visible = true;
            threeHundredButton.Visible = true;
            fiveHundredButton.Visible = true;
            thousandButton.Visible = true;
            removeButton.Visible = true;
            returnButton.Visible = true;
            transferPanel.Visible = false;
            displayCreditPanel.Visible = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            insertButton.Visible = true;
            returnButton.Visible = false;
            withdrawButton.Visible = false;
            transferButton.Visible = false;
            displayButton.Visible = false;
            amountLabel.Visible = false;
            withdralAmountBox.Visible = false;
            resetButton.Visible = false;
            checkButton.Visible = false;
            oneHundredButton.Visible = false;
            threeHundredButton.Visible = false;
            fiveHundredButton.Visible = false;
            thousandButton.Visible = false;
            removeButton.Visible = false;
            withdrawPanel.Visible = false;
            transferPanel.Visible = false;
            displayCreditPanel.Visible = false;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (withdralAmountBox.Text == "")
                MessageBox.Show("请选择或者输入存款金额！");
            else
            {
                double withdralAmount = double.Parse(withdralAmountBox.Text);
                if (withdralAmount > money)
                {
                    MessageBox.Show("余额不足，请重新输入！");
                    withdralAmountBox.Text = "";
                }
                else if(withdralAmount %100 != 0)
                {
                    MessageBox.Show("请输入100的倍数！");
                    withdralAmountBox.Text = "";
                }
                else
                {
                    MessageBox.Show("取款成功");
                    withdralAmountBox.Text = "";
                    money -= withdralAmount;
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = accountNumberBox.Text;
            string pwd = passwordBox.Text;
            //创建数据库连接类的对象
            //SqlConnection con = new SqlConnection("server=(local);database=BankAccount;user=sa;pwd=123456");
            //打开连接
            //DatabaseOp databaseop = new DatabaseOp();
            //DataTable data = databaseop.GetDataTableValue("select * from AcountInformation where AcountNumber = 1");
            //MessageBox.Show(data.ToString());
            //con.Open();
            //con.Close();
            if (accountNumberBox.Text == accountNumber1.ToString() && passwordBox.Text == password1.ToString())
            {
                money = money1;
                withdrawButton.Visible = true;
                transferButton.Visible = true;
                displayButton.Visible = true;
                removeButton.Visible = true;
                insertButton.Visible = false;
                AccountAndPasswordPanel.Visible = false;
                withdrawPanel.Visible = false;
            }
            else if (accountNumberBox.Text == accountNumber2.ToString() && passwordBox.Text == password2.ToString())
            {
                money = money2;
                withdrawButton.Visible = true;
                transferButton.Visible = true;
                displayButton.Visible = true;
                removeButton.Visible = true;
                insertButton.Visible = false;
                AccountAndPasswordPanel.Visible = false;
                withdrawPanel.Visible = false;
            }
            else
                MessageBox.Show("账号或密码错误，请重新输入");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            withdrawButton.Visible = true;
            transferButton.Visible = true;
            displayButton.Visible = true;
            removeButton.Visible = true;
            insertButton.Visible = false;
            AccountAndPasswordPanel.Visible = false;
            AccountAndPasswordPanel.Visible = false;
            returnButton.Visible = false;
            amountLabel.Visible = false;
            withdralAmountBox.Visible = false;
            resetButton.Visible = false;
            checkButton.Visible = false;
            oneHundredButton.Visible = false;
            threeHundredButton.Visible = false;
            fiveHundredButton.Visible = false;
            thousandButton.Visible = false;
            withdrawPanel.Visible = false;
            transferPanel.Visible = false;
            displayCreditPanel.Visible = false;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            returnButton.Visible = true;
            removeButton.Visible = true;
            transferPanel.Visible = true;
            withdrawPanel.Visible = false;
            AccountAndPasswordPanel.Visible = false;
            oneHundredButton.Visible = false;
            threeHundredButton.Visible = false;
            fiveHundredButton.Visible = false;
            thousandButton.Visible = false;
            displayCreditPanel.Visible = false;
        }

        private void oneHundredButton_Click(object sender, EventArgs e)
        {
            withdralAmountBox.Text = "100";
        }

        private void threeHundredButton_Click(object sender, EventArgs e)
        {
            withdralAmountBox.Text = "300";
        }

        private void fiveHundredButton_Click(object sender, EventArgs e)
        {
            withdralAmountBox.Text = "500";
        }

        private void thousandButton_Click(object sender, EventArgs e)
        {
            withdralAmountBox.Text = "1000";
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            displayCreditPanel.Visible = true;
            returnButton.Visible = true;
            removeButton.Visible = true;
            transferPanel.Visible = false;
            withdrawPanel.Visible = false;
            AccountAndPasswordPanel.Visible = false;
            oneHundredButton.Visible = false;
            threeHundredButton.Visible = false;
            fiveHundredButton.Visible = false;
            thousandButton.Visible = false;
            displayBox.Text = money.ToString();
        }

        private void transferResetButton_Click(object sender, EventArgs e)
        {
            transferAccount.Text = "";
            transferAmount.Text = "";
        }

        private void transferCheckButton_Click(object sender, EventArgs e)
        {
            if (transferAccount.Text == 1.ToString() || transferAccount.Text == 2.ToString())
                flag = true;
            else
            {
                MessageBox.Show("查无此号，请重新输入！");
                transferAccount.Text = "";
                transferAmount.Text = "";
            }
            if(flag == true)
            {
                double transferMoney = double.Parse(transferAmount.Text);
                if(transferAmount.Text == 1.ToString())
                {
                    money = money1;
                }
                if (transferAmount.Text == 2.ToString())
                {
                    money = money2;
                }
                if(transferMoney > money)
                {
                    MessageBox.Show("余额不足，请重新输入！");
                    transferAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("转账成功");
                    money -= transferMoney;
                }
                if (transferAmount.Text == 1.ToString())
                {
                    money1 = money;
                }
                if (transferAmount.Text == 2.ToString())
                {
                    money2 = money;
                }
            }
        }
    }
}
