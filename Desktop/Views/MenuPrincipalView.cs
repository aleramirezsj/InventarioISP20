using Desktop.Views;

namespace Desktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        #region código del botón saludo
        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, bienvenido a mi aplicación de escritorio!");
        }
        #endregion

        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuArticulos_Click(object sender, EventArgs e)
        {
            ArticulosView articulosView = new();
            articulosView.MdiParent = this;
            articulosView.Show();
        }

        private void SubmenuCategorias_Click(object sender, EventArgs e)
        {
            CategoriasView categoriasView = new();
            categoriasView.ShowDialog();
        }

        private void subMenuClientes_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new();
            clientesView.ShowDialog();
        }

        private void subMenuClientesSupabase_Click(object sender, EventArgs e)
        {
            ClientesSupabaseView clientesSupabaseView = new();
            clientesSupabaseView.ShowDialog();
        }
    }
}
