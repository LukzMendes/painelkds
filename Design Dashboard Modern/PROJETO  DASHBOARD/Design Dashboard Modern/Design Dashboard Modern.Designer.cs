namespace Design_Dashboard_Modern
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        ///Limpe os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se recursos gerenciados devem ser descartados; caso contrário.</false>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cliente_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pedidos_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.conf_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboard_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.pn_pedidos = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.pn_pedidos.SuspendLayout();
            this.PanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.DimGray;
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1386, 38);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTop_Paint);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1297, 3);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 26);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1261, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 26);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1297, 3);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 26);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1333, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 26);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEEP SUPORTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(20, 3);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.Black;
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.SidebarWrapper.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 38);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(226, 750);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.Black;
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.cliente_button);
            this.Sidebar.Controls.Add(this.pedidos_button);
            this.Sidebar.Controls.Add(this.conf_button);
            this.Sidebar.Controls.Add(this.dashboard_button);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.Black;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Black;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.Black;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Black;
            this.Sidebar.Location = new System.Drawing.Point(10, 39);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(210, 672);
            this.Sidebar.TabIndex = 0;
            // 
            // cliente_button
            // 
            this.cliente_button.Activecolor = System.Drawing.Color.Transparent;
            this.cliente_button.BackColor = System.Drawing.Color.Transparent;
            this.cliente_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cliente_button.BorderRadius = 0;
            this.cliente_button.ButtonText = "           CLIENTES";
            this.cliente_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.cliente_button, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.cliente_button, BunifuAnimatorNS.DecorationType.None);
            this.cliente_button.DisabledColor = System.Drawing.Color.Gray;
            this.cliente_button.Iconcolor = System.Drawing.Color.Transparent;
            this.cliente_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("cliente_button.Iconimage")));
            this.cliente_button.Iconimage_right = null;
            this.cliente_button.Iconimage_right_Selected = null;
            this.cliente_button.Iconimage_Selected = null;
            this.cliente_button.IconMarginLeft = 0;
            this.cliente_button.IconMarginRight = 0;
            this.cliente_button.IconRightVisible = true;
            this.cliente_button.IconRightZoom = 0D;
            this.cliente_button.IconVisible = true;
            this.cliente_button.IconZoom = 50D;
            this.cliente_button.IsTab = false;
            this.cliente_button.Location = new System.Drawing.Point(4, 192);
            this.cliente_button.Name = "cliente_button";
            this.cliente_button.Normalcolor = System.Drawing.Color.Transparent;
            this.cliente_button.OnHovercolor = System.Drawing.Color.Transparent;
            this.cliente_button.OnHoverTextColor = System.Drawing.Color.White;
            this.cliente_button.selected = false;
            this.cliente_button.Size = new System.Drawing.Size(252, 51);
            this.cliente_button.TabIndex = 12;
            this.cliente_button.Text = "           CLIENTES";
            this.cliente_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cliente_button.Textcolor = System.Drawing.Color.LightGray;
            this.cliente_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cliente_button.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // pedidos_button
            // 
            this.pedidos_button.Activecolor = System.Drawing.Color.Transparent;
            this.pedidos_button.BackColor = System.Drawing.Color.Transparent;
            this.pedidos_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pedidos_button.BorderRadius = 0;
            this.pedidos_button.ButtonText = "           PEDIDOS";
            this.pedidos_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.pedidos_button, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pedidos_button, BunifuAnimatorNS.DecorationType.None);
            this.pedidos_button.DisabledColor = System.Drawing.Color.Gray;
            this.pedidos_button.Iconcolor = System.Drawing.Color.Transparent;
            this.pedidos_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("pedidos_button.Iconimage")));
            this.pedidos_button.Iconimage_right = null;
            this.pedidos_button.Iconimage_right_Selected = null;
            this.pedidos_button.Iconimage_Selected = null;
            this.pedidos_button.IconMarginLeft = 0;
            this.pedidos_button.IconMarginRight = 0;
            this.pedidos_button.IconRightVisible = true;
            this.pedidos_button.IconRightZoom = 0D;
            this.pedidos_button.IconVisible = true;
            this.pedidos_button.IconZoom = 50D;
            this.pedidos_button.IsTab = false;
            this.pedidos_button.Location = new System.Drawing.Point(2, 135);
            this.pedidos_button.Name = "pedidos_button";
            this.pedidos_button.Normalcolor = System.Drawing.Color.Transparent;
            this.pedidos_button.OnHovercolor = System.Drawing.Color.Transparent;
            this.pedidos_button.OnHoverTextColor = System.Drawing.Color.White;
            this.pedidos_button.selected = false;
            this.pedidos_button.Size = new System.Drawing.Size(252, 51);
            this.pedidos_button.TabIndex = 10;
            this.pedidos_button.Text = "           PEDIDOS";
            this.pedidos_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pedidos_button.Textcolor = System.Drawing.Color.LightGray;
            this.pedidos_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pedidos_button.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // conf_button
            // 
            this.conf_button.Activecolor = System.Drawing.Color.Transparent;
            this.conf_button.BackColor = System.Drawing.Color.Transparent;
            this.conf_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.conf_button.BorderRadius = 0;
            this.conf_button.ButtonText = "          CONFIGURAÇÕES";
            this.conf_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.conf_button, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.conf_button, BunifuAnimatorNS.DecorationType.None);
            this.conf_button.DisabledColor = System.Drawing.Color.Gray;
            this.conf_button.Iconcolor = System.Drawing.Color.Transparent;
            this.conf_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("conf_button.Iconimage")));
            this.conf_button.Iconimage_right = null;
            this.conf_button.Iconimage_right_Selected = null;
            this.conf_button.Iconimage_Selected = null;
            this.conf_button.IconMarginLeft = 0;
            this.conf_button.IconMarginRight = 0;
            this.conf_button.IconRightVisible = true;
            this.conf_button.IconRightZoom = 0D;
            this.conf_button.IconVisible = true;
            this.conf_button.IconZoom = 50D;
            this.conf_button.IsTab = false;
            this.conf_button.Location = new System.Drawing.Point(4, 240);
            this.conf_button.Name = "conf_button";
            this.conf_button.Normalcolor = System.Drawing.Color.Transparent;
            this.conf_button.OnHovercolor = System.Drawing.Color.Transparent;
            this.conf_button.OnHoverTextColor = System.Drawing.Color.White;
            this.conf_button.selected = false;
            this.conf_button.Size = new System.Drawing.Size(252, 51);
            this.conf_button.TabIndex = 9;
            this.conf_button.Text = "          CONFIGURAÇÕES";
            this.conf_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conf_button.Textcolor = System.Drawing.Color.LightGray;
            this.conf_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // dashboard_button
            // 
            this.dashboard_button.Activecolor = System.Drawing.Color.Transparent;
            this.dashboard_button.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard_button.BorderRadius = 0;
            this.dashboard_button.ButtonText = "           DASHBOARD";
            this.dashboard_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.dashboard_button, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.dashboard_button, BunifuAnimatorNS.DecorationType.None);
            this.dashboard_button.DisabledColor = System.Drawing.Color.Gray;
            this.dashboard_button.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboard_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboard_button.Iconimage")));
            this.dashboard_button.Iconimage_right = null;
            this.dashboard_button.Iconimage_right_Selected = null;
            this.dashboard_button.Iconimage_Selected = null;
            this.dashboard_button.IconMarginLeft = 0;
            this.dashboard_button.IconMarginRight = 0;
            this.dashboard_button.IconRightVisible = true;
            this.dashboard_button.IconRightZoom = 0D;
            this.dashboard_button.IconVisible = true;
            this.dashboard_button.IconZoom = 50D;
            this.dashboard_button.IsTab = false;
            this.dashboard_button.Location = new System.Drawing.Point(0, 78);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Normalcolor = System.Drawing.Color.Transparent;
            this.dashboard_button.OnHovercolor = System.Drawing.Color.Transparent;
            this.dashboard_button.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboard_button.selected = false;
            this.dashboard_button.Size = new System.Drawing.Size(252, 51);
            this.dashboard_button.TabIndex = 8;
            this.dashboard_button.Text = "           DASHBOARD";
            this.dashboard_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_button.Textcolor = System.Drawing.Color.LightGray;
            this.dashboard_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dashboard_button.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gestor de pedidos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Wrapper.Controls.Add(this.pn_pedidos);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Location = new System.Drawing.Point(226, 35);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1160, 753);
            this.Wrapper.TabIndex = 2;
            // 
            // pn_pedidos
            // 
            this.pn_pedidos.Controls.Add(this.PanelChart);
            this.pn_pedidos.Controls.Add(this.label5);
            this.AnimacionSidebarBack.SetDecoration(this.pn_pedidos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pn_pedidos, BunifuAnimatorNS.DecorationType.None);
            this.pn_pedidos.Location = new System.Drawing.Point(0, 0);
            this.pn_pedidos.Name = "pn_pedidos";
            this.pn_pedidos.Size = new System.Drawing.Size(1704, 1452);
            this.pn_pedidos.TabIndex = 18;
            this.pn_pedidos.Paint += new System.Windows.Forms.PaintEventHandler(this.painelCliente_Paint);
            // 
            // PanelChart
            // 
            this.PanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.PanelChart.Controls.Add(this.label3);
            this.PanelChart.Controls.Add(this.Grafico);
            this.AnimacionSidebarBack.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.PanelChart.Location = new System.Drawing.Point(6, 6);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1183, 714);
            this.PanelChart.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(90, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "ÚLTIMA SEMANA";
            // 
            // Grafico
            // 
            this.Grafico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Grafico.BorderlineWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea1);
            this.AnimacionSidebarBack.SetDecoration(this.Grafico, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Grafico, BunifuAnimatorNS.DecorationType.None);
            this.Grafico.IsSoftShadows = false;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Grafico.Legends.Add(legend1);
            this.Grafico.Location = new System.Drawing.Point(30, 103);
            this.Grafico.Name = "Grafico";
            this.Grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DarkGreen;
            series1.Legend = "Legend1";
            series1.Name = "ChartLinea";
            this.Grafico.Series.Add(series1);
            this.Grafico.Size = new System.Drawing.Size(1022, 553);
            this.Grafico.TabIndex = 1;
            this.Grafico.Text = "chart1";
            this.Grafico.Click += new System.EventHandler(this.Grafico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(90, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "PEDIDOS";
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this.PanelChart;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.pn_pedidos.ResumeLayout(false);
            this.pn_pedidos.PerformLayout();
            this.PanelChart.ResumeLayout(false);
            this.PanelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton cliente_button;
        private Bunifu.Framework.UI.BunifuFlatButton pedidos_button;
        private Bunifu.Framework.UI.BunifuFlatButton conf_button;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard_button;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private System.Windows.Forms.Panel PanelChart;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel pn_pedidos;
        private System.Windows.Forms.Label label5;
    }
}

