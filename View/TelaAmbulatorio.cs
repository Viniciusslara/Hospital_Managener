using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AtividadeClinica.Controller;
using AtividadeClinica.Model;

namespace AtividadeClinica
{
    public partial class TelaAmbulatorio : Form
    {
        public TelaAmbulatorio()
        {
            InitializeComponent();
            readGrid();
        }

        public void readGrid()
        {

            DataSet ds = new DataSet();
            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
            MySqlDataAdapter da = ambulatorioDAO.read();
            da.Fill(ds);
            dgvAmb.DataSource = ds;
            dgvAmb.DataMember = ds.Tables[0].TableName;

        }

        private void TelaAmbulatorio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxNroa.Text);
                int andar = int.Parse(textBoxAndar.Text);
                int cap = int.Parse(textBoxCap.Text);

                AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
                MessageBox.Show(ambulatorioDAO.insert(new Ambulatorio(id, andar, cap)));


            }catch (Exception){
                MessageBox.Show("Entrada invalidas");
            }

            readGrid();
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxNroa.Text);
                int andar = int.Parse(textBoxAndar.Text);
                int cap = int.Parse(textBoxCap.Text);

                AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
                MessageBox.Show(ambulatorioDAO.update(new Ambulatorio(id, andar, cap)));

            }
            catch (Exception)
            {
                MessageBox.Show("Entrada invalidas");
            }

            readGrid();

        }

        private void dgvAmb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAmb.Rows[e.RowIndex];
            textBoxNroa.Enabled = false;
            textBoxNroa.Text = row.Cells[0].Value.ToString();
            textBoxAndar.Text = row.Cells[1].Value.ToString();
            textBoxCap.Text = row.Cells[2].Value.ToString();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxNroa.Text);

                AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
                MessageBox.Show(ambulatorioDAO.delete(id));

            }
            catch (Exception)
            {
                MessageBox.Show("Entrada invalidas");
            }

            readGrid();

        }
    }
}
