namespace trabajo
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtap = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.iramod = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.canttxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "carga de empleado";
            // 
            // txtnom
            // 
            this.txtnom.AcceptsTab = true;
            this.txtnom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnom.Location = new System.Drawing.Point(299, 77);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(354, 33);
            this.txtnom.TabIndex = 1;
            this.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtap
            // 
            this.txtap.AcceptsTab = true;
            this.txtap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtap.Location = new System.Drawing.Point(299, 140);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(354, 33);
            this.txtap.TabIndex = 2;
            this.txtap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtpuesto
            // 
            this.txtpuesto.AcceptsTab = true;
            this.txtpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpuesto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtpuesto.Location = new System.Drawing.Point(299, 195);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(354, 33);
            this.txtpuesto.TabIndex = 3;
            this.txtpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdni
            // 
            this.txtdni.AcceptsTab = true;
            this.txtdni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdni.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdni.Location = new System.Drawing.Point(299, 260);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(354, 33);
            this.txtdni.TabIndex = 4;
            this.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puesto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dni";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.limpiar.Location = new System.Drawing.Point(12, 333);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(114, 56);
            this.limpiar.TabIndex = 9;
            this.limpiar.Text = "limpiar registro";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(178, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 56);
            this.button3.TabIndex = 10;
            this.button3.Text = "Crear archivo y agregar empleado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iramod
            // 
            this.iramod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iramod.Location = new System.Drawing.Point(339, 333);
            this.iramod.Name = "iramod";
            this.iramod.Size = new System.Drawing.Size(114, 56);
            this.iramod.TabIndex = 11;
            this.iramod.Text = "Ir a modificar empleado";
            this.iramod.UseVisualStyleBackColor = true;
            this.iramod.Click += new System.EventHandler(this.iramod_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salir.Location = new System.Drawing.Point(493, 333);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(114, 56);
            this.salir.TabIndex = 13;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // canttxt
            // 
            this.canttxt.AcceptsTab = true;
            this.canttxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canttxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.canttxt.Location = new System.Drawing.Point(299, 446);
            this.canttxt.MaxLength = 8;
            this.canttxt.Name = "canttxt";
            this.canttxt.ReadOnly = true;
            this.canttxt.Size = new System.Drawing.Size(354, 33);
            this.canttxt.TabIndex = 14;
            this.canttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Empleados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contar
            // 
            this.contar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contar.Location = new System.Drawing.Point(12, 396);
            this.contar.Name = "contar";
            this.contar.Size = new System.Drawing.Size(195, 47);
            this.contar.TabIndex = 16;
            this.contar.Text = "Contar empleados";
            this.contar.UseVisualStyleBackColor = true;
            this.contar.Click += new System.EventHandler(this.contar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 591);
            this.ControlBox = false;
            this.Controls.Add(this.contar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.canttxt);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.iramod);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.txtap);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtnom;
        private TextBox txtap;
        private TextBox txtpuesto;
        private TextBox txtdni;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button limpiar;
        private Button button3;
        private Button iramod;
        private Button salir;
        private TextBox canttxt;
        private Label label6;
        private Button contar;
    }
}