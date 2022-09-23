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
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
            readGrid();
        }

        public void readGrid()
        {

            DataSet ds = new DataSet();
            FuncionariosDAO funcionariosDAO = new FuncionariosDAO();
            MySqlDataAdapter da = funcionariosDAO.read();
            da.Fill(ds);
            dgvFunc.DataSource = ds;
            dgvFunc.DataMember = ds.Tables[0].TableName;

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                string nome = textBoxIdade.Text;
                int idade = int.Parse(textBoxNome.Text);
                int salario = int.Parse(textBoxSala.Text);
                int cpf = int.Parse(textBoxCPF.Text);
                string cidade = textBoxCid.Text;
                string cargo = textBoxCG.Text;

                FuncionariosDAO funcionariosDAO = new FuncionariosDAO();
                MessageBox.Show(funcionariosDAO.insert(new Funcionarios(id, nome, idade, cpf, cidade, salario, cargo)));

                readGrid();

            }
            catch (Exception)
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
                int salario = int.Parse(textBoxSala.Text);
                int cpf = int.Parse(textBoxCPF.Text);
                string cidade = textBoxCid.Text;
                string cargo = textBoxCG.Text;

                FuncionariosDAO funcionariosDAO = new FuncionariosDAO();
                MessageBox.Show(funcionariosDAO.update(new Funcionarios(id, nome, idade, cpf, cidade, salario, cargo)));

                readGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Invalida");
            }
        }

        private void buttonExc_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);

            FuncionariosDAO funcionariosDAO=new FuncionariosDAO();
            MessageBox.Show(funcionariosDAO.delete(id));

            readGrid();
        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Enabled = false;
            buttonSalvar.Enabled = false;
            DataGridViewRow row = dgvFunc.Rows[e.RowIndex];
            textBoxID.Text = row.Cells[0].Value.ToString();
            textBoxNome.Text = row.Cells[1].Value.ToString();
            textBoxIdade.Text = row.Cells[2].Value.ToString();
            textBoxSala.Text = row.Cells[5].Value.ToString();
            textBoxCPF.Text = row.Cells[3].Value.ToString();
            textBoxCid.Text = row.Cells[4].Value.ToString();
            textBoxCG.Text = row.Cells[6].Value.ToString();
        }
    }
}
