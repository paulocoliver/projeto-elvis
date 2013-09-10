using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho.DesktopView
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolDepartamentos_Click(object sender, EventArgs e)
        {
            Departamento view = new Departamento();
            view.ShowDialog();
        }

        private void toolCargos_Click(object sender, EventArgs e)
        {
            Cargo view = new Cargo();
            view.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void empresarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastrarEmpresario view = new formCadastrarEmpresario();
            view.ShowDialog();
        }
    }
}
