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
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(31, 12);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(319, 50);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUno.Location = new Point(31, 233);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(45, 45);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDos.Location = new Point(93, 233);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(45, 45);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTres.Location = new Point(156, 233);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(45, 45);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuatro.Location = new Point(31, 182);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(45, 45);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCinco.Location = new Point(93, 182);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(45, 45);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeis.Location = new Point(156, 182);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(45, 45);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNueve.Location = new Point(156, 131);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(45, 45);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOcho.Location = new Point(93, 131);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(45, 45);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiete.Location = new Point(31, 131);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(45, 45);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuitar.Location = new Point(156, 80);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(45, 45);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrartodo
            // 
            btnBorrartodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrartodo.Location = new Point(93, 80);
            btnBorrartodo.Name = "btnBorrartodo";
            btnBorrartodo.Size = new Size(45, 45);
            btnBorrartodo.TabIndex = 11;
            btnBorrartodo.Text = "C";
            btnBorrartodo.UseVisualStyleBackColor = true;
            btnBorrartodo.Click += btnBorrartodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(31, 80);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(45, 45);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuadrado.Location = new Point(293, 80);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(45, 45);
            btnCuadrado.TabIndex = 14;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaiz.Location = new Point(228, 80);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(45, 45);
            btnRaiz.TabIndex = 13;
            btnRaiz.Tag = "√";
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += clickOperador;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicacion.Location = new Point(293, 131);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(45, 45);
            btnMultiplicacion.TabIndex = 16;
            btnMultiplicacion.Tag = "x";
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += clickOperador;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivision.Location = new Point(228, 131);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(45, 45);
            btnDivision.TabIndex = 15;
            btnDivision.Tag = "/";
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += clickOperador;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnResta.Location = new Point(293, 182);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(45, 45);
            btnResta.TabIndex = 18;
            btnResta.Tag = "-";
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += clickOperador;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuma.Location = new Point(228, 182);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(45, 45);
            btnSuma.TabIndex = 17;
            btnSuma.Tag = "+";
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnResultado.Location = new Point(228, 233);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(110, 45);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.Location = new Point(156, 284);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(45, 45);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCero.Location = new Point(93, 284);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(45, 45);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSigno.Location = new Point(31, 284);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(45, 45);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 379);
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
    }
}