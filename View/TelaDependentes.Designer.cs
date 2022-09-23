namespace AtividadeClinica
{
    partial class TelaDependentes
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonExc = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDep = new System.Windows.Forms.DataGridView();
            this.textBoxNasc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDep)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(359, 482);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 55);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonExc
            // 
            this.buttonExc.Location = new System.Drawing.Point(60, 482);
            this.buttonExc.Name = "buttonExc";
            this.buttonExc.Size = new System.Drawing.Size(163, 55);
            this.buttonExc.TabIndex = 18;
            this.buttonExc.Text = "Excluir";
            this.buttonExc.UseVisualStyleBackColor = true;
            this.buttonExc.Click += new System.EventHandler(this.buttonExc_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(641, 482);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(163, 55);
            this.buttonSalvar.TabIndex = 17;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(562, 85);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(242, 27);
            this.textBoxNome.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome";
            // 
            // textBoxFunc
            // 
            this.textBoxFunc.Location = new System.Drawing.Point(359, 85);
            this.textBoxFunc.Name = "textBoxFunc";
            this.textBoxFunc.Size = new System.Drawing.Size(125, 27);
            this.textBoxFunc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Funcionario";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(90, 85);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 12;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // dgvDep
            // 
            this.dgvDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDep.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDep.Location = new System.Drawing.Point(60, 200);
            this.dgvDep.Name = "dgvDep";
            this.dgvDep.RowHeadersWidth = 51;
            this.dgvDep.RowTemplate.Height = 29;
            this.dgvDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDep.Size = new System.Drawing.Size(744, 265);
            this.dgvDep.TabIndex = 10;
            this.dgvDep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDep_CellContentClick);
            this.dgvDep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDep_CellContentClick);
            // 
            // textBoxNasc
            // 
            this.textBoxNasc.Location = new System.Drawing.Point(154, 138);
            this.textBoxNasc.Name = "textBoxNasc";
            this.textBoxNasc.Size = new System.Drawing.Size(139, 27);
            this.textBoxNasc.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nascimento";
            // 
            // TelaDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 572);
            this.Controls.Add(this.textBoxNasc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonExc);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDep);
            this.Name = "TelaDependentes";
            this.Text = "TelaDependentes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEdit;
        private Button buttonExc;
        private Button buttonSalvar;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxFunc;
        private Label label2;
        private TextBox textBoxID;
        private Label label1;
        private DataGridView dgvDep;
        private TextBox textBoxNasc;
        private Label label4;
    }
}