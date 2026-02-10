namespace fiap_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hellow World");
            if(txtNome.Text == "FIAP")
            {
                Menu telaMenu = new Menu();
                telaMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário inválido", "FIAP");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Estou estudando C#", "FIAP");
        }
    }
}
