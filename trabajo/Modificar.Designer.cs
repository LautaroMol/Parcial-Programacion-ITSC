namespace frontend
{
    partial class Modificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btngr = new System.Windows.Forms.Button();
            this.btnvol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modificacion de empleados";
            // 
            // txtdat
            // 
            this.txtdat.AcceptsTab = true;
            this.txtdat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdat.Location = new System.Drawing.Point(70, 45);
            this.txtdat.Multiline = true;
            this.txtdat.Name = "txtdat";
            this.txtdat.Size = new System.Drawing.Size(886, 396);
            this.txtdat.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(70, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 78);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ver datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngr
            // 
            this.btngr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btngr.Location = new System.Drawing.Point(223, 447);
            this.btngr.Name = "btngr";
            this.btngr.Size = new System.Drawing.Size(103, 78);
            this.btngr.TabIndex = 21;
            this.btngr.Text = "Guardar";
            this.btngr.UseVisualStyleBackColor = true;
            this.btngr.Click += new System.EventHandler(this.btngr_Click);
            // 
            // btnvol
            // 
            this.btnvol.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvol.Location = new System.Drawing.Point(853, 447);
            this.btnvol.Name = "btnvol";
            this.btnvol.Size = new System.Drawing.Size(103, 78);
            this.btnvol.TabIndex = 22;
            this.btnvol.Text = "volver";
            this.btnvol.UseVisualStyleBackColor = true;
            this.btnvol.Click += new System.EventHandler(this.btnvol_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 575);
            this.ControlBox = false;
            this.Controls.Add(this.btnvol);
            this.Controls.Add(this.btngr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdat);
            this.Controls.Add(this.label1);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox txtdat;
        private Button button1;
        private Button btngr;
        private Button btnvol;
    }
}