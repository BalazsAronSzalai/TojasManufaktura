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

namespace TojasManufaktura
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }
        public FrmMain()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = TojasGyar;";
            InitializeComponent();
        }

        private void btnTermeles_Click(object sender, EventArgs e)
        {
            // => new FrmTermeles(ConnectionString).ShowDialog();
        }

        private void btnStatisztika_Click(object sender, EventArgs e)
        {
           // => new FrmStatisztika(ConnectionString).ShowDialog();
        }
        

        private void btnKilepes_Click(object sender, EventArgs e)
        => this.Close();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pBNyul.ImageLocation = @"..\res\nyul.gif";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
