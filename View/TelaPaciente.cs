using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeClinica.Controller;
using AtividadeClinica.Model;
using MySql.Data.MySqlClient;

namespace AtividadeClinica
{
    public partial class TelaPaciente : Form
    {
        public TelaPaciente()
        {
            InitializeComponent();
            readGrid();
        }

        public void readGrid()
        {

            DataSet ds = new DataSet();
            PacientesDAO pacientesDAO = new PacientesDAO(); 
            MySqlDataAdapter da = pacientesDAO.read();
            da.Fill(ds);
            dgvPasc.DataSource = ds;
            dgvPasc.DataMember = ds.Tables[0].TableName;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e){

            try
            {
                int id = int.Parse(textBoxID.Text);
                string nome = textBoxNome.Text;
                int idade = int.Parse(textBoxIdade.Text);
                string cidade = textBoxCid.Text;
                int cpf = int.Parse(textBoxCPF.Text);
                string doenca = textBoxDoe.Text;

                PacientesDAO pacientesDAO=new PacientesDAO();
                MessageBox.Show(pacientesDAO.insert(new Paciente(id, nome, idade, cidade, cpf, doenca)));

                readGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Entradas Invalidas");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                string nome = textBoxNome.Text;
                int idade = int.Parse(textBoxIdade.Text);
                string cidade = textBoxCid.Text;
                int cpf = int.Parse(textBoxCPF.Text);
                string doenca = textBoxDoe.Text;

                PacientesDAO pacientesDAO = new PacientesDAO();
                MessageBox.Show(pacientesDAO.update(new Paciente(id, nome, idade, cidade, cpf, doenca)));

                readGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExc_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);

            PacientesDAO pacientesDAO=new PacientesDAO();
            MessageBox.Show(pacientesDAO.delete(id));

            readGrid();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPasc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Enabled = false;
            buttonSalvar.Enabled = false;
            DataGridViewRow row = dgvPasc.Rows[e.RowIndex];
            textBoxID.Text = row.Cells[0].Value.ToString();
            textBoxNome.Text = row.Cells[1].Value.ToString();
            textBoxIdade.Text = row.Cells[2].Value.ToString();
            textBoxCid.Text = row.Cells[3].Value.ToString();
            textBoxCPF.Text = row.Cells[4].Value.ToString();
            textBoxDoe.Text = row.Cells[5].Value.ToString();
        }
    }
}
