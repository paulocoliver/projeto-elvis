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
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            findAll();

            BLL.DepartamentoBLL depBLL = new BLL.DepartamentoBLL();
            cmbDepartamento.DataSource = depBLL.select();
            cmbDepartamento.DisplayMember = "Descricao";
            cmbDepartamento.ValueMember = "IdDepartamento";
        }

        private void findAll()
        {
            CargoBLL bll = new CargoBLL();
            dataGridView1.DataSource = bll.select();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbDepartamento.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            txtDescricao.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
                    Types.CargoType type = new Types.CargoType();
                    type.IdCargo = Convert.ToInt32(txtID.Text);

                    CargoBLL itemBLL = new CargoBLL();
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
                Types.CargoType type = new Types.CargoType();
                type.Descricao = txtDescricao.Text;
                type.IdDepartamento = Int32.Parse(cmbDepartamento.SelectedValue.ToString());
                
                CargoBLL itemBLL = new CargoBLL();
                if (txtID.Text == "")
                {
                    txtID.Text = Convert.ToString(itemBLL.insert(type));
                }
                else
                {
                    type.IdCargo = Convert.ToInt32(txtID.Text);
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
