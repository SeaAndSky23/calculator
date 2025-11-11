using System.Drawing;
using System.Windows.Forms;

namespace calculator
{
    partial class basenum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basenum));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBaseInicial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBaseFinal = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiar2 = new System.Windows.Forms.PictureBox();
            this.btnvolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un número";
            // 
            // txtNumeroIngresado
            // 
            this.txtNumeroIngresado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIngresado.Location = new System.Drawing.Point(270, 39);
            this.txtNumeroIngresado.Name = "txtNumeroIngresado";
            this.txtNumeroIngresado.Size = new System.Drawing.Size(388, 23);
            this.txtNumeroIngresado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "De qué base viene el número";
            // 
            // cmbBaseInicial
            // 
            this.cmbBaseInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaseInicial.FormattingEnabled = true;
            this.cmbBaseInicial.Items.AddRange(new object[] {
            "Binario",
            "Decimal",
            "Hexadecimal"});
            this.cmbBaseInicial.Location = new System.Drawing.Point(211, 167);
            this.cmbBaseInicial.Name = "cmbBaseInicial";
            this.cmbBaseInicial.Size = new System.Drawing.Size(181, 21);
            this.cmbBaseInicial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "A qué base quiere convertirlo";
            // 
            // cmbBaseFinal
            // 
            this.cmbBaseFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaseFinal.FormattingEnabled = true;
            this.cmbBaseFinal.Items.AddRange(new object[] {
            "Binario",
            "Decimal",
            "Hexadecimal"});
            this.cmbBaseFinal.Location = new System.Drawing.Point(466, 167);
            this.cmbBaseFinal.Name = "cmbBaseFinal";
            this.cmbBaseFinal.Size = new System.Drawing.Size(192, 21);
            this.cmbBaseFinal.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Silver;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(194, 332);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(464, 62);
            this.txtResultado.TabIndex = 7;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertir.FlatAppearance.BorderSize = 2;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConvertir.Location = new System.Drawing.Point(360, 227);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(123, 31);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "RESULTADO";
            // 
            // btnlimpiar2
            // 
            this.btnlimpiar2.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar2.Image")));
            this.btnlimpiar2.Location = new System.Drawing.Point(787, 413);
            this.btnlimpiar2.Name = "btnlimpiar2";
            this.btnlimpiar2.Size = new System.Drawing.Size(35, 36);
            this.btnlimpiar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlimpiar2.TabIndex = 11;
            this.btnlimpiar2.TabStop = false;
            this.btnlimpiar2.Click += new System.EventHandler(this.btnlimpiar2_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Image = ((System.Drawing.Image)(resources.GetObject("btnvolver.Image")));
            this.btnvolver.Location = new System.Drawing.Point(12, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(32, 32);
            this.btnvolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver.TabIndex = 12;
            this.btnvolver.TabStop = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // basenum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnlimpiar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cmbBaseFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBaseInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroIngresado);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "basenum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BASES NUMERICAS";
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox txtNumeroIngresado;
        private Label label3;
        private ComboBox cmbBaseInicial;
        private Label label4;
        private ComboBox cmbBaseFinal;
        private TextBox txtResultado;
        private Button btnConvertir;
        private Label label1;
        private PictureBox btnlimpiar2;
        private PictureBox btnvolver;
    }
}