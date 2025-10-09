namespace Calculadora
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            lblPrimerOperando = new Label();
            lblSegundoOperando = new Label();
            btnSuma = new Button();
            btnRestar = new Button();
            btnMultiplocar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(184, 178);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.PlaceholderText = "Ingrese un número";
            txtPrimerOperando.Size = new Size(144, 23);
            txtPrimerOperando.TabIndex = 0;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(357, 178);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.PlaceholderText = "Ingrese un número";
            txtSegundoOperando.Size = new Size(144, 23);
            txtSegundoOperando.TabIndex = 1;
            txtSegundoOperando.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.ForeColor = SystemColors.ButtonHighlight;
            lblPrimerOperando.Location = new Point(184, 143);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(96, 15);
            lblPrimerOperando.TabIndex = 2;
            lblPrimerOperando.Text = "Primer operando";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.ForeColor = SystemColors.ButtonHighlight;
            lblSegundoOperando.Location = new Point(393, 143);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(108, 15);
            lblSegundoOperando.TabIndex = 3;
            lblSegundoOperando.Text = "Segundo operando";
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSuma.Location = new Point(68, 65);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(37, 34);
            btnSuma.TabIndex = 4;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRestar.Location = new Point(68, 133);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(37, 34);
            btnRestar.TabIndex = 5;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += this.btnRestar_Click;
            // 
            // btnMultiplocar
            // 
            btnMultiplocar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMultiplocar.Location = new Point(25, 98);
            btnMultiplocar.Name = "btnMultiplocar";
            btnMultiplocar.Size = new Size(37, 34);
            btnMultiplocar.TabIndex = 6;
            btnMultiplocar.Text = "x";
            btnMultiplocar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDividir.Location = new Point(111, 98);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(37, 34);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.DarkGreen;
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.GreenYellow;
            lblResultado.Location = new Point(184, 32);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(317, 79);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "0";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(560, 240);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplocar);
            Controls.Add(btnRestar);
            Controls.Add(btnSuma);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblPrimerOperando);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private Label lblPrimerOperando;
        private Label lblSegundoOperando;
        private Button btnSuma;
        private Button btnRestar;
        private Button btnMultiplocar;
        private Button btnDividir;
        private Label lblResultado;
    }
}
