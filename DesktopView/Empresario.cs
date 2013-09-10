using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho.BLL;

namespace Trabalho.DesktopView
{
    public partial class formCadastrarEmpresario : Form
    {
        public formCadastrarEmpresario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshList();
            PaisBLL pais = new PaisBLL();

            Types.PaisesType lista  = pais.select();
            Types.PaisType emptyRow = new Types.PaisType();
            emptyRow.Descricao = "Selecione um Pais";

            lista.Insert(0, emptyRow);
            cbPais.DataSource = lista;
            cbPais.ValueMember   = "idPais";
            cbPais.DisplayMember = "Descricao";
        }

        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            cbEstado.Enabled = false;
            cbCidade.Enabled = false;
            cbBairro.Enabled = false;
            cbEstado.DataSource = null;
            cbCidade.DataSource = null;
            cbBairro.DataSource = null;
            
            int idPais;
            try{ 
                idPais = Int32.Parse(cbPais.SelectedValue.ToString());               
            }catch (Exception){
                return;
            }
      
            cbEstado.Text    = "Carregando Estados...";
            EstadoBLL estado = new EstadoBLL();
            
            Types.EstadosType lista = estado.select(idPais);
            Types.EstadoType emptyRow = new Types.EstadoType();
            emptyRow.Descricao = "Selecione um Estado";

            lista.Insert(0, emptyRow);
            cbEstado.DataSource     = lista;
            cbEstado.ValueMember    = "idEstado";
            cbEstado.DisplayMember  = "Descricao";
            cbEstado.SelectedIndex  = 0;     
            cbEstado.Enabled = true;
        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            cbCidade.Enabled = false;
            cbBairro.Enabled = false;
            cbCidade.DataSource = null;
            cbBairro.DataSource = null;

            int idEstado;
            try{
                idEstado = Int32.Parse(cbEstado.SelectedValue.ToString());
            }catch (Exception){
                return;
            }
            cbCidade.Text = "Carregando Cidades...";
            CidadeBLL cidade = new CidadeBLL();
            Types.cidadesType lista = cidade.select(idEstado);
            Types.cidadeType emptyRow = new Types.cidadeType();
            emptyRow.Descricao = "Selecione uma Cidade";

            lista.Insert(0, emptyRow);
            cbCidade.DataSource     = lista;
            cbCidade.ValueMember    = "idCidade";
            cbCidade.DisplayMember  = "Descricao";
            cbCidade.SelectedIndex  = 0;
            cbCidade.Enabled = true; 
        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBairro.Enabled = false;
            cbBairro.DataSource = null;

            int idCidade;
            try
            {
                idCidade = Int32.Parse(cbCidade.SelectedValue.ToString());
            }
            catch (Exception)
            {
                return;
            }
            cbBairro.Text = "Carregando Bairros...";
            BairroBLL bairro = new BairroBLL();
            Types.bairrosType lista   = bairro.select(idCidade);
            Types.bairroType emptyRow = new Types.bairroType();
            emptyRow.Descricao = "Selecione um Bairro";

            lista.Insert(0, emptyRow);
            cbBairro.DataSource = lista;
            cbBairro.ValueMember = "idBairro";
            cbBairro.DisplayMember = "Descricao";
            cbBairro.SelectedIndex = 0;
            cbBairro.Enabled = true; 
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try {
              
                Types.EmpresarioType empresario = new Types.EmpresarioType();
               
                empresario.Nome      = txtNome.Text;
                empresario.Sobrenome = txtSobrenome.Text;
                empresario.Email     = txtEmail.Text;
                empresario.CPF       = txtCPF.Text;
                empresario.RG        = txtRG.Text;
                empresario.Endereco  = txtEndereco.Text;
                empresario.idBairro  = cbBairro.SelectedValue.ToString();

                EmpresarioBLL bll = new EmpresarioBLL();
                bll.insert(empresario);
                refreshList();
            }catch(Exception erro){
                MessageBox.Show(erro.Message);
            }
        }

        public void refreshList()
        {
            EmpresarioBLL empBLL = new EmpresarioBLL();
            tbEmpresario.DataSource = empBLL.select();

            tbEmpresario.Columns.Remove("idBairro");
            tbEmpresario.Columns.Remove("idEmpresario");
        }
    }
}
