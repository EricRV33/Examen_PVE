namespace _1_Examen
{
    partial class Monedas
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
            this.box_mxn = new System.Windows.Forms.CheckBox();
            this.box_cad = new System.Windows.Forms.CheckBox();
            this.boxeur = new System.Windows.Forms.CheckBox();
            this.boxjpy = new System.Windows.Forms.CheckBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.boxEua = new System.Windows.Forms.CheckBox();
            this.lblayuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_mxn
            // 
            this.box_mxn.AutoSize = true;
            this.box_mxn.Location = new System.Drawing.Point(28, 26);
            this.box_mxn.Name = "box_mxn";
            this.box_mxn.Size = new System.Drawing.Size(138, 19);
            this.box_mxn.TabIndex = 0;
            this.box_mxn.Text = "MXN-Peso mexicano";
            this.box_mxn.UseVisualStyleBackColor = true;
            // 
            // box_cad
            // 
            this.box_cad.AutoSize = true;
            this.box_cad.Location = new System.Drawing.Point(28, 51);
            this.box_cad.Name = "box_cad";
            this.box_cad.Size = new System.Drawing.Size(145, 19);
            this.box_cad.TabIndex = 0;
            this.box_cad.Text = "CAD-Dolar canadiense";
            this.box_cad.UseVisualStyleBackColor = true;
            // 
            // boxeur
            // 
            this.boxeur.AutoSize = true;
            this.boxeur.Location = new System.Drawing.Point(28, 76);
            this.boxeur.Name = "boxeur";
            this.boxeur.Size = new System.Drawing.Size(76, 19);
            this.boxeur.TabIndex = 0;
            this.boxeur.Text = "EUR-Euro";
            this.boxeur.UseVisualStyleBackColor = true;
            // 
            // boxjpy
            // 
            this.boxjpy.AutoSize = true;
            this.boxjpy.Location = new System.Drawing.Point(28, 101);
            this.boxjpy.Name = "boxjpy";
            this.boxjpy.Size = new System.Drawing.Size(112, 19);
            this.boxjpy.TabIndex = 0;
            this.boxjpy.Text = "JPY-Yen japones";
            this.boxjpy.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(12, 166);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxEua
            // 
            this.boxEua.AutoSize = true;
            this.boxEua.Location = new System.Drawing.Point(28, 127);
            this.boxEua.Name = "boxEua";
            this.boxEua.Size = new System.Drawing.Size(174, 19);
            this.boxEua.TabIndex = 2;
            this.boxEua.Text = " Usd - Dolar estadounidense";
            this.boxEua.UseVisualStyleBackColor = true;
            // 
            // lblayuda
            // 
            this.lblayuda.AutoSize = true;
            this.lblayuda.Location = new System.Drawing.Point(48, 216);
            this.lblayuda.Name = "lblayuda";
            this.lblayuda.Size = new System.Drawing.Size(0, 15);
            this.lblayuda.TabIndex = 3;
            // 
            // Monedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 210);
            this.Controls.Add(this.lblayuda);
            this.Controls.Add(this.boxEua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.boxjpy);
            this.Controls.Add(this.boxeur);
            this.Controls.Add(this.box_cad);
            this.Controls.Add(this.box_mxn);
            this.Name = "Monedas";
            this.Text = "Monedas";
            this.Load += new System.EventHandler(this.Monedas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox box_mxn;
        private CheckBox box_cad;
        private CheckBox boxeur;
        private CheckBox boxjpy;
        private Button btncancelar;
        private Button button2;
        private CheckBox boxEua;
        private Label lblayuda;
    }
}