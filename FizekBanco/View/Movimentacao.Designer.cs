namespace FizekBanco.View
{
    partial class Movimentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarParaOLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDigiteSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnOKSenha = new System.Windows.Forms.Button();
            this.txbMovimentacao = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarParaOLoginToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // voltarParaOLoginToolStripMenuItem
            // 
            this.voltarParaOLoginToolStripMenuItem.Name = "voltarParaOLoginToolStripMenuItem";
            this.voltarParaOLoginToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.voltarParaOLoginToolStripMenuItem.Text = "Voltar para o Login";
            this.voltarParaOLoginToolStripMenuItem.Click += new System.EventHandler(this.voltarParaOLoginToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOProjetoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOProjetoToolStripMenuItem
            // 
            this.sobreOProjetoToolStripMenuItem.Name = "sobreOProjetoToolStripMenuItem";
            this.sobreOProjetoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sobreOProjetoToolStripMenuItem.Text = "Sobre o Projeto";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(600, 50);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(519, 50);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDigiteSenha
            // 
            this.lblDigiteSenha.AutoSize = true;
            this.lblDigiteSenha.Location = new System.Drawing.Point(12, 55);
            this.lblDigiteSenha.Name = "lblDigiteSenha";
            this.lblDigiteSenha.Size = new System.Drawing.Size(178, 13);
            this.lblDigiteSenha.TabIndex = 13;
            this.lblDigiteSenha.Text = "Digite a senha numérica (4 digitos) : ";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(196, 52);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(81, 20);
            this.txbSenha.TabIndex = 14;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // btnOKSenha
            // 
            this.btnOKSenha.Location = new System.Drawing.Point(300, 50);
            this.btnOKSenha.Name = "btnOKSenha";
            this.btnOKSenha.Size = new System.Drawing.Size(75, 23);
            this.btnOKSenha.TabIndex = 15;
            this.btnOKSenha.Text = "Validar";
            this.btnOKSenha.UseVisualStyleBackColor = true;
            this.btnOKSenha.Click += new System.EventHandler(this.btnOKSenha_Click);
            // 
            // txbMovimentacao
            // 
            this.txbMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMovimentacao.Location = new System.Drawing.Point(12, 168);
            this.txbMovimentacao.Multiline = true;
            this.txbMovimentacao.Name = "txbMovimentacao";
            this.txbMovimentacao.ReadOnly = true;
            this.txbMovimentacao.Size = new System.Drawing.Size(660, 281);
            this.txbMovimentacao.TabIndex = 16;
            // 
            // Movimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txbMovimentacao);
            this.Controls.Add(this.btnOKSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblDigiteSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Movimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fizek Bank v 0.1.2 - Movimentação da Conta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarParaOLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProjetoToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDigiteSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnOKSenha;
        private System.Windows.Forms.TextBox txbMovimentacao;
    }
}