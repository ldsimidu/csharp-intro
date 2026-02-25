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
            SuspendLayout();
            // 
            // txtCodigo
            // 
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
            btnEntrar.Location = new Point(351, 257);
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
            txtNome.Location = new Point(323, 150);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(139, 23);
            txtNome.TabIndex = 4;
            // 
            // textBox2
            // 
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
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
    }
}
