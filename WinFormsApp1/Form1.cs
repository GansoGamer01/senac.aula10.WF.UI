namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //criar uma variavel de contexto do banco de dados //
        private UsuarioContext _context;

        public Form1()
        {
            InitializeComponent();

            // instanciei um objeto do contexto //
            _context = new UsuarioContext();

            // garantir que a base de dados sera criada //
            _context.Database.EnsureCreated();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // criar um usuario e atribuindo os valores
            var usuario = new Usuario
            {
                Email = txtEmail.Text,
                Nome = txtNome.Text,
                Senha = txtSenha.Text
            };
            // adicionar o usuario no contexto do banco
            _context.Usuarios.Add(usuario);

            // salvar as alterações do contexto
            _context.SaveChanges();

            MessageBox.Show("Usuario salvo com sucesso");
            limparCampos();
        }
        // metodo para limpar os campos na tela
        private void limparCampos() 
        {
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtNome.Focus();
        }
    }
}
