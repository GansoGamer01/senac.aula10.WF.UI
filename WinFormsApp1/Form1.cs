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
    }
}
