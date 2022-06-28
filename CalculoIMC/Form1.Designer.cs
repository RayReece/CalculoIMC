namespace CalculoIMC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.grbOperação = new System.Windows.Forms.GroupBox();
            this.lbla = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbOperação.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(167, 29);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(84, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Calcule seu IMC";
            // 
            // grbOperação
            // 
            this.grbOperação.Controls.Add(this.lbla);
            this.grbOperação.Controls.Add(this.lblp);
            this.grbOperação.Controls.Add(this.txtAltura);
            this.grbOperação.Controls.Add(this.txtPeso);
            this.grbOperação.Location = new System.Drawing.Point(116, 60);
            this.grbOperação.Name = "grbOperação";
            this.grbOperação.Size = new System.Drawing.Size(200, 124);
            this.grbOperação.TabIndex = 1;
            this.grbOperação.TabStop = false;
            this.grbOperação.Text = "Operação:";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(3, 45);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(37, 13);
            this.lbla.TabIndex = 3;
            this.lbla.Text = "Altura:";
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(3, 26);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(34, 13);
            this.lblp.TabIndex = 2;
            this.lblp.Text = "Peso:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(54, 45);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(54, 19);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(116, 190);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 28);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(119, 221);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(29, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "IMC:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(122, 238);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(118, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 279);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbOperação);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOperação.ResumeLayout(false);
            this.grbOperação.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.GroupBox grbOperação;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblStatus;
    }
}

