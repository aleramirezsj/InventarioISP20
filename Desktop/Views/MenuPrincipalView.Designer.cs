namespace Desktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalView));
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            SubMenuArticulos = new FontAwesome.Sharp.IconMenuItem();
            SubmenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            subMenuClientesSupabase = new FontAwesome.Sharp.IconMenuItem();
            subMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            SubMenuPruebasGemini = new FontAwesome.Sharp.IconMenuItem();
            clientesApiViewSubMenu = new ToolStripMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            subMenuListadoClientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            SubMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            BarraDeHerramientas = new ToolStrip();
            BtnToolClientes = new FontAwesome.Sharp.IconToolStripButton();
            BtnImprimirClientes = new FontAwesome.Sharp.IconToolStripButton();
            toolStripButton1 = new ToolStripButton();
            SubmenuClientesxlocalidad = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            BarraDeHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1244, 44);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SubMenuArticulos, SubmenuCategorias, subMenuClientesSupabase, subMenuClientes, SubMenuPruebasGemini, clientesApiViewSubMenu });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(148, 38);
            iconMenuItem1.Text = "Principal";
            // 
            // SubMenuArticulos
            // 
            SubMenuArticulos.IconChar = FontAwesome.Sharp.IconChar.Bars;
            SubMenuArticulos.IconColor = Color.Black;
            SubMenuArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuArticulos.Name = "SubMenuArticulos";
            SubMenuArticulos.Size = new Size(482, 44);
            SubMenuArticulos.Text = "Articulos";
            SubMenuArticulos.Click += SubMenuArticulos_Click;
            // 
            // SubmenuCategorias
            // 
            SubmenuCategorias.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            SubmenuCategorias.IconColor = Color.Black;
            SubmenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuCategorias.Name = "SubmenuCategorias";
            SubmenuCategorias.Size = new Size(482, 44);
            SubmenuCategorias.Text = "Categorías";
            SubmenuCategorias.Click += SubmenuCategorias_Click;
            // 
            // subMenuClientesSupabase
            // 
            subMenuClientesSupabase.IconChar = FontAwesome.Sharp.IconChar.User;
            subMenuClientesSupabase.IconColor = Color.Black;
            subMenuClientesSupabase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuClientesSupabase.Name = "subMenuClientesSupabase";
            subMenuClientesSupabase.Size = new Size(482, 44);
            subMenuClientesSupabase.Text = "Clientes con paquete Supabase";
            subMenuClientesSupabase.Click += subMenuClientesSupabase_Click;
            // 
            // subMenuClientes
            // 
            subMenuClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            subMenuClientes.IconColor = Color.Black;
            subMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuClientes.Name = "subMenuClientes";
            subMenuClientes.Size = new Size(482, 44);
            subMenuClientes.Text = "Clientes";
            subMenuClientes.Click += subMenuClientes_Click;
            // 
            // SubMenuPruebasGemini
            // 
            SubMenuPruebasGemini.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuPruebasGemini.IconColor = Color.Black;
            SubMenuPruebasGemini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuPruebasGemini.Name = "SubMenuPruebasGemini";
            SubMenuPruebasGemini.Size = new Size(482, 44);
            SubMenuPruebasGemini.Text = "Pruebas con IA - Gemini";
            SubMenuPruebasGemini.Click += SubMenuPruebasGemini_Click;
            // 
            // clientesApiViewSubMenu
            // 
            clientesApiViewSubMenu.Name = "clientesApiViewSubMenu";
            clientesApiViewSubMenu.Size = new Size(482, 44);
            clientesApiViewSubMenu.Text = "Clientes Api View";
            clientesApiViewSubMenu.Click += clientesApiViewSubMenu_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { subMenuListadoClientes, SubmenuClientesxlocalidad });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(151, 38);
            iconMenuItem3.Text = "Reportes";
            // 
            // subMenuListadoClientes
            // 
            subMenuListadoClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuListadoClientes.IconColor = Color.Black;
            subMenuListadoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuListadoClientes.Name = "subMenuListadoClientes";
            subMenuListadoClientes.Size = new Size(496, 44);
            subMenuListadoClientes.Text = "Listado de clientes";
            subMenuListadoClientes.Click += subMenuListadoClientes_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(103, 38);
            iconMenuItem2.Text = "Salir";
            // 
            // SubMenuSalirDelSistema
            // 
            SubMenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            SubMenuSalirDelSistema.IconColor = Color.Black;
            SubMenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalirDelSistema.Name = "SubMenuSalirDelSistema";
            SubMenuSalirDelSistema.Size = new Size(319, 44);
            SubMenuSalirDelSistema.Text = "Salir del sistema";
            SubMenuSalirDelSistema.Click += SubMenuSalirDelSistema_Click;
            // 
            // BarraDeHerramientas
            // 
            BarraDeHerramientas.ImageScalingSize = new Size(32, 32);
            BarraDeHerramientas.Items.AddRange(new ToolStripItem[] { BtnToolClientes, BtnImprimirClientes, toolStripButton1 });
            BarraDeHerramientas.Location = new Point(0, 44);
            BarraDeHerramientas.Name = "BarraDeHerramientas";
            BarraDeHerramientas.Size = new Size(1244, 90);
            BarraDeHerramientas.TabIndex = 3;
            BarraDeHerramientas.Text = "toolStrip1";
            // 
            // BtnToolClientes
            // 
            BtnToolClientes.IconChar = FontAwesome.Sharp.IconChar.PersonBreastfeeding;
            BtnToolClientes.IconColor = Color.Black;
            BtnToolClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnToolClientes.ImageScaling = ToolStripItemImageScaling.None;
            BtnToolClientes.ImageTransparentColor = Color.Magenta;
            BtnToolClientes.Name = "BtnToolClientes";
            BtnToolClientes.Size = new Size(103, 84);
            BtnToolClientes.Text = "Clientes";
            BtnToolClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnToolClientes.Click += BtnToolClientes_Click;
            // 
            // BtnImprimirClientes
            // 
            BtnImprimirClientes.IconChar = FontAwesome.Sharp.IconChar.Print;
            BtnImprimirClientes.IconColor = Color.Black;
            BtnImprimirClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnImprimirClientes.ImageScaling = ToolStripItemImageScaling.None;
            BtnImprimirClientes.ImageTransparentColor = Color.Magenta;
            BtnImprimirClientes.Name = "BtnImprimirClientes";
            BtnImprimirClientes.Size = new Size(196, 84);
            BtnImprimirClientes.Text = "Imprimir clientes";
            BtnImprimirClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnImprimirClientes.Click += BtnImprimirClientes_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 84);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // SubmenuClientesxlocalidad
            // 
            SubmenuClientesxlocalidad.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuClientesxlocalidad.IconColor = Color.Black;
            SubmenuClientesxlocalidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuClientesxlocalidad.Name = "SubmenuClientesxlocalidad";
            SubmenuClientesxlocalidad.Size = new Size(496, 44);
            SubmenuClientesxlocalidad.Text = "Clientes agrupados por localidad";
            SubmenuClientesxlocalidad.Click += SubmenuClientesxlocalidad_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 681);
            Controls.Add(BarraDeHerramientas);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MenuPrincipalView";
            Text = "Sistema de Inventario ISP20 - 2do año TSDS";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            BarraDeHerramientas.ResumeLayout(false);
            BarraDeHerramientas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem SubMenuArticulos;
        private FontAwesome.Sharp.IconMenuItem SubmenuCategorias;
        private FontAwesome.Sharp.IconMenuItem subMenuClientes;
        private FontAwesome.Sharp.IconMenuItem subMenuClientesSupabase;
        private FontAwesome.Sharp.IconMenuItem SubMenuPruebasGemini;
        private ToolStripMenuItem clientesApiViewSubMenu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem subMenuListadoClientes;
        private ToolStrip BarraDeHerramientas;
        private FontAwesome.Sharp.IconToolStripButton BtnToolClientes;
        private FontAwesome.Sharp.IconToolStripButton BtnImprimirClientes;
        private ToolStripButton toolStripButton1;
        private FontAwesome.Sharp.IconMenuItem SubmenuClientesxlocalidad;
    }
}
