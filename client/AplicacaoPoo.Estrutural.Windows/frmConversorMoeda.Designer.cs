namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorMoeda
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
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.btnConverterEmReal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.Location = new System.Drawing.Point(34, 77);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "informe o valor em dolar";
            this.txtValorEmDolar.Size = new System.Drawing.Size(155, 23);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            this.txtValorEmDolar.Leave += new System.EventHandler(this.txtValorEmDolar_Leave);
            // 
            // btnConverterEmReal
            // 
            this.btnConverterEmReal.Location = new System.Drawing.Point(48, 106);
            this.btnConverterEmReal.Name = "btnConverterEmReal";
            this.btnConverterEmReal.Size = new System.Drawing.Size(123, 23);
            this.btnConverterEmReal.TabIndex = 2;
            this.btnConverterEmReal.Text = "Converter em Reais";
            this.btnConverterEmReal.UseVisualStyleBackColor = true;
            this.btnConverterEmReal.Click += new System.EventHandler(this.btnConverterEmReal_Click);
            // 
            // frmConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 171);
            this.Controls.Add(this.btnConverterEmReal);
            this.Controls.Add(this.txtValorEmDolar);
            this.Name = "frmConversorMoeda";
            this.Text = "frmConversorMoeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Button btnConverterEmReal;
    }
}