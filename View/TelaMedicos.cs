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
    public partial class TelaMedicos : Form
    {
        public TelaMedicos()
        {
            InitializeComponent();
            readGrid();
        }

        public void readGrid()
        {

            DataSet ds = new DataSet();
            MedicosDAO medicosDAO = new MedicosDAO();   
            MySqlDataAdapter da = medicosDAO.read();
            da.Fill(ds);
            dgvMed.DataSource = ds;
            dgvMed.DataMember = ds.Tables[0].TableName;

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                string nome = textBoxNome.Text;
                int idade = int.Parse(textBoxIdade.Text);
                int nroa = int.Parse(textBoxNroa.Text);
                int cpf = int.Parse(textBoxCPF.Text);
                string cidade = textBoxCid.Text;
                string especialidade = textBoxEspc.Text;

                MedicosDAO medicosDAO = new MedicosDAO();
                MessageBox.Show(medicosDAO.insert(new Medicos(id,nome,idade,especialidade,cidade,cpf,nroa)));

                readGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Entrada Invalida");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                string nome = textBoxNome.Text;
                int idade = int.Parse(textBoxIdade.Text);
                int nroa = int.Parse(textBoxNroa.Text);
                int cpf = int.Parse(textBoxCPF.Text);
                string cidade = textBoxCid.Text;
                string especialidade = textBoxEspc.Text;

                MedicosDAO medicosDAO = new MedicosDAO();
                MessageBox.Show(medicosDAO.update(new Medicos(id, nome, idade, especialidade, cidade, cpf, nroa)));

                readGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Entrada Invalida");
            }
        }

        private void buttonExc_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);

            MedicosDAO medicosDAO=new MedicosDAO();
            MessageBox.Show(medicosDAO.delete(id));

            readGrid();
        }

        private void dgvMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Enabled = false;
            buttonSalvar.Enabled = false;
            DataGridViewRow row = dgvMed.Rows[e.RowIndex];
            textBoxID.Text = row.Cells[0].Value.ToString();
            textBoxNroa.Text = row.Cells[1].Value.ToString();
            textBoxNome.Text = row.Cells[2].Value.ToString();  
            textBoxIdade.Text = row.Cells[3].Value.ToString();
            textBoxEspc.Text = row.Cells[4].Value.ToString();
            textBoxCPF.Text = row.Cells[5].Value.ToString();
            textBoxCid.Text = row.Cells[6].Value.ToString();
        }
    }
}
