using JProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JProject.UI
{
    public partial class Monthly_Summery : Form
    {
        public Monthly_Summery()
        {
            InitializeComponent();
        }

        Sales_TransactionDAL salesTransDal = new Sales_TransactionDAL();
        Purchase_TransactionDAL purTransDal = new Purchase_TransactionDAL();
        Return_TransactionDAL RetTransDal = new Return_TransactionDAL();
        AgentDAL aDal = new AgentDAL();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Get month and Year
            DateTime DrDate = dtpMonthSummery.Value;
            int mon = dtpMonthSummery.Value.Month;
            int year = dtpMonthSummery.Value.Year;

            //Purchases
            //Get and Set Total purchases value as per the month 
            decimal CreditPurchase = purTransDal.GetMonthlyCreditPurchaseAmount(mon, year);
            lblCreditPurchases.Text = CreditPurchase.ToString();

            decimal CashBankWinPurchase = purTransDal.GetTotalCashBankWinPurchases(mon, year);
            lblBankCashWinPur.Text = CashBankWinPurchase.ToString();

            decimal ReturnPurchase = purTransDal.GetTotalReturnPurchases(mon, year);
            lblReturnPur.Text = ReturnPurchase.ToString();

            decimal totalPurchase = purTransDal.GetMonthlyPurchaseAmount(mon, year);
            lblPurchaseTot.Text = totalPurchase.ToString();

            //Sales
            //Get and Set Total sales value as per the month 
            decimal totalSales = salesTransDal.GetMonthlySalesAmount(mon, year);
            lblSalesTot.Text = totalSales.ToString();

            decimal totalCashWinSales = salesTransDal.GetTotalCashBankWinSales(mon, year);
            lblSalesCashWin.Text = totalCashWinSales.ToString();

            decimal totalRetSales = salesTransDal.GetTotalReturnSales(mon, year);
            lblReturnSales.Text = totalRetSales.ToString();

            decimal totalCreditSales = salesTransDal.GetMonthlyCreditSalesAmount(mon, year);
            lblCreditSales.Text = totalCreditSales.ToString();


            //Get and Set Total returns value as per the month 
            decimal totalReturns = RetTransDal.GetMonthlyReturnAmount(mon, year);
            lblReturnTotal.Text = totalReturns.ToString();

            //Get Total Agent's credit amount
            decimal TotCreditAmount = aDal.CalculateTotalCredit();
            lblCreditBalance.Text = TotCreditAmount.ToString();

            //Display Month name and year
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mon);
            lblMonthName.Text = monthName;
            lblYear.Text = year.ToString();

        }

        private void Monthly_Summery_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
