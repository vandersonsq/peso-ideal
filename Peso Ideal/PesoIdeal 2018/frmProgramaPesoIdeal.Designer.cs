namespace PesoIdeal_2018
{
    partial class frmProgramaPesoIdeal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgramaPesoIdeal));
            this.label1 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.radioBtmasculino = new System.Windows.Forms.RadioButton();
            this.radioBtfeminino = new System.Windows.Forms.RadioButton();
            this.Dados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btfechar = new System.Windows.Forms.Button();
            this.btmaximizar = new System.Windows.Forms.Button();
            this.btminimizar = new System.Windows.Forms.Button();
            this.btnormal = new System.Windows.Forms.Button();
            this.toolTipBTCalcular = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTLimpar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1TxtAltura = new System.Windows.Forms.ToolTip(this.components);
            this.textNomeUsu = new System.Windows.Forms.TextBox();
            this.toolTip1TxtPeso = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.btAjuda = new System.Windows.Forms.Button();
            this.toolTipBTMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTVoltarMenu = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTMaximizar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTFechar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTNormal = new System.Windows.Forms.ToolTip(this.components);
            this.btSalvar = new System.Windows.Forms.Button();
            this.toolTipBTsalvar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTcarregar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBTMenu = new System.Windows.Forms.ToolTip(this.components);
            this.kg = new System.Windows.Forms.Label();
            this.cm = new System.Windows.Forms.Label();
            this.labeKg1 = new System.Windows.Forms.Label();
            this.labeKg2 = new System.Windows.Forms.Label();
            this.toolTipPrograma = new System.Windows.Forms.ToolTip(this.components);
            this.resultado = new System.Windows.Forms.Label();
            this.diferencaPeso = new System.Windows.Forms.Label();
            this.acimadopeso = new System.Windows.Forms.Label();
            this.nomeUsu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipBTNomeUsu = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso Ideal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalcular
            // 
            this.btCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCalcular.BackColor = System.Drawing.Color.GhostWhite;
            this.btCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCalcular.FlatAppearance.BorderSize = 0;
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcular.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btCalcular.Image")));
            this.btCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalcular.Location = new System.Drawing.Point(163, 522);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(195, 46);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.toolTipBTCalcular.SetToolTip(this.btCalcular, "Calcula o Peso Ideal");
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            this.btCalcular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btCalcular_KeyPress);
            this.btCalcular.MouseLeave += new System.EventHandler(this.btCalcular_MouseLeave);
            this.btCalcular.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btCalcular_MouseMove);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLimpar.Enabled = false;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(163, 586);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(195, 46);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar Campos";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipBTLimpar.SetToolTip(this.btLimpar, "Limpa os campos preenchidos");
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            this.btLimpar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btLimpar_KeyPress);
            this.btLimpar.MouseLeave += new System.EventHandler(this.btLimpar_MouseLeave);
            this.btLimpar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btLimpar_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Peso:";
            // 
            // peso
            // 
            this.peso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.peso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(205, 290);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(76, 32);
            this.peso.TabIndex = 2;
            this.toolTip1TxtPeso.SetToolTip(this.peso, "Informe seu peso");
            this.peso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.peso_MouseClick);
            this.peso.TextChanged += new System.EventHandler(this.peso_TextChanged);
            this.peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peso_KeyPress);
            // 
            // altura
            // 
            this.altura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.altura.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(205, 241);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(76, 32);
            this.altura.TabIndex = 1;
            this.toolTip1TxtAltura.SetToolTip(this.altura, "Coloque sua altura em centímetros.\r\n\r\nCampo não aceitará vírgulas");
            this.altura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.altura_MouseClick);
            this.altura.TextChanged += new System.EventHandler(this.altura_TextChanged_1);
            this.altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.altura_KeyPress);
            // 
            // radioBtmasculino
            // 
            this.radioBtmasculino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioBtmasculino.AutoSize = true;
            this.radioBtmasculino.BackColor = System.Drawing.Color.Transparent;
            this.radioBtmasculino.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtmasculino.Location = new System.Drawing.Point(132, 343);
            this.radioBtmasculino.Name = "radioBtmasculino";
            this.radioBtmasculino.Size = new System.Drawing.Size(122, 28);
            this.radioBtmasculino.TabIndex = 4;
            this.radioBtmasculino.TabStop = true;
            this.radioBtmasculino.Text = "Masculino";
            this.radioBtmasculino.UseVisualStyleBackColor = false;
            this.radioBtmasculino.CheckedChanged += new System.EventHandler(this.radioBtmasculino_CheckedChanged);
            this.radioBtmasculino.TextChanged += new System.EventHandler(this.radioBtmasculino_TextChanged);
            // 
            // radioBtfeminino
            // 
            this.radioBtfeminino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioBtfeminino.AutoSize = true;
            this.radioBtfeminino.BackColor = System.Drawing.Color.Transparent;
            this.radioBtfeminino.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtfeminino.Location = new System.Drawing.Point(132, 377);
            this.radioBtfeminino.Name = "radioBtfeminino";
            this.radioBtfeminino.Size = new System.Drawing.Size(113, 28);
            this.radioBtfeminino.TabIndex = 3;
            this.radioBtfeminino.TabStop = true;
            this.radioBtfeminino.Text = "Feminino";
            this.radioBtfeminino.UseVisualStyleBackColor = false;
            this.radioBtfeminino.CheckedChanged += new System.EventHandler(this.radioBtfeminino_CheckedChanged);
            this.radioBtfeminino.TextChanged += new System.EventHandler(this.radioBtfeminino_TextChanged);
            // 
            // Dados
            // 
            this.Dados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dados.AutoSize = true;
            this.Dados.BackColor = System.Drawing.Color.Transparent;
            this.Dados.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dados.Location = new System.Drawing.Point(159, 132);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(222, 24);
            this.Dados.TabIndex = 12;
            this.Dados.Text = "Dados do Usuário (a)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(741, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resultados";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Peso Ideal:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Diferença:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(641, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(114, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(114, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(111, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(129, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "campos obrigatórios";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(114, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 24);
            this.label14.TabIndex = 32;
            this.label14.Text = "*";
            // 
            // btfechar
            // 
            this.btfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btfechar.BackColor = System.Drawing.Color.GhostWhite;
            this.btfechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btfechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btfechar.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfechar.Location = new System.Drawing.Point(1078, 0);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(25, 27);
            this.btfechar.TabIndex = 12;
            this.btfechar.Text = "✖";
            this.btfechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipBTFechar.SetToolTip(this.btfechar, "Fechar");
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            this.btfechar.MouseLeave += new System.EventHandler(this.btfechar_MouseLeave);
            this.btfechar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btfechar_MouseMove);
            // 
            // btmaximizar
            // 
            this.btmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmaximizar.BackColor = System.Drawing.Color.GhostWhite;
            this.btmaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmaximizar.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmaximizar.Location = new System.Drawing.Point(1047, 0);
            this.btmaximizar.Name = "btmaximizar";
            this.btmaximizar.Size = new System.Drawing.Size(25, 27);
            this.btmaximizar.TabIndex = 11;
            this.btmaximizar.Text = "□";
            this.toolTipBTMaximizar.SetToolTip(this.btmaximizar, "Maximizar");
            this.btmaximizar.UseVisualStyleBackColor = false;
            this.btmaximizar.Click += new System.EventHandler(this.btmaximizar_Click);
            this.btmaximizar.MouseLeave += new System.EventHandler(this.btmaximizar_MouseLeave);
            this.btmaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btmaximizar_MouseMove);
            // 
            // btminimizar
            // 
            this.btminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btminimizar.BackColor = System.Drawing.Color.GhostWhite;
            this.btminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btminimizar.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btminimizar.Location = new System.Drawing.Point(1016, 0);
            this.btminimizar.Name = "btminimizar";
            this.btminimizar.Size = new System.Drawing.Size(25, 27);
            this.btminimizar.TabIndex = 9;
            this.btminimizar.Text = "-";
            this.btminimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipBTMinimizar.SetToolTip(this.btminimizar, "Minimizar");
            this.btminimizar.UseVisualStyleBackColor = false;
            this.btminimizar.Click += new System.EventHandler(this.btminimizar_Click);
            this.btminimizar.MouseLeave += new System.EventHandler(this.btminimizar_MouseLeave);
            this.btminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btminimizar_MouseMove);
            // 
            // btnormal
            // 
            this.btnormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnormal.BackColor = System.Drawing.Color.GhostWhite;
            this.btnormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnormal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnormal.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnormal.Location = new System.Drawing.Point(1047, 0);
            this.btnormal.Name = "btnormal";
            this.btnormal.Size = new System.Drawing.Size(25, 27);
            this.btnormal.TabIndex = 10;
            this.btnormal.Text = "□";
            this.toolTipBTNormal.SetToolTip(this.btnormal, "Rest. Tamanho");
            this.btnormal.UseVisualStyleBackColor = false;
            this.btnormal.Visible = false;
            this.btnormal.Click += new System.EventHandler(this.btnormal_Click);
            this.btnormal.MouseLeave += new System.EventHandler(this.btnormal_MouseLeave);
            this.btnormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnormal_MouseMove);
            // 
            // toolTipBTCalcular
            // 
            this.toolTipBTCalcular.BackColor = System.Drawing.Color.White;
            this.toolTipBTCalcular.IsBalloon = true;
            this.toolTipBTCalcular.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipBTCalcular.ToolTipTitle = "Calcular";
            // 
            // toolTipBTLimpar
            // 
            this.toolTipBTLimpar.BackColor = System.Drawing.Color.White;
            this.toolTipBTLimpar.IsBalloon = true;
            // 
            // toolTip1TxtAltura
            // 
            this.toolTip1TxtAltura.AutomaticDelay = 100;
            this.toolTip1TxtAltura.BackColor = System.Drawing.Color.White;
            this.toolTip1TxtAltura.IsBalloon = true;
            // 
            // textNomeUsu
            // 
            this.textNomeUsu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textNomeUsu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeUsu.Location = new System.Drawing.Point(204, 194);
            this.textNomeUsu.Name = "textNomeUsu";
            this.textNomeUsu.Size = new System.Drawing.Size(175, 26);
            this.textNomeUsu.TabIndex = 0;
            this.toolTipBTNomeUsu.SetToolTip(this.textNomeUsu, "Nome do usuário (a)");
            // 
            // toolTip1TxtPeso
            // 
            this.toolTip1TxtPeso.AutomaticDelay = 100;
            this.toolTip1TxtPeso.BackColor = System.Drawing.Color.White;
            this.toolTip1TxtPeso.IsBalloon = true;
            // 
            // toolTipBTAjuda
            // 
            this.toolTipBTAjuda.AutomaticDelay = 100;
            this.toolTipBTAjuda.BackColor = System.Drawing.Color.White;
            this.toolTipBTAjuda.IsBalloon = true;
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAjuda.BackColor = System.Drawing.Color.GhostWhite;
            this.btAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAjuda.FlatAppearance.BorderSize = 0;
            this.btAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjuda.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btAjuda.Image")));
            this.btAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjuda.Location = new System.Drawing.Point(745, 586);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(195, 46);
            this.btAjuda.TabIndex = 7;
            this.btAjuda.Text = "Ajuda";
            this.toolTipBTAjuda.SetToolTip(this.btAjuda, "Clique aqui para saber mais sobre o peso ideal");
            this.btAjuda.UseVisualStyleBackColor = false;
            this.btAjuda.Click += new System.EventHandler(this.button1_Click_1);
            this.btAjuda.MouseLeave += new System.EventHandler(this.button1_MouseLeave_1);
            this.btAjuda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove_1);
            // 
            // toolTipBTMinimizar
            // 
            this.toolTipBTMinimizar.AutomaticDelay = 100;
            this.toolTipBTMinimizar.BackColor = System.Drawing.Color.White;
            this.toolTipBTMinimizar.IsBalloon = true;
            // 
            // toolTipBTVoltarMenu
            // 
            this.toolTipBTVoltarMenu.BackColor = System.Drawing.Color.White;
            this.toolTipBTVoltarMenu.IsBalloon = true;
            this.toolTipBTVoltarMenu.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipBTVoltarMenu.ToolTipTitle = "Voltar";
            // 
            // toolTipBTMaximizar
            // 
            this.toolTipBTMaximizar.AutomaticDelay = 100;
            this.toolTipBTMaximizar.BackColor = System.Drawing.Color.White;
            this.toolTipBTMaximizar.IsBalloon = true;
            // 
            // toolTipBTFechar
            // 
            this.toolTipBTFechar.AutomaticDelay = 100;
            this.toolTipBTFechar.BackColor = System.Drawing.Color.White;
            this.toolTipBTFechar.IsBalloon = true;
            // 
            // toolTipBTNormal
            // 
            this.toolTipBTNormal.AutomaticDelay = 100;
            this.toolTipBTNormal.BackColor = System.Drawing.Color.White;
            this.toolTipBTNormal.IsBalloon = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSalvar.BackColor = System.Drawing.Color.GhostWhite;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalvar.Enabled = false;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(745, 522);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(195, 46);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.toolTipBTsalvar.SetToolTip(this.btSalvar, "Salvar dados");
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.button1_Click);
            this.btSalvar.MouseLeave += new System.EventHandler(this.btSalvar_MouseLeave);
            this.btSalvar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btSalvar_MouseMove);
            // 
            // toolTipBTsalvar
            // 
            this.toolTipBTsalvar.AutomaticDelay = 100;
            this.toolTipBTsalvar.BackColor = System.Drawing.Color.White;
            this.toolTipBTsalvar.IsBalloon = true;
            // 
            // toolTipBTcarregar
            // 
            this.toolTipBTcarregar.AutomaticDelay = 100;
            this.toolTipBTcarregar.BackColor = System.Drawing.Color.White;
            this.toolTipBTcarregar.IsBalloon = true;
            // 
            // toolTipBTMenu
            // 
            this.toolTipBTMenu.BackColor = System.Drawing.Color.White;
            this.toolTipBTMenu.IsBalloon = true;
            this.toolTipBTMenu.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipBTMenu.ToolTipTitle = "Menu";
            // 
            // kg
            // 
            this.kg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kg.AutoSize = true;
            this.kg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kg.Location = new System.Drawing.Point(294, 298);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(35, 24);
            this.kg.TabIndex = 46;
            this.kg.Text = "Kg";
            // 
            // cm
            // 
            this.cm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cm.AutoSize = true;
            this.cm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm.Location = new System.Drawing.Point(288, 249);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(41, 24);
            this.cm.TabIndex = 47;
            this.cm.Text = "Cm";
            this.cm.ClientSizeChanged += new System.EventHandler(this.cm_ClientSizeChanged);
            this.cm.VisibleChanged += new System.EventHandler(this.cm_VisibleChanged);
            this.cm.Click += new System.EventHandler(this.cm_Click);
            this.cm.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cm_PreviewKeyDown);
            // 
            // labeKg1
            // 
            this.labeKg1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labeKg1.AutoSize = true;
            this.labeKg1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeKg1.Location = new System.Drawing.Point(820, 191);
            this.labeKg1.Name = "labeKg1";
            this.labeKg1.Size = new System.Drawing.Size(35, 24);
            this.labeKg1.TabIndex = 48;
            this.labeKg1.Text = "Kg";
            this.labeKg1.Visible = false;
            // 
            // labeKg2
            // 
            this.labeKg2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labeKg2.AutoSize = true;
            this.labeKg2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeKg2.Location = new System.Drawing.Point(820, 241);
            this.labeKg2.Name = "labeKg2";
            this.labeKg2.Size = new System.Drawing.Size(35, 24);
            this.labeKg2.TabIndex = 49;
            this.labeKg2.Text = "Kg";
            this.labeKg2.Visible = false;
            // 
            // toolTipPrograma
            // 
            this.toolTipPrograma.AutomaticDelay = 100;
            this.toolTipPrograma.BackColor = System.Drawing.Color.Black;
            this.toolTipPrograma.ToolTipTitle = "Peso Ideal";
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(756, 191);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 24);
            this.resultado.TabIndex = 51;
            // 
            // diferencaPeso
            // 
            this.diferencaPeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diferencaPeso.AutoSize = true;
            this.diferencaPeso.BackColor = System.Drawing.Color.Transparent;
            this.diferencaPeso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferencaPeso.Location = new System.Drawing.Point(754, 241);
            this.diferencaPeso.Name = "diferencaPeso";
            this.diferencaPeso.Size = new System.Drawing.Size(0, 24);
            this.diferencaPeso.TabIndex = 52;
            // 
            // acimadopeso
            // 
            this.acimadopeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acimadopeso.AutoSize = true;
            this.acimadopeso.BackColor = System.Drawing.Color.Transparent;
            this.acimadopeso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acimadopeso.Location = new System.Drawing.Point(754, 290);
            this.acimadopeso.Name = "acimadopeso";
            this.acimadopeso.Size = new System.Drawing.Size(0, 24);
            this.acimadopeso.TabIndex = 53;
            // 
            // nomeUsu
            // 
            this.nomeUsu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeUsu.AutoSize = true;
            this.nomeUsu.BackColor = System.Drawing.Color.Transparent;
            this.nomeUsu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUsu.Location = new System.Drawing.Point(128, 196);
            this.nomeUsu.Name = "nomeUsu";
            this.nomeUsu.Size = new System.Drawing.Size(70, 24);
            this.nomeUsu.TabIndex = 54;
            this.nomeUsu.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(530, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 525);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // toolTipBTNomeUsu
            // 
            this.toolTipBTNomeUsu.AutomaticDelay = 100;
            this.toolTipBTNomeUsu.BackColor = System.Drawing.Color.Black;
            // 
            // frmProgramaPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textNomeUsu);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.nomeUsu);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.acimadopeso);
            this.Controls.Add(this.diferencaPeso);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.labeKg2);
            this.Controls.Add(this.labeKg1);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnormal);
            this.Controls.Add(this.btminimizar);
            this.Controls.Add(this.btmaximizar);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.radioBtfeminino);
            this.Controls.Add(this.radioBtmasculino);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgramaPesoIdeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.Load += new System.EventHandler(this.frmProgramaPesoIdeal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrograma_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrograma_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPrograma_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.RadioButton radioBtmasculino;
        private System.Windows.Forms.RadioButton radioBtfeminino;
        private System.Windows.Forms.Label Dados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Button btmaximizar;
        private System.Windows.Forms.Button btminimizar;
        private System.Windows.Forms.Button btnormal;
        private System.Windows.Forms.ToolTip toolTipBTCalcular;
        private System.Windows.Forms.ToolTip toolTipBTLimpar;
        private System.Windows.Forms.ToolTip toolTip1TxtAltura;
        private System.Windows.Forms.ToolTip toolTip1TxtPeso;
        private System.Windows.Forms.ToolTip toolTipBTAjuda;
        private System.Windows.Forms.ToolTip toolTipBTMinimizar;
        private System.Windows.Forms.ToolTip toolTipBTVoltarMenu;
        private System.Windows.Forms.ToolTip toolTipBTFechar;
        private System.Windows.Forms.ToolTip toolTipBTMaximizar;
        private System.Windows.Forms.ToolTip toolTipBTNormal;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ToolTip toolTipBTsalvar;
        private System.Windows.Forms.ToolTip toolTipBTcarregar;
        private System.Windows.Forms.Button btAjuda;
        private System.Windows.Forms.ToolTip toolTipBTMenu;
        private System.Windows.Forms.Label kg;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Label labeKg1;
        private System.Windows.Forms.Label labeKg2;
        private System.Windows.Forms.ToolTip toolTipPrograma;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label diferencaPeso;
        private System.Windows.Forms.Label acimadopeso;
        private System.Windows.Forms.Label nomeUsu;
        private System.Windows.Forms.TextBox textNomeUsu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTipBTNomeUsu;
    }
}

