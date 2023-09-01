namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnQuitar = new Button();
            btnBorrartodo = new Button();
            btnBorrar = new Button();
            btnCuadrado = new Button();
            btnRaiz = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnResta = new Button();
            btnSuma = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnSigno = new Button();
            btnPorcentaje = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Cursor = Cursors.Hand;
            txtResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.ForeColor = SystemColors.ControlText;
            txtResultado.Location = new Point(41, 56);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(364, 69);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.White;
            btnUno.Cursor = Cursors.Hand;
            btnUno.FlatStyle = FlatStyle.System;
            btnUno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUno.ForeColor = SystemColors.ControlText;
            btnUno.Location = new Point(41, 355);
            btnUno.Margin = new Padding(3, 4, 3, 4);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(51, 60);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.White;
            btnDos.Cursor = Cursors.Hand;
            btnDos.FlatStyle = FlatStyle.System;
            btnDos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDos.ForeColor = SystemColors.ControlText;
            btnDos.Location = new Point(112, 355);
            btnDos.Margin = new Padding(3, 4, 3, 4);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(51, 60);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.White;
            btnTres.Cursor = Cursors.Hand;
            btnTres.FlatStyle = FlatStyle.System;
            btnTres.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTres.ForeColor = SystemColors.ControlText;
            btnTres.Location = new Point(184, 355);
            btnTres.Margin = new Padding(3, 4, 3, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(51, 60);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = Color.White;
            btnCuatro.Cursor = Cursors.Hand;
            btnCuatro.FlatStyle = FlatStyle.System;
            btnCuatro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuatro.ForeColor = SystemColors.ControlText;
            btnCuatro.Location = new Point(41, 287);
            btnCuatro.Margin = new Padding(3, 4, 3, 4);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(51, 60);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.White;
            btnCinco.Cursor = Cursors.Hand;
            btnCinco.FlatStyle = FlatStyle.System;
            btnCinco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCinco.ForeColor = SystemColors.ControlText;
            btnCinco.Location = new Point(112, 287);
            btnCinco.Margin = new Padding(3, 4, 3, 4);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(51, 60);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.White;
            btnSeis.Cursor = Cursors.Hand;
            btnSeis.FlatStyle = FlatStyle.System;
            btnSeis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeis.ForeColor = SystemColors.ControlText;
            btnSeis.Location = new Point(184, 287);
            btnSeis.Margin = new Padding(3, 4, 3, 4);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(51, 60);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += agregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = Color.White;
            btnNueve.Cursor = Cursors.Hand;
            btnNueve.FlatStyle = FlatStyle.System;
            btnNueve.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNueve.ForeColor = SystemColors.ControlText;
            btnNueve.Location = new Point(184, 219);
            btnNueve.Margin = new Padding(3, 4, 3, 4);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(51, 60);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = Color.White;
            btnOcho.Cursor = Cursors.Hand;
            btnOcho.FlatStyle = FlatStyle.System;
            btnOcho.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOcho.ForeColor = SystemColors.ControlText;
            btnOcho.Location = new Point(112, 219);
            btnOcho.Margin = new Padding(3, 4, 3, 4);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(51, 60);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = Color.White;
            btnSiete.Cursor = Cursors.Hand;
            btnSiete.FlatStyle = FlatStyle.System;
            btnSiete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiete.ForeColor = SystemColors.ControlText;
            btnSiete.Location = new Point(41, 219);
            btnSiete.Margin = new Padding(3, 4, 3, 4);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(51, 60);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.White;
            btnQuitar.Cursor = Cursors.Hand;
            btnQuitar.FlatStyle = FlatStyle.System;
            btnQuitar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuitar.ForeColor = SystemColors.ControlText;
            btnQuitar.Location = new Point(184, 151);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(51, 60);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrartodo
            // 
            btnBorrartodo.BackColor = Color.White;
            btnBorrartodo.Cursor = Cursors.Hand;
            btnBorrartodo.FlatStyle = FlatStyle.System;
            btnBorrartodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrartodo.ForeColor = SystemColors.ControlText;
            btnBorrartodo.Location = new Point(112, 151);
            btnBorrartodo.Margin = new Padding(3, 4, 3, 4);
            btnBorrartodo.Name = "btnBorrartodo";
            btnBorrartodo.Size = new Size(51, 60);
            btnBorrartodo.TabIndex = 11;
            btnBorrartodo.Text = "C";
            btnBorrartodo.UseVisualStyleBackColor = false;
            btnBorrartodo.Click += btnBorrartodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.White;
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.FlatStyle = FlatStyle.System;
            btnBorrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = SystemColors.ControlText;
            btnBorrar.Location = new Point(41, 151);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(51, 60);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = Color.White;
            btnCuadrado.Cursor = Cursors.Hand;
            btnCuadrado.FlatStyle = FlatStyle.System;
            btnCuadrado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuadrado.ForeColor = SystemColors.ControlText;
            btnCuadrado.Location = new Point(341, 151);
            btnCuadrado.Margin = new Padding(3, 4, 3, 4);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(51, 60);
            btnCuadrado.TabIndex = 14;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = false;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.White;
            btnRaiz.Cursor = Cursors.Hand;
            btnRaiz.FlatStyle = FlatStyle.System;
            btnRaiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaiz.ForeColor = SystemColors.ControlText;
            btnRaiz.Location = new Point(266, 151);
            btnRaiz.Margin = new Padding(3, 4, 3, 4);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(51, 60);
            btnRaiz.TabIndex = 13;
            btnRaiz.Tag = "√";
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += clickOperador;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.White;
            btnMultiplicacion.Cursor = Cursors.Hand;
            btnMultiplicacion.FlatStyle = FlatStyle.System;
            btnMultiplicacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicacion.ForeColor = SystemColors.ControlText;
            btnMultiplicacion.Location = new Point(341, 219);
            btnMultiplicacion.Margin = new Padding(3, 4, 3, 4);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(51, 60);
            btnMultiplicacion.TabIndex = 16;
            btnMultiplicacion.Tag = "x";
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += clickOperador;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.White;
            btnDivision.Cursor = Cursors.Hand;
            btnDivision.FlatStyle = FlatStyle.System;
            btnDivision.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.ForeColor = SystemColors.ControlText;
            btnDivision.Location = new Point(266, 219);
            btnDivision.Margin = new Padding(3, 4, 3, 4);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(51, 60);
            btnDivision.TabIndex = 15;
            btnDivision.Tag = "/";
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += clickOperador;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.White;
            btnResta.Cursor = Cursors.Hand;
            btnResta.FlatStyle = FlatStyle.System;
            btnResta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResta.ForeColor = SystemColors.ControlText;
            btnResta.Location = new Point(341, 287);
            btnResta.Margin = new Padding(3, 4, 3, 4);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(51, 60);
            btnResta.TabIndex = 18;
            btnResta.Tag = "-";
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += clickOperador;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.White;
            btnSuma.Cursor = Cursors.Hand;
            btnSuma.FlatStyle = FlatStyle.System;
            btnSuma.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.ForeColor = SystemColors.ControlText;
            btnSuma.Location = new Point(266, 287);
            btnSuma.Margin = new Padding(3, 4, 3, 4);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(51, 60);
            btnSuma.TabIndex = 17;
            btnSuma.Tag = "+";
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.White;
            btnResultado.Cursor = Cursors.Hand;
            btnResultado.FlatStyle = FlatStyle.System;
            btnResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResultado.ForeColor = SystemColors.ControlText;
            btnResultado.Location = new Point(266, 423);
            btnResultado.Margin = new Padding(3, 4, 3, 4);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(126, 60);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = Color.White;
            btnPunto.Cursor = Cursors.Hand;
            btnPunto.FlatStyle = FlatStyle.System;
            btnPunto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.ForeColor = SystemColors.ControlText;
            btnPunto.Location = new Point(184, 423);
            btnPunto.Margin = new Padding(3, 4, 3, 4);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(51, 60);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.White;
            btnCero.Cursor = Cursors.Hand;
            btnCero.FlatStyle = FlatStyle.System;
            btnCero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCero.ForeColor = SystemColors.ControlText;
            btnCero.Location = new Point(112, 423);
            btnCero.Margin = new Padding(3, 4, 3, 4);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(51, 60);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.BackColor = Color.White;
            btnSigno.Cursor = Cursors.Hand;
            btnSigno.FlatStyle = FlatStyle.System;
            btnSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSigno.ForeColor = SystemColors.ControlText;
            btnSigno.Location = new Point(41, 423);
            btnSigno.Margin = new Padding(3, 4, 3, 4);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(51, 60);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = false;
            btnSigno.Click += btnSigno_Click;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.BackColor = Color.White;
            btnPorcentaje.Cursor = Cursors.Hand;
            btnPorcentaje.FlatStyle = FlatStyle.System;
            btnPorcentaje.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPorcentaje.ForeColor = SystemColors.ControlText;
            btnPorcentaje.Location = new Point(266, 355);
            btnPorcentaje.Margin = new Padding(3, 4, 3, 4);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(51, 60);
            btnPorcentaje.TabIndex = 23;
            btnPorcentaje.Tag = "%";
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = false;
            btnPorcentaje.Click += clickOperador;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 12);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 24;
            label1.Text = "Casio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(447, 505);
            Controls.Add(label1);
            Controls.Add(btnPorcentaje);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnResultado);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnDivision);
            Controls.Add(btnCuadrado);
            Controls.Add(btnRaiz);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrartodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnQuitar;
        private Button btnBorrartodo;
        private Button btnBorrar;
        private Button btnCuadrado;
        private Button btnRaiz;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnResta;
        private Button btnSuma;
        private Button btnResultado;
        private Button btnPunto;
        private Button btnCero;
        private Button btnSigno;
        private Button btnPorcentaje;
        private Label label1;
    }
}