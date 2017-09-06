namespace FizekBanco.View
{
    partial class Operacoes
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
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDepósito = new System.Windows.Forms.Button();
            this.btnTransf = new System.Windows.Forms.Button();
            this.btnEmprest = new System.Windows.Forms.Button();
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
            this.menuStrip1.TabIndex = 4;
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
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sairToolStripMenuItem.Text = "Sair";
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
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(519, 50);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(470, 193);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(121, 36);
            this.btnSaque.TabIndex = 11;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = false;
            // 
            // btnDepósito
            // 
            this.btnDepósito.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDepósito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepósito.Location = new System.Drawing.Point(470, 235);
            this.btnDepósito.Name = "btnDepósito";
            this.btnDepósito.Size = new System.Drawing.Size(121, 36);
            this.btnDepósito.TabIndex = 12;
            this.btnDepósito.Text = "Depósito";
            this.btnDepósito.UseVisualStyleBackColor = false;
            // 
            // btnTransf
            // 
            this.btnTransf.BackColor = System.Drawing.Color.Red;
            this.btnTransf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransf.Location = new System.Drawing.Point(470, 277);
            this.btnTransf.Name = "btnTransf";
            this.btnTransf.Size = new System.Drawing.Size(121, 36);
            this.btnTransf.TabIndex = 13;
            this.btnTransf.Text = "Transferências";
            this.btnTransf.UseVisualStyleBackColor = false;
            // 
            // btnEmprest
            // 
            this.btnEmprest.BackColor = System.Drawing.Color.Gold;
            this.btnEmprest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprest.Location = new System.Drawing.Point(470, 319);
            this.btnEmprest.Name = "btnEmprest";
            this.btnEmprest.Size = new System.Drawing.Size(121, 36);
            this.btnEmprest.TabIndex = 14;
            this.btnEmprest.Text = "Empréstimos";
            this.btnEmprest.UseVisualStyleBackColor = false;
            // 
            // Operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnEmprest);
            this.Controls.Add(this.btnTransf);
            this.Controls.Add(this.btnDepósito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Operacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fizek Bank v 0.1.2 - Operações";
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
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDepósito;
        private System.Windows.Forms.Button btnTransf;
        private System.Windows.Forms.Button btnEmprest;
    }
}