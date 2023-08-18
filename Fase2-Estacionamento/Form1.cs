using Fase2_Aula08Estoque;
using System.Reflection.Metadata;

namespace Fase2_Estacionamento
{
    public partial class Form1 : Form
    {
        List<string> estacionar = new List<string>();

        Utilidades utilidades= new Utilidades();

        public Form1()
        {
            InitializeComponent();
        }

        //minhas funções
        void estacionamento()
        {
            

            if (utilidades.textBoxEstaVazio(txtDigitar) == true)

            {
                MessageBox.Show("Campo está vazio!");
                return;
            }
            

            string nome = txtDigitar.Text;

            estacionar.Add(nome);

            
        }

        void limparTexto()
        {
            txtDigitar.Clear();
        }

       

        

        void atualizarInter()
        {
          listar.Items.Add(txtDigitar.Text);

           

        }

        void verificar()
        {
            lblContagem.Text = estacionar.Count.ToString();
        }

        void removerList()
        {
            //estacionar.Remove(txtDigitar.Text);


            listar.Items.Remove(txtDigitar.Text);


        }

       






        //meu codigo



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
           
            estacionamento();
            atualizarInter();
            verificar();
            limparTexto();


        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            removerList();
           
          
        }

        private void lblContagem_Click(object sender, EventArgs e)
        {
            
        }

        private void listar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}