namespace AvaliacaoEscolar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criarDataGridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarColunasDadosFormandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preencherDadosDosFormandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarColunasDasNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preencherNotasDosFormandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarColunasDaMédiaNegativasEEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preencherMédiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantidadeDeNegativasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtvPauta = new System.Windows.Forms.DataGridView();
            this.Resultado = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnexercicio3 = new System.Windows.Forms.Button();
            this.redimensionarColunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPauta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarDataGridViewToolStripMenuItem,
            this.criarColunasDadosFormandosToolStripMenuItem,
            this.preencherDadosDosFormandosToolStripMenuItem,
            this.criarColunasDasNotasToolStripMenuItem,
            this.preencherNotasDosFormandosToolStripMenuItem,
            this.criarColunasDaMédiaNegativasEEstadoToolStripMenuItem,
            this.preencherMédiasToolStripMenuItem,
            this.quantidadeDeNegativasToolStripMenuItem,
            this.estadoToolStripMenuItem,
            this.redimensionarColunasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1559, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criarDataGridViewToolStripMenuItem
            // 
            this.criarDataGridViewToolStripMenuItem.Name = "criarDataGridViewToolStripMenuItem";
            this.criarDataGridViewToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.criarDataGridViewToolStripMenuItem.Text = "Criar Data Grid View";
            this.criarDataGridViewToolStripMenuItem.Click += new System.EventHandler(this.criarDataGridViewToolStripMenuItem_Click);
            // 
            // criarColunasDadosFormandosToolStripMenuItem
            // 
            this.criarColunasDadosFormandosToolStripMenuItem.Name = "criarColunasDadosFormandosToolStripMenuItem";
            this.criarColunasDadosFormandosToolStripMenuItem.Size = new System.Drawing.Size(189, 20);
            this.criarColunasDadosFormandosToolStripMenuItem.Text = "Criar Colunas Dados Formandos";
            this.criarColunasDadosFormandosToolStripMenuItem.Click += new System.EventHandler(this.criarColunasDadosFormandosToolStripMenuItem_Click);
            // 
            // preencherDadosDosFormandosToolStripMenuItem
            // 
            this.preencherDadosDosFormandosToolStripMenuItem.Name = "preencherDadosDosFormandosToolStripMenuItem";
            this.preencherDadosDosFormandosToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.preencherDadosDosFormandosToolStripMenuItem.Text = "Preencher Dados dos Formandos";
            this.preencherDadosDosFormandosToolStripMenuItem.Click += new System.EventHandler(this.preencherDadosDosFormandosToolStripMenuItem_Click);
            // 
            // criarColunasDasNotasToolStripMenuItem
            // 
            this.criarColunasDasNotasToolStripMenuItem.Name = "criarColunasDasNotasToolStripMenuItem";
            this.criarColunasDasNotasToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.criarColunasDasNotasToolStripMenuItem.Text = "Criar Colunas das Notas";
            this.criarColunasDasNotasToolStripMenuItem.Click += new System.EventHandler(this.criarColunasDasNotasToolStripMenuItem_Click);
            // 
            // preencherNotasDosFormandosToolStripMenuItem
            // 
            this.preencherNotasDosFormandosToolStripMenuItem.Name = "preencherNotasDosFormandosToolStripMenuItem";
            this.preencherNotasDosFormandosToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.preencherNotasDosFormandosToolStripMenuItem.Text = "Preencher Notas dos Formandos";
            this.preencherNotasDosFormandosToolStripMenuItem.Click += new System.EventHandler(this.preencherNotasDosFormandosToolStripMenuItem_Click);
            // 
            // criarColunasDaMédiaNegativasEEstadoToolStripMenuItem
            // 
            this.criarColunasDaMédiaNegativasEEstadoToolStripMenuItem.Name = "criarColunasDaMédiaNegativasEEstadoToolStripMenuItem";
            this.criarColunasDaMédiaNegativasEEstadoToolStripMenuItem.Size = new System.Drawing.Size(247, 20);
            this.criarColunasDaMédiaNegativasEEstadoToolStripMenuItem.Text = "Criar Colunas da Média, Negativas e Estado";
            this.criarColunasDaMédiaNegativasEEstadoToolStripMenuItem.Click += new System.EventHandler(this.criarColunasDaMédiaNegativasEEstadoToolStripMenuItem_Click);
            // 
            // preencherMédiasToolStripMenuItem
            // 
            this.preencherMédiasToolStripMenuItem.Name = "preencherMédiasToolStripMenuItem";
            this.preencherMédiasToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.preencherMédiasToolStripMenuItem.Text = "Preencher Médias";
            this.preencherMédiasToolStripMenuItem.Click += new System.EventHandler(this.preencherMédiasToolStripMenuItem_Click);
            // 
            // quantidadeDeNegativasToolStripMenuItem
            // 
            this.quantidadeDeNegativasToolStripMenuItem.Name = "quantidadeDeNegativasToolStripMenuItem";
            this.quantidadeDeNegativasToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.quantidadeDeNegativasToolStripMenuItem.Text = "Quantidade de Negativas";
            this.quantidadeDeNegativasToolStripMenuItem.Click += new System.EventHandler(this.quantidadeDeNegativasToolStripMenuItem_Click);
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.estadoToolStripMenuItem.Text = "Estado";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.estadoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtvPauta
            // 
            this.dtvPauta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPauta.Location = new System.Drawing.Point(0, 27);
            this.dtvPauta.Name = "dtvPauta";
            this.dtvPauta.Size = new System.Drawing.Size(1027, 475);
            this.dtvPauta.TabIndex = 2;
            this.dtvPauta.Visible = false;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(1237, 69);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(112, 50);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Exercicio 1";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.Location = new System.Drawing.Point(1237, 125);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(112, 50);
            this.btnExercicio2.TabIndex = 4;
            this.btnExercicio2.Text = "Exercicio 2";
            this.btnExercicio2.UseVisualStyleBackColor = true;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // btnexercicio3
            // 
            this.btnexercicio3.Location = new System.Drawing.Point(1237, 181);
            this.btnexercicio3.Name = "btnexercicio3";
            this.btnexercicio3.Size = new System.Drawing.Size(112, 50);
            this.btnexercicio3.TabIndex = 5;
            this.btnexercicio3.Text = "Exercicio 3";
            this.btnexercicio3.UseVisualStyleBackColor = true;
            this.btnexercicio3.Click += new System.EventHandler(this.btnexercicio3_Click);
            // 
            // redimensionarColunasToolStripMenuItem
            // 
            this.redimensionarColunasToolStripMenuItem.Name = "redimensionarColunasToolStripMenuItem";
            this.redimensionarColunasToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.redimensionarColunasToolStripMenuItem.Text = "Redimensionar Colunas";
            this.redimensionarColunasToolStripMenuItem.Click += new System.EventHandler(this.redimensionarColunasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 505);
            this.Controls.Add(this.btnexercicio3);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.dtvPauta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPauta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criarDataGridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarColunasDadosFormandosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dtvPauta;
        private System.Windows.Forms.ToolStripMenuItem preencherDadosDosFormandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarColunasDasNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preencherNotasDosFormandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarColunasDaMédiaNegativasEEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preencherMédiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantidadeDeNegativasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.Button btnExercicio2;
        private System.Windows.Forms.Button btnexercicio3;
        private System.Windows.Forms.ToolStripMenuItem redimensionarColunasToolStripMenuItem;
    }
}

