namespace ConsumoEnergiaCondomíno
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
            this.labelNCasa = new System.Windows.Forms.Label();
            this.labelConsumo = new System.Windows.Forms.Label();
            this.textBoxNCasa = new System.Windows.Forms.TextBox();
            this.textBoxConsumo = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonProcessar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNCasa
            // 
            this.labelNCasa.AutoSize = true;
            this.labelNCasa.Location = new System.Drawing.Point(12, 18);
            this.labelNCasa.Name = "labelNCasa";
            this.labelNCasa.Size = new System.Drawing.Size(52, 13);
            this.labelNCasa.TabIndex = 0;
            this.labelNCasa.Text = "Nº Casa: ";
            // 
            // labelConsumo
            // 
            this.labelConsumo.AutoSize = true;
            this.labelConsumo.Location = new System.Drawing.Point(208, 18);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(57, 13);
            this.labelConsumo.TabIndex = 1;
            this.labelConsumo.Text = "Consumo: ";
            // 
            // textBoxNCasa
            // 
            this.textBoxNCasa.Location = new System.Drawing.Point(70, 15);
            this.textBoxNCasa.Name = "textBoxNCasa";
            this.textBoxNCasa.Size = new System.Drawing.Size(132, 20);
            this.textBoxNCasa.TabIndex = 2;
            // 
            // textBoxConsumo
            // 
            this.textBoxConsumo.Location = new System.Drawing.Point(271, 15);
            this.textBoxConsumo.Name = "textBoxConsumo";
            this.textBoxConsumo.Size = new System.Drawing.Size(125, 20);
            this.textBoxConsumo.TabIndex = 3;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(268, 297);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 4;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(409, 13);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 6;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 42);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(482, 237);
            this.dataGridView.TabIndex = 7;
            // 
            // buttonProcessar
            // 
            this.buttonProcessar.Location = new System.Drawing.Point(15, 290);
            this.buttonProcessar.Name = "buttonProcessar";
            this.buttonProcessar.Size = new System.Drawing.Size(106, 27);
            this.buttonProcessar.TabIndex = 8;
            this.buttonProcessar.Text = "Processar Dados";
            this.buttonProcessar.UseVisualStyleBackColor = true;
            this.buttonProcessar.Click += new System.EventHandler(this.buttonProcessar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.buttonProcessar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxConsumo);
            this.Controls.Add(this.textBoxNCasa);
            this.Controls.Add(this.labelConsumo);
            this.Controls.Add(this.labelNCasa);
            this.Name = "Form1";
            this.Text = "Consumo de energia de um condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNCasa;
        private System.Windows.Forms.Label labelConsumo;
        private System.Windows.Forms.TextBox textBoxNCasa;
        private System.Windows.Forms.TextBox textBoxConsumo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonProcessar;
    }
}

