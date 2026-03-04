namespace fiap_csharp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnEntrar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNome = new TextBox();
            textBox2 = new TextBox();
            lblNome = new Label();
            lblRM = new Label();
            dgvAluno = new DataGridView();
            lblCep = new Label();
            txtCep = new TextBox();
            lblRua = new Label();
            txtRua = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.Location = new Point(323, 121);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(139, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(201, 124);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(98, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código do Aluno";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(354, 321);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(323, 150);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(139, 23);
            txtNome.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(323, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(201, 153);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(201, 182);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(25, 15);
            lblRM.TabIndex = 7;
            lblRM.Text = "RM";
            // 
            // dgvAluno
            // 
            dgvAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAluno.Location = new Point(115, 352);
            dgvAluno.Name = "dgvAluno";
            dgvAluno.Size = new Size(612, 150);
            dgvAluno.TabIndex = 8;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(201, 211);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 10;
            lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.BackColor = Color.White;
            txtCep.Location = new Point(323, 208);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(139, 23);
            txtCep.TabIndex = 9;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(201, 244);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(27, 15);
            lblRua.TabIndex = 12;
            lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            txtRua.BackColor = Color.White;
            txtRua.Enabled = false;
            txtRua.Location = new Point(323, 241);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(139, 23);
            txtRua.TabIndex = 11;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(201, 273);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 14;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.White;
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(323, 270);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(139, 23);
            txtBairro.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(468, 208);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 526);
            Controls.Add(btnBuscar);
            Controls.Add(lblBairro);
            Controls.Add(txtBairro);
            Controls.Add(lblRua);
            Controls.Add(txtRua);
            Controls.Add(lblCep);
            Controls.Add(txtCep);
            Controls.Add(dgvAluno);
            Controls.Add(lblRM);
            Controls.Add(lblNome);
            Controls.Add(textBox2);
            Controls.Add(txtNome);
            Controls.Add(btnEntrar);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnEntrar;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNome;
        private TextBox textBox2;
        private Label lblNome;
        private Label lblRM;
        private DataGridView dgvAluno;
        private Label lblCep;
        private TextBox txtCep;
        private Label lblRua;
        private TextBox txtRua;
        private Label lblBairro;
        private TextBox txtBairro;
        private Button btnBuscar;
    }
}
