namespace AtividadeClinica
{
    partial class TelaPaciente
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxCid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDoe = new System.Windows.Forms.TextBox();
            this.dgvPasc = new System.Windows.Forms.DataGridView();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExc = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(246, 87);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(165, 27);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(42, 87);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(490, 87);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(130, 27);
            this.textBoxIdade.TabIndex = 5;
            // 
            // textBoxCid
            // 
            this.textBoxCid.Location = new System.Drawing.Point(74, 147);
            this.textBoxCid.Name = "textBoxCid";
            this.textBoxCid.Size = new System.Drawing.Size(166, 27);
            this.textBoxCid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(318, 147);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(166, 27);
            this.textBoxCPF.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Doença";
            // 
            // textBoxDoe
            // 
            this.textBoxDoe.Location = new System.Drawing.Point(585, 147);
            this.textBoxDoe.Name = "textBoxDoe";
            this.textBoxDoe.Size = new System.Drawing.Size(166, 27);
            this.textBoxDoe.TabIndex = 11;
            // 
            // dgvPasc
            // 
            this.dgvPasc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPasc.Location = new System.Drawing.Point(12, 212);
            this.dgvPasc.Name = "dgvPasc";
            this.dgvPasc.RowHeadersWidth = 51;
            this.dgvPasc.RowTemplate.Height = 29;
            this.dgvPasc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasc.Size = new System.Drawing.Size(739, 257);
            this.dgvPasc.TabIndex = 12;
            this.dgvPasc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasc_CellContentClick);
            this.dgvPasc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasc_CellContentClick);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(585, 497);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(166, 54);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExc
            // 
            this.buttonExc.Location = new System.Drawing.Point(12, 497);
            this.buttonExc.Name = "buttonExc";
            this.buttonExc.Size = new System.Drawing.Size(166, 54);
            this.buttonExc.TabIndex = 14;
            this.buttonExc.Text = "Excluir";
            this.buttonExc.UseVisualStyleBackColor = true;
            this.buttonExc.Click += new System.EventHandler(this.buttonExc_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(289, 497);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 54);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 12);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(106, 40);
            this.buttonVoltar.TabIndex = 16;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // TelaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 586);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonExc);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dgvPasc);
            this.Controls.Add(this.textBoxDoe);
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
            this.Name = "TelaPaciente";
            this.Text = "TelaPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private TextBox textBoxID;
        private Label label3;
        private TextBox textBoxIdade;
        private TextBox textBoxCid;
        private Label label4;
        private TextBox textBoxCPF;
        private Label label5;
        private Label label6;
        private TextBox textBoxDoe;
        private DataGridView dgvPasc;
        private Button buttonSalvar;
        private Button buttonExc;
        private Button buttonEdit;
        private Button buttonVoltar;
    }
}