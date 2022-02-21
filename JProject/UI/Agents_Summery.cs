using JProject.BLL;
using JProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JProject.UI
{
    public partial class Agents_Summery : Form
    {
        public Agents_Summery()
        {
            InitializeComponent();
        }

        DataTable SummeryDT = new DataTable();
        Sales_TransactionDAL SalesTrDal = new Sales_TransactionDAL();
        AgentDAL agDal = new AgentDAL();
        Purchase_TransactionDAL purTrnDal = new Purchase_TransactionDAL();

        private void Agents_Summery_Load(object sender, EventArgs e)
        {
            //Specify columns for Agent Summery DataTable
            SummeryDT.Columns.Add("Agent Name");
            SummeryDT.Columns.Add("Agent No");
            SummeryDT.Columns.Add("Sales Value");
            SummeryDT.Columns.Add("Cash & Cheques");
            SummeryDT.Columns.Add("Win-NLB");
            SummeryDT.Columns.Add("Win-DLB");
            SummeryDT.Columns.Add("Return-NLB");
            SummeryDT.Columns.Add("Return-DLB");
            SummeryDT.Columns.Add("FreeIssue-NLB");
            SummeryDT.Columns.Add("FreeIssue-DLB");
            SummeryDT.Columns.Add("Credit");
            SummeryDT.Columns.Add("Total");
            SummeryDT.Columns.Add("OP Credit Balance");
            SummeryDT.Columns.Add("CL Credit Balance");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //get Date
            DateTime keyword = dtpSummeryDate.Value;
            if (keyword != null)
            {
                //Show all Sales Transactions based on the Date
                SummeryDT = SalesTrDal.SelectSalesTransForAgentSummery(keyword);
                dgvAgentSummery.DataSource = SummeryDT;

                decimal Totcash = 0;
                decimal TotWinNlb = 0;
                decimal TotWinDlb = 0;
                decimal TotRetNlb = 0;
                decimal TotRetDlb = 0;
                decimal TotFreeNlb = 0;
                decimal TotFreeDlb = 0;
                decimal TotSales = 0;
                decimal TotTodayCredits = 0;

                for (int i = 0; i < SummeryDT.Rows.Count; i++)
                {
                    decimal sales = decimal.Parse(SummeryDT.Rows[i][2].ToString());
                    TotSales = TotSales + sales;

                    decimal cash = decimal.Parse(SummeryDT.Rows[i][3].ToString());
                    Totcash = Totcash + cash;

                    decimal winN = decimal.Parse(SummeryDT.Rows[i][4].ToString());
                    TotWinNlb = TotWinNlb + winN;

                    decimal winD = decimal.Parse(SummeryDT.Rows[i][5].ToString());
                    TotWinDlb = TotWinDlb + winD;

                    decimal RetN = decimal.Parse(SummeryDT.Rows[i][6].ToString());
                    TotRetNlb = TotRetNlb + RetN;

                    decimal RetD = decimal.Parse(SummeryDT.Rows[i][7].ToString());
                    TotRetDlb = TotRetDlb + RetD;

                    decimal FreeN = decimal.Parse(SummeryDT.Rows[i][8].ToString());
                    TotFreeNlb = TotFreeNlb + FreeN;

                    decimal FreeD = decimal.Parse(SummeryDT.Rows[i][9].ToString());
                    TotFreeDlb = TotFreeDlb + FreeD;

                    decimal todaycredit = decimal.Parse(SummeryDT.Rows[i][10].ToString());
                    TotTodayCredits = TotTodayCredits + todaycredit;
                }

                txtCash.Text = Totcash.ToString();
                txtWinNlb.Text = TotWinNlb.ToString();
                txtWinDlb.Text = TotWinDlb.ToString();
                txtRetNlb.Text = TotRetNlb.ToString();
                txtRetDlb.Text = TotRetDlb.ToString();
                txtfreeNlb.Text = TotFreeNlb.ToString();
                txtFreeDlb.Text = TotFreeDlb.ToString();
                txtTotSales.Text = TotSales.ToString();
                txtTodayCredits.Text = TotTodayCredits.ToString();

                decimal TotWin = TotWinNlb + TotWinDlb;
                txtWinTotal.Text = TotWin.ToString();

                decimal TotRet = TotRetNlb + TotRetDlb;
                txtRetTotal.Text = TotRet.ToString();

                decimal TotFree = TotFreeNlb + TotFreeDlb;
                txtFreeTotal.Text = TotFree.ToString();

                decimal TotReceive = Totcash + TotWin + TotRet + TotFree;
                txtTotReceives.Text = TotReceive.ToString();

                //Get Total Agent's credit amount
                decimal TotCreditAmount = agDal.CalculateTotalCredit();
                txtTotCredits.Text = TotCreditAmount.ToString();

                //Get Total Daily Purchse amount
                decimal TotPurAmount = purTrnDal.CalculateDailyPurchses(keyword);
                txtTotPurchses.Text = TotPurAmount.ToString();
            }
            else
            {
                dgvAgentSummery.DataSource = null;
                dgvAgentSummery.Rows.Clear();
                dgvAgentSummery.Refresh();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotCredits_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
