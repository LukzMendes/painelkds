using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();

            this.Grafico.Series["ChartLinea"].Points.AddXY("SEG", 10);
            this.Grafico.Series["ChartLinea"].Points.AddXY("TER", 20);
            this.Grafico.Series["ChartLinea"].Points.AddXY("QUA", 30);
            this.Grafico.Series["ChartLinea"].Points.AddXY("QUI", 40);
            this.Grafico.Series["ChartLinea"].Points.AddXY("SEX", 50);
            this.Grafico.Series["ChartLinea"].Points.AddXY("SAB", 40);
            this.Grafico.Series["ChartLinea"].Points.AddXY("DOM", 20);
        }

        private void Grafico_Click(object sender, EventArgs e)
        {

        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.pedidos_button.Hide();
            this.PanelChart.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.PanelChart.Hide();
            this.pedidos_button.Show();


        }

        private void pn_pedidos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void textTag_Click(object sender, EventArgs e)
        
            this.textTag.ResetText();*/
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painel_clientes(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.PanelChart.Hide();
            this.pedidos_button.Hide();
            this.pn_pedidos.Show();
        }

        private void painelCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
