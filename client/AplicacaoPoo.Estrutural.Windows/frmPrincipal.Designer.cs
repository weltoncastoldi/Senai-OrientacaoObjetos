namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
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
            this.btnAbrirFormConversorMoedas = new System.Windows.Forms.Button();
            this.btnAbrirFormComissionamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormConversorMoedas
            // 
            this.btnAbrirFormConversorMoedas.Location = new System.Drawing.Point(12, 41);
            this.btnAbrirFormConversorMoedas.Name = "btnAbrirFormConversorMoedas";
            this.btnAbrirFormConversorMoedas.Size = new System.Drawing.Size(158, 64);
            this.btnAbrirFormConversorMoedas.TabIndex = 0;
            this.btnAbrirFormConversorMoedas.Text = "CONVERSOR DE MOEDAS";
            this.btnAbrirFormConversorMoedas.UseVisualStyleBackColor = true;
            this.btnAbrirFormConversorMoedas.Click += new System.EventHandler(this.btnAbrirFormConversorMoedas_Click);
            // 
            // btnAbrirFormComissionamento
            // 
            this.btnAbrirFormComissionamento.Location = new System.Drawing.Point(195, 41);
            this.btnAbrirFormComissionamento.Name = "btnAbrirFormComissionamento";
            this.btnAbrirFormComissionamento.Size = new System.Drawing.Size(149, 64);
            this.btnAbrirFormComissionamento.TabIndex = 1;
            this.btnAbrirFormComissionamento.Text = "COMISSIONAMENTO";
            this.btnAbrirFormComissionamento.UseVisualStyleBackColor = true;
            this.btnAbrirFormComissionamento.Click += new System.EventHandler(this.btnAbrirFormComissionamento_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 161);
            this.Controls.Add(this.btnAbrirFormComissionamento);
            this.Controls.Add(this.btnAbrirFormConversorMoedas);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirFormConversorMoedas;
        private Button btnAbrirFormComissionamento;
    }
}