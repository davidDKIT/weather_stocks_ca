using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather_stocks_ca
{
    public partial class welcome : Form
    {
        private stocks stocksForm;
        private Form1 newsForm;


        public welcome()
        {
            InitializeComponent();
            stocksForm = new stocks();
            newsForm = new Form1();

        }

        private void openNews_Click(object sender, EventArgs e)
        {
            if (newsForm == null || newsForm.IsDisposed)
            {
                newsForm = new Form1();
            }
            newsForm.Show();

        }

        private void openStocks_Click(object sender, EventArgs e)
        {
            if (stocksForm == null || stocksForm.IsDisposed)
            {
                stocksForm = new stocks();
            }
            stocksForm.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
