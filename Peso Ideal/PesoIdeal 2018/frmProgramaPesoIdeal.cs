using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace PesoIdeal_2018
{
    public partial class frmProgramaPesoIdeal : Form
    {
        //Ir para formulário ajuda
        public void button1_Click_1(object sender, EventArgs e)
        {
            frmAjuda ajuda = new frmAjuda();
            ajuda.Show();
            this.Hide();
        }
        #region--------CARREGAMENTO SPLASH - RETIRADO
        //Chama Splash com carregamento do programa
        public frmProgramaPesoIdeal()
        {
            Thread t = new Thread(new ThreadStart(carregar));//retirado o método carregar para não inicializar o Splash
            t.Start();
            InitializeComponent();
            //Tempo que ficará o Splash antes de chamar o frmProgramaPesoideal
            for (int i = 0; i <= 1; i++)
            {
                Thread.Sleep(1);
            }
            t.Abort();
        }
        //Método para iniciar o frmSplash
        void carregar()
        {
            //Não inicializa mais o Splash, retirado do programa        
        }
        #endregion--FIM SPLASH
        #region--------SALVAR
        public void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog(); // Cria instancia tipo SaveFileDialog
            salvar.Filter = "Arquivos de Texto (*.txt)|*.txt"; // Mostra apenas arquivos de texto[opcional]
            salvar.DefaultExt = "txt"; // Define a extensão padrão para arquivo de texto
            DialogResult salvou = salvar.ShowDialog(); // Mostra o SaveFileDialog
            if (salvou == DialogResult.OK) // Só grava caso o usuário tenha clicado em OK          
            {
                StreamWriter sw = null;
                try
                {
                    sw = new StreamWriter(salvar.FileName); // Cria Instancia tipo StreamWriter, para gravar o arquivo

                    // Grava o conteúdo do textbox1 no arquivo

                    if (textNomeUsu.Text == "" || textNomeUsu.Text != "")
                    {
                        if (textNomeUsu.Text == "")
                        {
                            sw.Write(nomeUsu.Text + " Não Informado");
                            sw.Write(textNomeUsu.Text);
                            sw.WriteLine("");
                        }
                        else
                        {
                            sw.Write(nomeUsu.Text + " ");
                            sw.Write(textNomeUsu.Text);
                            sw.WriteLine("");
                        }
                    }
                    //Sexo
                    if (radioBtfeminino.Checked == true)
                    {
                        sw.Write("Sexo: Feminino");
                        sw.WriteLine("");
                    }
                    if (radioBtmasculino.Checked == true)
                    {
                        sw.Write("Sexo: Masculino");
                        sw.WriteLine("");
                    }
                    //Altura
                    sw.Write(label2.Text + " ");
                    sw.Write(altura.Text);
                    sw.WriteLine("");
                    //Peso
                    sw.Write(label4.Text + " ");
                    sw.Write(peso.Text);
                    sw.WriteLine("");
                    //Peso Ideal
                    sw.Write(label5.Text + " ");
                    sw.Write(resultado.Text);
                    sw.WriteLine("");                
                    //Diferença de peso
                    sw.Write(label6.Text + " ");
                    sw.Write(diferencaPeso.Text);
                    sw.WriteLine("");
                    //Status se estava acima, abaixo ou com o peso ideal
                    sw.Write(label7.Text + " ");
                    sw.Write(acimadopeso.Text);
                    sw.WriteLine("");
                    sw.WriteLine("");

                    sw.Write("Hora: "+DateTime.Now.ToShortTimeString());
                    sw.WriteLine("");
                    sw.Write("Data: "+DateTime.Now.ToShortDateString());         
                }
                catch (IOException ex)
                {
                    MessageBox.Show("IOException:\r\n\r\n" + ex.Message); // Mostra mensagem caso ocorra uma IOException
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception : \r\n\r\n" + ex.Message); //Mostra mensagem caso ocorra uma exceção que não seja do tipo IOException
                }
                finally
                {
                    if (sw != null)
                        sw.Close(); // Fecha a instancia StreamWriter, com ou sem exceção.
                }
                MessageBox.Show("O arquivo foi salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("O arquivo não foi salvo!");
                // Pode por um código aqui caso o usuário clique em cancel. Neste caso somente sai
            }
        }
        #endregion
        #region--------LIMPA CAMPOS DO FORMULÁRIO
        //Método para limpar todos os campos
        public void limparCampos()
        {
            altura.Text = "";
            peso.Text = "";
            resultado.Text = "";
            radioBtfeminino.Checked = false;
            radioBtmasculino.Checked = false;
            acimadopeso.Text = "";
            diferencaPeso.Text = "";
            btSalvar.Enabled = false;
            textNomeUsu.Text = "";
            labeKg1.Visible = false;
            labeKg2.Visible = false;
            altura.Text = "172...";
            peso.Text = "65,5";
        }
        //Limpa campos do formulário
        public void btLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja limpar todos os campos ?"), "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //chama método limpar todos os campos
                limparCampos();
                MessageBox.Show("Os campos foram limpados com sucesso!");
            }
            else
            {
                //fechar a messagebox
            }
        }
        #endregion--------FIM LIMPAR CAMPOS
        #region--------BOTÕES DE MINIMIZAR, MAXIMIZAR E FECHAR
        //Fechar programa com opção de voltar para o mesmo
        public void btfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja sair do programa ?"), "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                //Volta para o Form
            }
        }
        //Minimiza o programa
        public void btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Maximiza o programa
        private void btmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnormal.Visible = true;
            btmaximizar.Visible = false;
        }
        //Tela normal do Programa
        public void btnormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnormal.Visible = false;
            btmaximizar.Visible = true;
        }
        #endregion--------FIM CAMPOS
        #region--------MÉTODO SEPARADO PARA CALCULAR PESO IDEAL
        //Método para Calcular Peso Ideal
        public void pesoIdeal()
        {
            if (radioBtmasculino.Checked == false && radioBtfeminino.Checked == false && peso.Text == "" && altura.Text == "")
            {
                MessageBox.Show("Nenhum campo foi preenchido!");
            }
            else if (altura.Text == "" && peso.Text == "")
            {
                MessageBox.Show("O campo altura e peso não foram preenchidos!");
            }
            else if (altura.Text!="" && peso.Text!="" && radioBtmasculino.Checked == false && radioBtfeminino.Checked == false)
            {
                MessageBox.Show("Favor definir o sexo!");
            }
            else if (radioBtmasculino.Checked == false && radioBtfeminino.Checked == false && altura.Text == "")
            {
                MessageBox.Show("O campo sexo e altura não foram preenchidos!");
            }
            else if (radioBtmasculino.Checked == false && radioBtfeminino.Checked == false && peso.Text == "")
            {
                MessageBox.Show("O campo sexo e peso não foram preenchidos!");
            }   
            else if (altura.Text == "")
            {
                MessageBox.Show("O campo altura não foi preenchido!");
            }
            else if (peso.Text == "")
            {
                MessageBox.Show("O campo peso não foi preenchido!");
            }
            else if (radioBtmasculino.Checked == false && radioBtfeminino.Checked == false)
            {
                MessageBox.Show("Favor selecionar um sexo!");
            }
            else if (peso.Text=="," || peso.Text == "0,")
            {
                MessageBox.Show("Entrada inválida no campo peso!");
            }
            else
            {
                labeKg1.Visible = true;
                labeKg2.Visible = true;
                //Conversão dos textbox para realizar o cálculo
                double h = Convert.ToDouble(altura.Text);
                double p = Convert.ToDouble(peso.Text);
                string acima = Convert.ToString(acimadopeso.Text);
                string ideal = Convert.ToString(peso.Text);
                double diferenca = 0;

                //Variáveis para resultado final para homem ou mulher
                double pesoHomem = 0;
                double pesoMulher = 0;

                //Calcula peso ideal masculino
                if (radioBtmasculino.Checked == true)
                {
                    //Cálculo e resultado
                    pesoHomem = (h - 100) - ((h - 150) / 4);
                    resultado.Text = Convert.ToString(pesoHomem);

                    //Peso ideal se peso do usuário(a) for igual ao cálculo do peso ideal
                    if (pesoHomem == p)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está com o peso ideal!";
                        diferenca = 0;
                        diferencaPeso.Text = Convert.ToString(diferenca);
                        salvarCalculo();
                    }
                    //Foi dada uma margem de 5kg para mais e para menos para estar ainda com o peso ideal
                    if (pesoHomem - p <= 5 || p - pesoHomem > -5 && p - pesoHomem <= 0)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está com o peso ideal!";
                        if (pesoHomem > p)
                        {
                            diferenca = pesoHomem - p;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                        if (p > pesoHomem)
                        {
                            diferenca = p - pesoHomem;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }   
                    }
                    //Abaixo do peso caso o peso do usuário(a) - o peso ideal for menor que a margem de -5kg
                    if (p - pesoHomem < -5)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está abaixo do peso ideal!";
                        if (pesoHomem > p)
                        {
                            diferenca = pesoHomem - p;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                        if (p > pesoHomem)
                        {
                            diferenca = p - pesoHomem;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                    }
                    //Acima do peso caso o peso do usuário(a) - o peso ideal for maior que a margem de 5kg
                    if (p - pesoHomem > 5)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está acima do peso!";
                        salvarCalculo();
                        if (pesoHomem > p)
                        {
                            diferenca = pesoHomem - p;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                        if (p > pesoHomem)
                        {
                            diferenca = p - pesoHomem;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                    }
                }
                //Calcula peso ideal feminino
                if (radioBtfeminino.Checked == true)
                {
                    //Cálculo e resultado
                    pesoMulher = (h - 100) - ((h - 150) / 2);
                    resultado.Text = Convert.ToString(pesoMulher);
                    salvarCalculo();

                    //Peso ideal se peso do usuário(a) for igual ao cálculo do peso ideal
                    if (pesoMulher == p)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está com o peso ideal!";
                        diferenca = 0;
                        diferencaPeso.Text = Convert.ToString(diferenca);
                        salvarCalculo();
                    }
                    //Foi dada uma margem de 5kg para mais e para menos para estar ainda com o peso ideal
                    if (pesoMulher - p <= 5 || p - pesoMulher > -5 && p - pesoMulher <= 0)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está com o peso ideal!";
                        if (pesoMulher > p)
                        {
                            diferenca = pesoMulher - p;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                        if (p > pesoMulher)
                        {
                            diferenca = p - pesoMulher;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                    }
                    //Abaixo do peso caso o peso do usuário(a) - o peso ideal for menor que a margem de -5kg
                    if (p - pesoMulher < -5)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está abaixo do peso ideal!";
                        if (pesoMulher > p)
                        {
                            diferenca = pesoMulher - p;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                        if (p > pesoMulher)
                        {
                            diferenca = p - pesoMulher;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                    }
                    //Acima do peso caso o peso do usuário(a) - o peso ideal for maior que a margem de 5kg
                    if (p - pesoMulher > 5)
                    {
                        acimadopeso.Text = Convert.ToString(acima);
                        acimadopeso.Text = "Você está acima do peso!";
                        if (pesoMulher > p)
                        {
                            diferenca = pesoMulher - p;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                        if (p > pesoMulher)
                        {
                            diferenca = p - pesoMulher;
                            diferencaPeso.Text = Convert.ToString(diferenca);
                            salvarCalculo();
                        }
                    }
                }
            }
        }
        #endregion--------FIM CÁLCULO
        #region--------MÉTODO verificaCampos e pesoIdeal nos botões
        //Coloca em ação o método para verificar os campos para habilitar ou não os botões para utilização
        public void altura_TextChanged_1(object sender, EventArgs e)
        {
            verificaCampos();
        }
        public void peso_TextChanged(object sender, EventArgs e)
        {
            verificaCampos();
        }
        private void radioBtmasculino_CheckedChanged(object sender, EventArgs e)
        {
            verificaCampos();
        }
        public void radioBtfeminino_CheckedChanged(object sender, EventArgs e)
        {
            verificaCampos();
        }
        //Chama método PesoIdeal, deixei um método para o cálculo, pois usei o mesmo para o método calcular com a tecla ENTER ACIMA
        public void btCalcular_Click(object sender, EventArgs e)
        {
            pesoIdeal();
        }
        #endregion--------FIM MÉTODOS NOS BOTÕES
        #region--------USUÁRIO ARRASTAR PROGRAMA COM MOUSE
        // para o usuário poder arrastar o programa com o mouse
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        public void frmPrograma_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }
        public void frmPrograma_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }
        public void frmPrograma_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
        #endregion--------FIM ARRASTAR CAMPOS
        #region--------ALTERAR COR DO BOTÕES AO PASSAR MOUSE POR CIMA
        //Altera cor do botões ao passar botão por cima
        public void btfechar_MouseMove(object sender, MouseEventArgs e)
        {
            btfechar.BackColor = Color.Red;
        }
        public void btfechar_MouseLeave(object sender, EventArgs e)
        {
            btfechar.BackColor = Color.GhostWhite;
        }
        public void btCalcular_MouseMove(object sender, MouseEventArgs e)
        {
            btCalcular.BackColor = Color.Cyan;
        }
        public void btCalcular_MouseLeave(object sender, EventArgs e)
        {
            btCalcular.BackColor = Color.GhostWhite;
        }
        public void btLimpar_MouseMove(object sender, MouseEventArgs e)
        {
            btLimpar.BackColor = Color.Cyan;
        }
        public void btLimpar_MouseLeave(object sender, EventArgs e)
        {
            btLimpar.BackColor = Color.GhostWhite;
        }
        private void btnormal_MouseMove(object sender, MouseEventArgs e)
        {
            btnormal.BackColor = Color.LightSkyBlue;
        }
        public void btnormal_MouseLeave(object sender, EventArgs e)
        {
            btnormal.BackColor = Color.GhostWhite;
        }
        public void btmaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btmaximizar.BackColor = Color.LightSkyBlue;
        }
        public void btmaximizar_MouseLeave(object sender, EventArgs e)
        {
            btmaximizar.BackColor = Color.GhostWhite;
        }
        public void btminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btminimizar.BackColor = Color.LightGreen;
        }
        public void btminimizar_MouseLeave(object sender, EventArgs e)
        {
            btminimizar.BackColor = Color.GhostWhite;
        }
        public void btSalvar_MouseMove(object sender, MouseEventArgs e)
        {
            btSalvar.BackColor = Color.Cyan;
        }
        public void btSalvar_MouseLeave(object sender, EventArgs e)
        {
            btSalvar.BackColor = Color.GhostWhite;
        }
        public void button1_MouseMove_1(object sender, MouseEventArgs e)
        {
            btAjuda.BackColor = Color.Cyan;
        }
        public void button1_MouseLeave_1(object sender, EventArgs e)
        {
            btAjuda.BackColor = Color.GhostWhite;
        }
        public void btMenu_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void btMenu_MouseLeave(object sender, EventArgs e)
        {

        }
        private void btMenu_MouseMove_1(object sender, MouseEventArgs e)
        {

        }

        private void btMenu_MouseLeave_1(object sender, EventArgs e)
        {

        }
        #endregion--------FIM ALTERA CORES
        #region--------TRATAMENTO DE DIGITAÇÕES NOS CAMPOS
        //Aceita somente entrada número sem virgulas
        public void altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        //Aceita somente entrada número
        public void peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (peso.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        #endregion--------
        #region--------CRITÉRIOS PARA ATIVAÇÃO DOS BOTÕES SALVAR E LIMPAR CAMPOS
        //Se não tive nada preenchido o botão de limpar campos fica desativado, caso seja digitado algo ou selecionado um sexo o botão é reativado
        public void verificaCampos()
        {

            if (altura.Text.Trim() != "" || peso.Text.Trim() != "" || radioBtmasculino.Checked == true || radioBtfeminino.Checked == true)
            {
                btLimpar.Enabled = true;
            }
            else
            {
                btLimpar.Enabled = true;
            }
        }
        public void salvarCalculo()
        {
            if (resultado.Text=="")
            {
                btSalvar.Enabled = false;
            }
            else
            {
                btSalvar.Enabled = true;
            }
        }
        #endregion--------FIM CRITÉRIOS
        #region--------CAMPOS NÃO UTILIZADOS
        
        public void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void button1_MouseLeave(object sender, EventArgs e)
        {
        }
        public void button1_MouseMove(object sender, MouseEventArgs e)
        {
        }
        public void recomendacao_TextChanged(object sender, EventArgs e)
        {

        }
        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void button2_Click(object sender, EventArgs e)
        {

        }
        
        public void btMenu_Click(object sender, EventArgs e)
        {
            
        }
        public void button1_Click_2(object sender, EventArgs e)
        {

        }
        public void radioBtmasculino_TextChanged(object sender, EventArgs e)
        {
        }
        public void radioBtfeminino_TextChanged(object sender, EventArgs e)
        {
        }
        public void altura_TextChanged(object sender, EventArgs e)
        {
        }
        public void toolTip2_Popup(object sender, PopupEventArgs e)
        {
        }
        public void btvoltar_Click(object sender, EventArgs e)
        {
        }
        public void btvoltar_MouseMove(object sender, MouseEventArgs e)
        {
        }
        public void btvoltar_MouseLeave(object sender, EventArgs e)
        {
        }
        public void frmProgramaPesoIdeal_Load(object sender, EventArgs e)
        {
        }
        public void btCarregar_Click(object sender, EventArgs e)
        {
        }
        public void btCarregar_MouseMove(object sender, MouseEventArgs e)
        {

        }
        public void btCarregar_MouseLeave(object sender, EventArgs e)
        {

        }
        public void btLimpar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public void btduvidas_Click(object sender, EventArgs e)
        {

        }
        public void btCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void salvarTool_Click(object sender, EventArgs e)
        {

        }
        private void imagemPeso_Click(object sender, EventArgs e)
        {

        }
        private void cm_Click(object sender, EventArgs e)
        {

        }
        private void cm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        private void cm_ClientSizeChanged(object sender, EventArgs e)
        {

        }
        private void cm_VisibleChanged(object sender, EventArgs e)
        {
        }
        private void altura_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void peso_MouseClick(object sender, MouseEventArgs e)
        {
        }
        #endregion--------FIM CAMPOS OUTROS   

    }
}
