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
    public partial class FrmStatisztika : Form
    {
        public string ConnectionString { get; private set; }
        public FrmStatisztika(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmStatisztika_Load(object sender, EventArgs e)
        {
            FillCB();
            FillDGV();
        }

        private void FillDGV()
        {
            
        }

        private void FillCB()
        {
            
        }

        private void FillTB()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                if (dgv.Rows.Count != 0)
                {
                    /*var r = new SqlCommand(
                        
                        )
                        .ExecuteReader();*/
                }
            }
        }
    }
}