namespace AtividadeClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAmb_Click(object sender, EventArgs e)
        {
            new TelaAmbulatorio().Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPac_Click(object sender, EventArgs e)
        {
            new TelaPaciente().Show();
        }

        private void buttonDep_Click(object sender, EventArgs e)
        {
            new TelaDependentes().Show();
        }

        private void buttonFun_Click(object sender, EventArgs e)
        {
            new TelaFuncionario().Show();
        }

        private void ButtonMed_Click(object sender, EventArgs e)
        {
            new TelaMedicos().Show();
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            new TelaConsulta().Show();
        }
    }
}