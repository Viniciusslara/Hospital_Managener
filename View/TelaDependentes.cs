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
    public partial class TelaDependentes : Form
    {
        public TelaDependentes()
        {
            InitializeComponent();
            readGrid();
        }

        public void readGrid()
        {

            DataSet ds = new DataSet();
            DependentesDAO dependentesDAO = new DependentesDAO();   
            MySqlDataAdapter da =  dependentesDAO.read();
            da.Fill(ds);
            dgvDep.DataSource = ds;
            dgvDep.DataMember = ds.Tables[0].TableName;

        }

        private void dgvDep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Enabled = false;
            buttonSalvar.Enabled = false;
            DataGridViewRow row = dgvDep.Rows[e.RowIndex];
            textBoxID.Text = row.Cells[0].Value.ToString();
            textBoxFunc.Text = row.Cells[1].Value.ToString();
            textBoxNome.Text = row.Cells[2].Value.ToString();
            textBoxNasc.Text = row.Cells[3].Value.ToString();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                int idFunc = int.Parse(textBoxFunc.Text);
                string nome = textBoxNome.Text;
                DateOnly nasc = DateOnly.Parse(textBoxNasc.Text);

                DependentesDAO dependentesDAO = new DependentesDAO();
                MessageBox.Show(dependentesDAO.insert(new Dependentes(id, nome, nasc, idFunc)));

                readGrid();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Invalida");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy HH:mm:ss.ffffff";

            try
            {
                int id = int.Parse(textBoxID.Text);
                int idFunc = int.Parse(textBoxFunc.Text);
                string nome = textBoxNome.Text;
                DateOnly nasc = DateOnly.ParseExact(textBoxNasc.Text,format);

                DependentesDAO dependentesDAO = new DependentesDAO();
                MessageBox.Show(dependentesDAO.update(new Dependentes(id, nome, nasc, idFunc)));

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

            DependentesDAO dependentesDAO=new DependentesDAO();
            MessageBox.Show(dependentesDAO.delete(id));
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
