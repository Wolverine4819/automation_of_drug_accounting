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

namespace automation_of_drug_accounting_WF_csharp_
{
    public partial class Form3 : Form
    {

        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private bool newRowAdding = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void DataLoad()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Medicines]", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Medicines");

                dataGridView1.DataSource = dataSet.Tables["Medicines"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mydatabase; AttachDbFilename = |DataDirectory|\Database.mdf; Integrated Security = True");

            sqlConnection.Open();

            DataLoad();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit
            Form2 s = new Form2();
            s.Show();
            this.Hide();

        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //help
            Form4 s = new Form4();
            s.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
