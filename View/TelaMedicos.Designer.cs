namespace AtividadeClinica
{
    partial class TelaMedicos
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
            this.textBoxNroa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonExc = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.textBoxEspc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNroa
            // 
            this.textBoxNroa.Location = new System.Drawing.Point(713, 104);
            this.textBoxNroa.Name = "textBoxNroa";
            this.textBoxNroa.Size = new System.Drawing.Size(166, 27);
            this.textBoxNroa.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "NROA";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(370, 461);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 54);
            this.buttonEdit.TabIndex = 67;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonExc
            // 
            this.buttonExc.Location = new System.Drawing.Point(13, 461);
            this.buttonExc.Name = "buttonExc";
            this.buttonExc.Size = new System.Drawing.Size(166, 54);
            this.buttonExc.TabIndex = 66;
            this.buttonExc.Text = "Excluir";
            this.buttonExc.UseVisualStyleBackColor = true;
            this.buttonExc.Click += new System.EventHandler(this.buttonExc_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(713, 461);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(166, 54);
            this.buttonSalvar.TabIndex = 65;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMed.Location = new System.Drawing.Point(13, 176);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.RowHeadersWidth = 51;
            this.dgvMed.RowTemplate.Height = 29;
            this.dgvMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMed.Size = new System.Drawing.Size(866, 257);
            this.dgvMed.TabIndex = 64;
            this.dgvMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMed_CellContentClick);
            this.dgvMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMed_CellContentClick);
            // 
            // textBoxEspc
            // 
            this.textBoxEspc.Location = new System.Drawing.Point(360, 100);
            this.textBoxEspc.Name = "textBoxEspc";
            this.textBoxEspc.Size = new System.Drawing.Size(261, 27);
            this.textBoxEspc.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Especialidade";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(52, 101);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(166, 27);
            this.textBoxCPF.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "CPF";
            // 
            // textBoxCid
            // 
            this.textBoxCid.Location = new System.Drawing.Point(713, 51);
            this.textBoxCid.Name = "textBoxCid";
            this.textBoxCid.Size = new System.Drawing.Size(166, 27);
            this.textBoxCid.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Cidade";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(491, 51);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(130, 27);
            this.textBoxIdade.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Idade";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(43, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 55;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(247, 51);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(165, 27);
            this.textBoxNome.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nome";
            // 
            // TelaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 567);
            this.Controls.Add(this.textBoxNroa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonExc);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dgvMed);
            this.Controls.Add(this.textBoxEspc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaMedicos";
            this.Text = "TelaMedicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNroa;
        private Label label7;
        private Button buttonEdit;
        private Button buttonExc;
        private Button buttonSalvar;
        private DataGridView dgvMed;
        private TextBox textBoxEspc;
        private Label label6;
        private TextBox textBoxCPF;
        private Label label5;
        private TextBox textBoxCid;
        private Label label4;
        private TextBox textBoxIdade;
        private Label label3;
        private TextBox textBoxID;
        private TextBox textBoxNome;
        private Label label2;
        private Label label1;
    }
}