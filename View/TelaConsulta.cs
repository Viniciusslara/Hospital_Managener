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
    public partial class TelaConsulta : Form
    {
        public TelaConsulta()
        {
            InitializeComponent();
            readGrid();
        }

        public void readGrid()
        {

            DataSet ds = new DataSet();
            ConsultaDAO consultaDAO = new ConsultaDAO();    
            MySqlDataAdapter da = consultaDAO.read();
            da.Fill(ds);
            dgvCons.DataSource = ds;
            dgvCons.DataMember = ds.Tables[0].TableName;

        }


        private void dgvCons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            buttonSalvar.Enabled = false;
            DataGridViewRow row = dgvCons.Rows[e.RowIndex];
            textBoxIDMed.Text = row.Cells[1].Value.ToString();
            textBoxIDPac.Text = row.Cells[3].Value.ToString();
            textBoxData.Text = row.Cells[4].Value.ToString();
            textBoxHora.Text = row.Cells[5].Value.ToString();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            int med = int.Parse(textBoxIDMed.Text);
            int pasc = int.Parse(textBoxIDPac.Text);
            DateOnly data = DateOnly.Parse(textBoxData.Text);
            TimeOnly hora = TimeOnly.Parse(textBoxHora.Text);

            ConsultaDAO consultaDAO = new ConsultaDAO();
            MessageBox.Show(consultaDAO.insert(new Consulta(data, hora, pasc, med)));

            readGrid();
        }
    }
}
