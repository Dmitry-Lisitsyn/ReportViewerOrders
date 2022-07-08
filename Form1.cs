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

namespace ReportViewerOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Информация_по_заказамTableAdapter.Fill(this.TestSalesDataSet.Информация_по_заказам, dateTimePicker1.Value.Date.ToString("yyyyMMdd"), dateTimePicker2.Value.Date.ToString("yyyyMMdd"));
            this.reportViewer1.RefreshReport();
        }

        private void load_Click(object sender, EventArgs e)
        {
           
            this.Информация_по_заказамTableAdapter.Fill(this.TestSalesDataSet.Информация_по_заказам, dateTimePicker1.Value.Date.ToString("yyyyMMdd"), dateTimePicker2.Value.Date.ToString("yyyyMMdd"));
            this.reportViewer1.RefreshReport();
        }
    }
}
