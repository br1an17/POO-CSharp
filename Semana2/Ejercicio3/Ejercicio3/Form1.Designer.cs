namespace Ejercicio3
{
    partial class frmIngreso
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
            btnAceptar = new Button();
            label1 = new Label();
            lblDato1 = new Label();
            txtDato1 = new TextBox();
            txtDato2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(277, 236);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(200, 68);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 170);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 1;
            label1.Text = "DATO 2";
            // 
            // lblDato1
            // 
            lblDato1.AutoSize = true;
            lblDato1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDato1.Location = new Point(141, 47);
            lblDato1.Name = "lblDato1";
            lblDato1.Size = new Size(84, 28);
            lblDato1.TabIndex = 2;
            lblDato1.Text = "DATO 1";
            // 
            // txtDato1
            // 
            txtDato1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDato1.Location = new Point(277, 47);
            txtDato1.Name = "txtDato1";
            txtDato1.Size = new Size(294, 34);
            txtDato1.TabIndex = 3;
            txtDato1.TextChanged += txtDato1_TextChanged;
            // 
            // txtDato2
            // 
            txtDato2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDato2.Location = new Point(277, 170);
            txtDato2.Name = "txtDato2";
            txtDato2.Size = new Size(294, 34);
            txtDato2.TabIndex = 4;
            txtDato2.TextChanged += txtDato2_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(277, 342);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(200, 70);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtDato2);
            Controls.Add(txtDato1);
            Controls.Add(lblDato1);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "frmIngreso";
            Text = "INGRESO Y MUESTRA DE DATOS";
            Load += frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        private Label lblDato1;
        private TextBox txtDato1;
        private TextBox txtDato2;
        private Button btnCalcular;
    }
}
