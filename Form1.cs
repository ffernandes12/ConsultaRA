using ConsultaRA.Modelo;

namespace ConsultaRA
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
        }
        //primeiro isso
        private void EnviarControle()
        {
            Controle controle = new Controle(txbRa.Text);
            lblResul.Text = controle.Mensagem;
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void txbRa_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRa_Click(object sender, EventArgs e)
        {

        }

        private void lblra_Load(object sender, EventArgs e)
        {

        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            EnviarControle();

        }

        private void lblResul_Click(object sender, EventArgs e)
        {

        }
    }
}
