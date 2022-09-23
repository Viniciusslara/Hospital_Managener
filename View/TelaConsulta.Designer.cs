namespace AtividadeClinica
{
    partial class TelaConsulta
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
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIDPac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(100, 120);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(170, 27);
            this.textBoxData.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Data";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(352, 464);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 55);
            this.buttonEdit.TabIndex = 31;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 55);
            this.button2.TabIndex = 30;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(634, 464);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(163, 55);
            this.buttonSalvar.TabIndex = 29;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(609, 126);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(188, 27);
            this.textBoxHora.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hora";
            // 
            // textBoxIDPac
            // 
            this.textBoxIDPac.Location = new System.Drawing.Point(672, 67);
            this.textBoxIDPac.Name = "textBoxIDPac";
            this.textBoxIDPac.Size = new System.Drawing.Size(125, 27);
            this.textBoxIDPac.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Funcionario";
            // 
            // textBoxIDMed
            // 
            this.textBoxIDMed.Location = new System.Drawing.Point(145, 63);
            this.textBoxIDMed.Name = "textBoxIDMed";
            this.textBoxIDMed.Size = new System.Drawing.Size(125, 27);
            this.textBoxIDMed.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID Médico";
            // 
            // dgvCons
            // 
            this.dgvCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCons.Location = new System.Drawing.Point(53, 182);
            this.dgvCons.Name = "dgvCons";
            this.dgvCons.RowHeadersWidth = 51;
            this.dgvCons.RowTemplate.Height = 29;
            this.dgvCons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCons.Size = new System.Drawing.Size(744, 265);
            this.dgvCons.TabIndex = 22;
            this.dgvCons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCons_CellContentClick);
            this.dgvCons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCons_CellContentClick);
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 540);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIDPac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDMed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCons);
            this.Name = "TelaConsulta";
            this.Text = "TelaConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxData;
        private Label label4;
        private Button buttonEdit;
        private Button button2;
        private Button buttonSalvar;
        private TextBox textBoxHora;
        private Label label3;
        private TextBox textBoxIDPac;
        private Label label2;
        private TextBox textBoxIDMed;
        private Label label1;
        private DataGridView dgvCons;
    }
}