namespace AtividadeClinica
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
            this.buttonDep = new System.Windows.Forms.Button();
            this.buttonAmb = new System.Windows.Forms.Button();
            this.buttonPac = new System.Windows.Forms.Button();
            this.ButtonMed = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDep
            // 
            this.buttonDep.Location = new System.Drawing.Point(509, 316);
            this.buttonDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDep.Name = "buttonDep";
            this.buttonDep.Size = new System.Drawing.Size(198, 84);
            this.buttonDep.TabIndex = 9;
            this.buttonDep.Text = "Dependentes";
            this.buttonDep.UseVisualStyleBackColor = true;
            this.buttonDep.Click += new System.EventHandler(this.buttonDep_Click);
            // 
            // buttonAmb
            // 
            this.buttonAmb.Location = new System.Drawing.Point(509, 184);
            this.buttonAmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAmb.Name = "buttonAmb";
            this.buttonAmb.Size = new System.Drawing.Size(198, 84);
            this.buttonAmb.TabIndex = 11;
            this.buttonAmb.Text = "Ambulatório";
            this.buttonAmb.UseVisualStyleBackColor = true;
            this.buttonAmb.Click += new System.EventHandler(this.buttonAmb_Click);
            // 
            // buttonPac
            // 
            this.buttonPac.Location = new System.Drawing.Point(509, 50);
            this.buttonPac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPac.Name = "buttonPac";
            this.buttonPac.Size = new System.Drawing.Size(198, 84);
            this.buttonPac.TabIndex = 8;
            this.buttonPac.Text = "Pacientes";
            this.buttonPac.UseVisualStyleBackColor = true;
            this.buttonPac.Click += new System.EventHandler(this.buttonPac_Click);
            // 
            // ButtonMed
            // 
            this.ButtonMed.Location = new System.Drawing.Point(94, 50);
            this.ButtonMed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonMed.Name = "ButtonMed";
            this.ButtonMed.Size = new System.Drawing.Size(198, 84);
            this.ButtonMed.TabIndex = 6;
            this.ButtonMed.Text = "Medicos";
            this.ButtonMed.UseVisualStyleBackColor = true;
            this.ButtonMed.Click += new System.EventHandler(this.ButtonMed_Click);
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(94, 184);
            this.buttonConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(198, 84);
            this.buttonConsulta.TabIndex = 10;
            this.buttonConsulta.Text = "Consultas";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonFun
            // 
            this.buttonFun.Location = new System.Drawing.Point(94, 316);
            this.buttonFun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFun.Name = "buttonFun";
            this.buttonFun.Size = new System.Drawing.Size(198, 84);
            this.buttonFun.TabIndex = 7;
            this.buttonFun.Text = "Funcionarios";
            this.buttonFun.UseVisualStyleBackColor = true;
            this.buttonFun.Click += new System.EventHandler(this.buttonFun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAmb);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.buttonDep);
            this.Controls.Add(this.buttonPac);
            this.Controls.Add(this.buttonFun);
            this.Controls.Add(this.ButtonMed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDep;
        private Button buttonAmb;
        private Button buttonPac;
        private Button ButtonMed;
        private Button buttonConsulta;
        private Button buttonFun;
    }
}