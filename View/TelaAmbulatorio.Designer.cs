namespace AtividadeClinica
{
    partial class TelaAmbulatorio
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
            this.dgvAmb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNroa = new System.Windows.Forms.TextBox();
            this.textBoxAndar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmb
            // 
            this.dgvAmb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAmb.Location = new System.Drawing.Point(83, 149);
            this.dgvAmb.Name = "dgvAmb";
            this.dgvAmb.RowHeadersWidth = 51;
            this.dgvAmb.RowTemplate.Height = 29;
            this.dgvAmb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmb.Size = new System.Drawing.Size(539, 265);
            this.dgvAmb.TabIndex = 0;
            this.dgvAmb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmb_CellContentClick);
            this.dgvAmb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmb_CellContentClick);
            this.dgvAmb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmb_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NROA";
            // 
            // textBoxNroa
            // 
            this.textBoxNroa.Location = new System.Drawing.Point(68, 102);
            this.textBoxNroa.Name = "textBoxNroa";
            this.textBoxNroa.Size = new System.Drawing.Size(125, 27);
            this.textBoxNroa.TabIndex = 2;
            // 
            // textBoxAndar
            // 
            this.textBoxAndar.Location = new System.Drawing.Point(285, 102);
            this.textBoxAndar.Name = "textBoxAndar";
            this.textBoxAndar.Size = new System.Drawing.Size(125, 27);
            this.textBoxAndar.TabIndex = 4;
            this.textBoxAndar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Andar";
            // 
            // textBoxCap
            // 
            this.textBoxCap.Location = new System.Drawing.Point(557, 99);
            this.textBoxCap.Name = "textBoxCap";
            this.textBoxCap.Size = new System.Drawing.Size(139, 27);
            this.textBoxCap.TabIndex = 6;
            this.textBoxCap.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacidade";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(533, 450);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(163, 55);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(280, 450);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 55);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // TelaAmbulatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 530);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAndar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNroa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAmb);
            this.Name = "TelaAmbulatorio";
            this.Text = "TelaAmbulatorio";
            this.Load += new System.EventHandler(this.TelaAmbulatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAmb;
        private Label label1;
        private TextBox textBoxNroa;
        private TextBox textBoxAndar;
        private Label label2;
        private TextBox textBoxCap;
        private Label label3;
        private Button buttonSalvar;
        private Button button2;
        private Button buttonEdit;
    }
}