
namespace Estacionamento
{
    partial class Frm_Principal
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
            this.Btn_CadastrarVeiculo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // Btn_CadastrarVeiculo
            // 
            this.Btn_CadastrarVeiculo.Location = new System.Drawing.Point(38, 222);
            this.Btn_CadastrarVeiculo.Name = "Btn_CadastrarVeiculo";
            this.Btn_CadastrarVeiculo.Size = new System.Drawing.Size(131, 35);
            this.Btn_CadastrarVeiculo.TabIndex = 0;
            this.Btn_CadastrarVeiculo.Text = "Cadastrar Veiculo";
            this.Btn_CadastrarVeiculo.UseVisualStyleBackColor = true;
            this.Btn_CadastrarVeiculo.Click += new System.EventHandler(this.Btn_CadastrarVeiculo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_CadastrarVeiculo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CadastrarVeiculo;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

