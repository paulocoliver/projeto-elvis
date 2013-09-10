using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trabalho.BLL;

namespace Trabalho.DesktopView
{
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            findAll();
        }

        private void findAll()
        {
            DepartamentoBLL bll = new DepartamentoBLL();
            dataGridView1.DataSource = bll.select();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtID.Text = "";
            txtDescricao.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Types.DepartamentoType type = new Types.DepartamentoType();
                    type.IdDepartamento = Convert.ToInt32(txtID.Text);

                    DepartamentoBLL itemBLL = new DepartamentoBLL();
                    itemBLL.excluir(type);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao excluir. Mensagem: " +
                        erro.Message, "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                findAll();
                LimparCampos();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Types.DepartamentoType type = new Types.DepartamentoType();
                type.Descricao = txtDescricao.Text;

                DepartamentoBLL itemBLL = new DepartamentoBLL();
                if (txtID.Text == "")
                {
                    txtID.Text = Convert.ToString(itemBLL.insert(type));
                }
                else
                {
                    type.IdDepartamento = Convert.ToInt32(txtID.Text);
                    itemBLL.alterar(type);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar. Mensagem: " +
                    erro.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            findAll();
        }
    }
}
