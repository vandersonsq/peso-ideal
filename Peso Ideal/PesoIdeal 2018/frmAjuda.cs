using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal_2018
{
    public partial class frmAjuda : Form
    {
        public frmAjuda()
        {
            InitializeComponent();
        }
        #region--------BOTÃO SAIR
        //Caso queira sair do programa
        public void btfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja sair do programa ?"), "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                //Continua na tela de ajuda
            }
        }
        #endregion--------FIM
        #region--------ALTERA COR DO BOTÕES
        //Alterar cor do botão ao passar mouse por cima
        private void btfechar_MouseMove(object sender, MouseEventArgs e)
        {
            btfechar.BackColor = Color.Red;
        }
        private void btfechar_MouseLeave(object sender, EventArgs e)
        {
            btfechar.BackColor = Color.GhostWhite;
        }
        private void btminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btminimizar.BackColor = Color.Cyan;
        }
        private void btminimizar_MouseLeave(object sender, EventArgs e)
        {
            btminimizar.BackColor = Color.GhostWhite;
        }
        #endregion--------
        #region--------FECHA JANELA DE AJUDA E VOLTA PARA O MENU
        //Fecha o formulário de ajuda e volta para o menu
        private void btminimizar_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count ==0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    formAberto.Show();
                    break;
                }
                Close();
            }
        }
        #endregion--------
        #region--------CAMPOS NÃO UTILIZADOS
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btminimizar_Click(object sender, EventArgs e)
        {
        }
        private void frmAjuda_Load(object sender, EventArgs e)
        {

        }
        #endregion--------FIM
    }
}
