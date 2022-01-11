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
    public partial class FrmTermeles : Form
    {
        public string ConnectionString { get; set; }
        public FrmTermeles(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmTermeles_Load(object sender, EventArgs e)
        {
            FillDGV();
            FillCB();
        }

        private void FillDGV()
        {
            //dgv.Rows.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
               /* var r = new SqlCommand(
                    
                )
                    .ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(
                        r.GetDateTime(0).ToString("yyyy-MM-dd"),
                        r[1],
                        r[2] + " db",
                        r[3]);
                }*/

                conn.Close();
            }
        }
        private void FillCB()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    "SELECT Szin FROM Tojas;", conn)
                    .ExecuteReader();
                while (r.Read()) cBTojas.Items.Add(r[0]);
                r.Close();
                r = new SqlCommand(
                    "SELECT Nev FROM Nyul;", conn)
                    .ExecuteReader();
                while (r.Read()) cBMunkas.Items.Add(r[0]);
                conn.Close();
            }
        }

        private void BtnFelvetel_Click(object sender, EventArgs e)
        {
            string datum = dTPDatum.Value.ToString("yyyy-MM-dd");
            string tojasId = $"{cBTojas.SelectedIndex - 1}";
            string munkasId = $"{cBMunkas.SelectedIndex + 1}";
            string mennyiseg = $"{nUDMenny.Value}";

            string szin = cBTojas.Text;
            string munkas = cBMunkas.Text;

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                try
                {
                    string errorMsg = "";
                    if (string.IsNullOrWhiteSpace(szin))
                        errorMsg += "Egy tojásnak kell hogy legyen színe!";
                    if (string.IsNullOrWhiteSpace(munkas))
                        errorMsg += "Olyan nincs, hogy nem dolgozott a tojáson senki!";
                    if (int.Parse(mennyiseg) == 0)
                        errorMsg += "Kell hogy legyen mennyiség!";
                    if (!string.IsNullOrEmpty(errorMsg))
                        throw new Exception(errorMsg);

                    new SqlCommand(
                        "INSERT INTO Termeles VALUES" +
                        $"('{datum}', {tojasId}, {munkasId}, {mennyiseg});", conn)
                        .ExecuteReader();
                    MessageBox.Show("Az adatrögzítés sikeresen lezajlott!");
                    FillDGV();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

        }
    }
}