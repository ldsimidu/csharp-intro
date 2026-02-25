namespace fiap_csharp
{
    public partial class Form1 : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                Aluno aluno = new Aluno();
                aluno.id = int.Parse(txtCodigo.Text);
                aluno.nome = txtNome.Text;
                //aluno.RM = txtRM.Text; // RM é somente leitura, não pode ser atribuído

                listaAlunos.Add(aluno);

                txtCodigo.Text = string.Empty;
                txtCodigo.Text = "";

                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Código inválido. Por favor, insira um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Estou estudando C#", "FIAP");
        }
    }
}
