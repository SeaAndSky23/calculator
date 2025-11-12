namespace calculator
{
    partial class ASCII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASCII));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textbcd = new System.Windows.Forms.TabPage();
            this.btnvolver2 = new System.Windows.Forms.PictureBox();
            this.btnlimpiar = new System.Windows.Forms.PictureBox();
            this.txtascii = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTextoAAscii = new System.Windows.Forms.Button();
            this.txtEntradaa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bcdtext = new System.Windows.Forms.TabPage();
            this.btnvolver = new System.Windows.Forms.PictureBox();
            this.btnlimpiar1 = new System.Windows.Forms.PictureBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsciiATexto = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.textbcd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).BeginInit();
            this.bcdtext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE EL NÚMERO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.textbcd);
            this.tabControl1.Controls.Add(this.bcdtext);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 461);
            this.tabControl1.TabIndex = 1;
            // 
            // textbcd
            // 
            this.textbcd.Controls.Add(this.btnvolver2);
            this.textbcd.Controls.Add(this.btnlimpiar);
            this.textbcd.Controls.Add(this.txtascii);
            this.textbcd.Controls.Add(this.label3);
            this.textbcd.Controls.Add(this.btnTextoAAscii);
            this.textbcd.Controls.Add(this.txtEntradaa);
            this.textbcd.Controls.Add(this.label4);
            this.textbcd.Location = new System.Drawing.Point(4, 22);
            this.textbcd.Name = "textbcd";
            this.textbcd.Padding = new System.Windows.Forms.Padding(3);
            this.textbcd.Size = new System.Drawing.Size(826, 435);
            this.textbcd.TabIndex = 1;
            this.textbcd.Text = "TEXTO A ASCII";
            this.textbcd.UseVisualStyleBackColor = true;
            // 
            // btnvolver2
            // 
            this.btnvolver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver2.Image = ((System.Drawing.Image)(resources.GetObject("btnvolver2.Image")));
            this.btnvolver2.Location = new System.Drawing.Point(791, 3);
            this.btnvolver2.Name = "btnvolver2";
            this.btnvolver2.Size = new System.Drawing.Size(32, 32);
            this.btnvolver2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver2.TabIndex = 11;
            this.btnvolver2.TabStop = false;
            this.btnvolver2.Click += new System.EventHandler(this.btnvolver2_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(783, 396);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(35, 36);
            this.btnlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.TabStop = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtascii
            // 
            this.txtascii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtascii.Location = new System.Drawing.Point(71, 275);
            this.txtascii.Multiline = true;
            this.txtascii.Name = "txtascii";
            this.txtascii.Size = new System.Drawing.Size(726, 75);
            this.txtascii.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "RESULTADO EN ASCII";
            // 
            // btnTextoAAscii
            // 
            this.btnTextoAAscii.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTextoAAscii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTextoAAscii.FlatAppearance.BorderSize = 2;
            this.btnTextoAAscii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextoAAscii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextoAAscii.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTextoAAscii.Location = new System.Drawing.Point(370, 154);
            this.btnTextoAAscii.Name = "btnTextoAAscii";
            this.btnTextoAAscii.Size = new System.Drawing.Size(126, 34);
            this.btnTextoAAscii.TabIndex = 7;
            this.btnTextoAAscii.Text = "CONVERTIR";
            this.btnTextoAAscii.UseVisualStyleBackColor = false;
            this.btnTextoAAscii.Click += new System.EventHandler(this.btnTextoAAscii_Click);
            // 
            // txtEntradaa
            // 
            this.txtEntradaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntradaa.Location = new System.Drawing.Point(71, 82);
            this.txtEntradaa.Multiline = true;
            this.txtEntradaa.Name = "txtEntradaa";
            this.txtEntradaa.Size = new System.Drawing.Size(726, 47);
            this.txtEntradaa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "INGRESE EL TEXTO";
            // 
            // bcdtext
            // 
            this.bcdtext.Controls.Add(this.btnvolver);
            this.bcdtext.Controls.Add(this.btnlimpiar1);
            this.bcdtext.Controls.Add(this.txtResultado);
            this.bcdtext.Controls.Add(this.label2);
            this.bcdtext.Controls.Add(this.btnAsciiATexto);
            this.bcdtext.Controls.Add(this.txtEntrada);
            this.bcdtext.Controls.Add(this.label1);
            this.bcdtext.Location = new System.Drawing.Point(4, 22);
            this.bcdtext.Name = "bcdtext";
            this.bcdtext.Padding = new System.Windows.Forms.Padding(3);
            this.bcdtext.Size = new System.Drawing.Size(826, 435);
            this.bcdtext.TabIndex = 0;
            this.bcdtext.Text = "ASCII A TEXTO";
            this.bcdtext.UseVisualStyleBackColor = true;
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Image = ((System.Drawing.Image)(resources.GetObject("btnvolver.Image")));
            this.btnvolver.Location = new System.Drawing.Point(786, 3);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(32, 32);
            this.btnvolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver.TabIndex = 6;
            this.btnvolver.TabStop = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnlimpiar1
            // 
            this.btnlimpiar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar1.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar1.Image")));
            this.btnlimpiar1.Location = new System.Drawing.Point(783, 393);
            this.btnlimpiar1.Name = "btnlimpiar1";
            this.btnlimpiar1.Size = new System.Drawing.Size(35, 36);
            this.btnlimpiar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlimpiar1.TabIndex = 5;
            this.btnlimpiar1.TabStop = false;
            this.btnlimpiar1.Click += new System.EventHandler(this.btnlimpiar1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(71, 290);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(726, 66);
            this.txtResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESULTADO";
            // 
            // btnAsciiATexto
            // 
            this.btnAsciiATexto.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAsciiATexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsciiATexto.FlatAppearance.BorderSize = 2;
            this.btnAsciiATexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsciiATexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsciiATexto.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAsciiATexto.Location = new System.Drawing.Point(370, 148);
            this.btnAsciiATexto.Name = "btnAsciiATexto";
            this.btnAsciiATexto.Size = new System.Drawing.Size(126, 34);
            this.btnAsciiATexto.TabIndex = 2;
            this.btnAsciiATexto.Text = "CONVERTIR";
            this.btnAsciiATexto.UseVisualStyleBackColor = false;
            this.btnAsciiATexto.Click += new System.EventHandler(this.btnAsciiATexto_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(71, 76);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(726, 47);
            this.txtEntrada.TabIndex = 1;
            // 
            // ASCII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ASCII";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASCII";
            this.tabControl1.ResumeLayout(false);
            this.textbcd.ResumeLayout(false);
            this.textbcd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).EndInit();
            this.bcdtext.ResumeLayout(false);
            this.bcdtext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bcdtext;
        private System.Windows.Forms.TabPage textbcd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsciiATexto;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtascii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTextoAAscii;
        private System.Windows.Forms.TextBox txtEntradaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnlimpiar;
        private System.Windows.Forms.PictureBox btnlimpiar1;
        private System.Windows.Forms.PictureBox btnvolver2;
        private System.Windows.Forms.PictureBox btnvolver;
    }
}