
namespace Estacionamento
{
    partial class Frm_CadastrarVeiculo
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
            this.Txt_Placa = new System.Windows.Forms.TextBox();
            this.Txt_NomeProprietario = new System.Windows.Forms.TextBox();
            this.Lbl_Placa = new System.Windows.Forms.Label();
            this.Lbl_Proprietario = new System.Windows.Forms.Label();
            this.Lbl_Bloco = new System.Windows.Forms.Label();
            this.Lbl_Apartamento = new System.Windows.Forms.Label();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Bloco = new System.Windows.Forms.TextBox();
            this.Txt_Apartamento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Msk_Placa
            // 
            this.Txt_Placa.Location = new System.Drawing.Point(106, 66);
            this.Txt_Placa.Name = "Msk_Placa";
            this.Txt_Placa.Size = new System.Drawing.Size(168, 22);
            this.Txt_Placa.TabIndex = 0;
            // 
            // Txt_NomeProprietario
            // 
            this.Txt_NomeProprietario.Location = new System.Drawing.Point(145, 26);
            this.Txt_NomeProprietario.Name = "Txt_NomeProprietario";
            this.Txt_NomeProprietario.Size = new System.Drawing.Size(378, 22);
            this.Txt_NomeProprietario.TabIndex = 1;
            // 
            // Lbl_Placa
            // 
            this.Lbl_Placa.AutoSize = true;
            this.Lbl_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_Placa.Location = new System.Drawing.Point(12, 69);
            this.Lbl_Placa.Name = "Lbl_Placa";
            this.Lbl_Placa.Size = new System.Drawing.Size(61, 24);
            this.Lbl_Placa.TabIndex = 2;
            this.Lbl_Placa.Text = "Placa:";
            // 
            // Lbl_Proprietario
            // 
            this.Lbl_Proprietario.AutoSize = true;
            this.Lbl_Proprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_Proprietario.Location = new System.Drawing.Point(12, 26);
            this.Lbl_Proprietario.Name = "Lbl_Proprietario";
            this.Lbl_Proprietario.Size = new System.Drawing.Size(111, 24);
            this.Lbl_Proprietario.TabIndex = 3;
            this.Lbl_Proprietario.Text = "Proprietário:";
            // 
            // Lbl_Bloco
            // 
            this.Lbl_Bloco.AutoSize = true;
            this.Lbl_Bloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_Bloco.Location = new System.Drawing.Point(376, 69);
            this.Lbl_Bloco.Name = "Lbl_Bloco";
            this.Lbl_Bloco.Size = new System.Drawing.Size(63, 24);
            this.Lbl_Bloco.TabIndex = 6;
            this.Lbl_Bloco.Text = "Bloco:";
            // 
            // Lbl_Apartamento
            // 
            this.Lbl_Apartamento.AutoSize = true;
            this.Lbl_Apartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_Apartamento.Location = new System.Drawing.Point(330, 109);
            this.Lbl_Apartamento.Name = "Lbl_Apartamento";
            this.Lbl_Apartamento.Size = new System.Drawing.Size(122, 24);
            this.Lbl_Apartamento.TabIndex = 7;
            this.Lbl_Apartamento.Text = "Apartamento:";
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gravar.Location = new System.Drawing.Point(434, 210);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(89, 36);
            this.Btn_Gravar.TabIndex = 8;
            this.Btn_Gravar.Text = "Gravar";
            this.Btn_Gravar.UseVisualStyleBackColor = true;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(334, 210);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(89, 36);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_Celular.Location = new System.Drawing.Point(12, 109);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(74, 24);
            this.Lbl_Celular.TabIndex = 10;
            this.Lbl_Celular.Text = "Celular:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_Email.Location = new System.Drawing.Point(12, 146);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(62, 24);
            this.Lbl_Email.TabIndex = 11;
            this.Lbl_Email.Text = "Email:";
            // 
            // Msk_Celular
            // 
            this.Txt_Celular.Location = new System.Drawing.Point(106, 109);
            this.Txt_Celular.Name = "Msk_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(168, 22);
            this.Txt_Celular.TabIndex = 12;
            // 
            // Msk_Email
            // 
           
            this.Txt_Email.Location = new System.Drawing.Point(106, 146);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(168, 22);
            this.Txt_Email.TabIndex = 13;
            // 
            // Txt_Bloco
            // 
            this.Txt_Bloco.Location = new System.Drawing.Point(458, 71);
            this.Txt_Bloco.Name = "Txt_Bloco";
            this.Txt_Bloco.Size = new System.Drawing.Size(65, 22);
            this.Txt_Bloco.TabIndex = 14;
            // 
            // Txt_Apartamento
            // 
            this.Txt_Apartamento.Location = new System.Drawing.Point(458, 111);
            this.Txt_Apartamento.Name = "Txt_Apartamento";
            this.Txt_Apartamento.Size = new System.Drawing.Size(65, 22);
            this.Txt_Apartamento.TabIndex = 15;
            // 
            // Frm_CadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 268);
            this.Controls.Add(this.Txt_Apartamento);
            this.Controls.Add(this.Txt_Bloco);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Celular);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_Celular);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Lbl_Apartamento);
            this.Controls.Add(this.Lbl_Bloco);
            this.Controls.Add(this.Lbl_Proprietario);
            this.Controls.Add(this.Lbl_Placa);
            this.Controls.Add(this.Txt_NomeProprietario);
            this.Controls.Add(this.Txt_Placa);
            this.Name = "Frm_CadastrarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CadastrarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Placa;
        private System.Windows.Forms.TextBox Txt_NomeProprietario;
        private System.Windows.Forms.Label Lbl_Placa;
        private System.Windows.Forms.Label Lbl_Proprietario;
        private System.Windows.Forms.Label Lbl_Bloco;
        private System.Windows.Forms.Label Lbl_Apartamento;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Bloco;
        private System.Windows.Forms.TextBox Txt_Apartamento;
    }
}