namespace FizekBanco.View
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarParaOLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.btnOperacao = new System.Windows.Forms.Button();
            this.btnInfoConta = new System.Windows.Forms.Button();
            this.btnSugestões = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.InitialImage = null;
            this.pbxUsuario.Location = new System.Drawing.Point(63, 58);
            this.pbxUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(50, 50);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsuario.TabIndex = 0;
            this.pbxUsuario.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeUsuario.Location = new System.Drawing.Point(125, 73);
            this.lblNomeUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(117, 20);
            this.lblNomeUsuario.TabIndex = 1;
            this.lblNomeUsuario.Text = "Usuário: Admin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.sobreOProjetoToolStripMenuItem.Click += new System.EventHandler(this.sobreOProjetoToolStripMenuItem_Click);
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacao.Location = new System.Drawing.Point(527, 64);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(100, 40);
            this.btnMovimentacao.TabIndex = 3;
            this.btnMovimentacao.Text = "Movimentação";
            this.btnMovimentacao.UseVisualStyleBackColor = true;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacao_Click);
            // 
            // btnOperacao
            // 
            this.btnOperacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacao.Location = new System.Drawing.Point(527, 110);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(100, 40);
            this.btnOperacao.TabIndex = 4;
            this.btnOperacao.Text = "Operações";
            this.btnOperacao.UseVisualStyleBackColor = true;
            this.btnOperacao.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btnInfoConta
            // 
            this.btnInfoConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoConta.Location = new System.Drawing.Point(527, 156);
            this.btnInfoConta.Name = "btnInfoConta";
            this.btnInfoConta.Size = new System.Drawing.Size(100, 40);
            this.btnInfoConta.TabIndex = 5;
            this.btnInfoConta.Text = "Informações Conta";
            this.btnInfoConta.UseVisualStyleBackColor = true;
            this.btnInfoConta.Click += new System.EventHandler(this.btnInfoConta_Click);
            // 
            // btnSugestões
            // 
            this.btnSugestões.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSugestões.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSugestões.Location = new System.Drawing.Point(527, 202);
            this.btnSugestões.Name = "btnSugestões";
            this.btnSugestões.Size = new System.Drawing.Size(100, 40);
            this.btnSugestões.TabIndex = 6;
            this.btnSugestões.Text = "Reclamações ou Sugestões";
            this.btnSugestões.UseVisualStyleBackColor = true;
            this.btnSugestões.Click += new System.EventHandler(this.btnSugestões_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(527, 248);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Encerrar Sessão";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSugestões);
            this.Controls.Add(this.btnInfoConta);
            this.Controls.Add(this.btnOperacao);
            this.Controls.Add(this.btnMovimentacao);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.pbxUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fizek Bank v 0.1.2 - Página Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarParaOLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnMovimentacao;
        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProjetoToolStripMenuItem;
        private System.Windows.Forms.Button btnInfoConta;
        private System.Windows.Forms.Button btnSugestões;
        private System.Windows.Forms.Button btnSair;


    }
}