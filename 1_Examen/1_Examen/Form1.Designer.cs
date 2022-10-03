namespace _1_Examen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmonedas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.dvgconversion = new System.Windows.Forms.GroupBox();
            this.japtext = new System.Windows.Forms.TextBox();
            this.eurtext = new System.Windows.Forms.TextBox();
            this.cadtext = new System.Windows.Forms.TextBox();
            this.usatext = new System.Windows.Forms.TextBox();
            this.mextext = new System.Windows.Forms.TextBox();
            this.lblJap = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.lblCad = new System.Windows.Forms.Label();
            this.lblUsa = new System.Windows.Forms.Label();
            this.lblMex = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dvgconversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moneda";
            // 
            // txtmonedas
            // 
            this.txtmonedas.FormattingEnabled = true;
            this.txtmonedas.Items.AddRange(new object[] {
            "USD - Dólar estadounidense",
            "MXN-Peso Mexicano",
            "CAD - Dólar canadiense",
            "Eur-Euros",
            "JYP-Yen Japones"});
            this.txtmonedas.Location = new System.Drawing.Point(12, 27);
            this.txtmonedas.Name = "txtmonedas";
            this.txtmonedas.Size = new System.Drawing.Size(139, 23);
            this.txtmonedas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(171, 27);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 23);
            this.txtMonto.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(187, 56);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // dvgconversion
            // 
            this.dvgconversion.Controls.Add(this.japtext);
            this.dvgconversion.Controls.Add(this.eurtext);
            this.dvgconversion.Controls.Add(this.cadtext);
            this.dvgconversion.Controls.Add(this.usatext);
            this.dvgconversion.Controls.Add(this.mextext);
            this.dvgconversion.Controls.Add(this.lblJap);
            this.dvgconversion.Controls.Add(this.lblEur);
            this.dvgconversion.Controls.Add(this.lblCad);
            this.dvgconversion.Controls.Add(this.lblUsa);
            this.dvgconversion.Controls.Add(this.lblMex);
            this.dvgconversion.Location = new System.Drawing.Point(22, 102);
            this.dvgconversion.Name = "dvgconversion";
            this.dvgconversion.Size = new System.Drawing.Size(249, 176);
            this.dvgconversion.TabIndex = 6;
            this.dvgconversion.TabStop = false;
            this.dvgconversion.Text = "Conversiones";
            this.dvgconversion.Enter += new System.EventHandler(this.dvgconversion_Enter);
            // 
            // japtext
            // 
            this.japtext.Location = new System.Drawing.Point(156, 134);
            this.japtext.Name = "japtext";
            this.japtext.Size = new System.Drawing.Size(87, 23);
            this.japtext.TabIndex = 1;
            // 
            // eurtext
            // 
            this.eurtext.Location = new System.Drawing.Point(156, 109);
            this.eurtext.Name = "eurtext";
            this.eurtext.Size = new System.Drawing.Size(87, 23);
            this.eurtext.TabIndex = 1;
            // 
            // cadtext
            // 
            this.cadtext.Location = new System.Drawing.Point(156, 83);
            this.cadtext.Name = "cadtext";
            this.cadtext.Size = new System.Drawing.Size(87, 23);
            this.cadtext.TabIndex = 1;
            // 
            // usatext
            // 
            this.usatext.Location = new System.Drawing.Point(156, 56);
            this.usatext.Name = "usatext";
            this.usatext.Size = new System.Drawing.Size(87, 23);
            this.usatext.TabIndex = 1;
            // 
            // mextext
            // 
            this.mextext.Location = new System.Drawing.Point(156, 30);
            this.mextext.Name = "mextext";
            this.mextext.Size = new System.Drawing.Size(87, 23);
            this.mextext.TabIndex = 1;
            // 
            // lblJap
            // 
            this.lblJap.AutoSize = true;
            this.lblJap.Location = new System.Drawing.Point(0, 137);
            this.lblJap.Name = "lblJap";
            this.lblJap.Size = new System.Drawing.Size(99, 15);
            this.lblJap.TabIndex = 0;
            this.lblJap.Text = "JPY - Yen japonés";
            this.lblJap.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Location = new System.Drawing.Point(0, 109);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(63, 15);
            this.lblEur.TabIndex = 0;
            this.lblEur.Text = "EUR - Euro";
            this.lblEur.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.Location = new System.Drawing.Point(0, 83);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(132, 15);
            this.lblCad.TabIndex = 0;
            this.lblCad.Text = "CAD - Dólar canadiense";
            this.lblCad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsa
            // 
            this.lblUsa.AutoSize = true;
            this.lblUsa.Location = new System.Drawing.Point(0, 58);
            this.lblUsa.Name = "lblUsa";
            this.lblUsa.Size = new System.Drawing.Size(154, 15);
            this.lblUsa.TabIndex = 0;
            this.lblUsa.Text = "USD - Dólar estadounidense";
            this.lblUsa.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMex
            // 
            this.lblMex.AutoSize = true;
            this.lblMex.Location = new System.Drawing.Point(0, 30);
            this.lblMex.Name = "lblMex";
            this.lblMex.Size = new System.Drawing.Size(125, 15);
            this.lblMex.TabIndex = 0;
            this.lblMex.Text = "MXN - Peso mexicano";
            this.lblMex.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 290);
            this.Controls.Add(this.dvgconversion);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmonedas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dvgconversion.ResumeLayout(false);
            this.dvgconversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox txtmonedas;
        private Label label3;
        private TextBox txtMonto;
        private Button btncalcular;
        private GroupBox dvgconversion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblMex;
        private Label lblEur;
        private Label lblCad;
        private Label lblUsa;
        private TextBox japtext;
        private TextBox eurtext;
        private TextBox cadtext;
        private TextBox usatext;
        private TextBox mextext;
        private Label lblJap;
    }
}