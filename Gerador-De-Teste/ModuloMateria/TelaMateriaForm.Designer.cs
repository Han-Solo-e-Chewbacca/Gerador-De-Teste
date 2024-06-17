namespace Gerador_De_Teste.ModuloMateria
{
    partial class TelaMateriaForm
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
            txtId = new TextBox();
            txtNome = new TextBox();
            cbDisciplina = new ComboBox();
            cbmSerie = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(118, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(68, 27);
            txtId.TabIndex = 0;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(118, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(440, 27);
            txtNome.TabIndex = 1;
            // 
            // cbDisciplina
            // 
            cbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(118, 114);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(128, 28);
            cbDisciplina.TabIndex = 2;
            cbDisciplina.SelectedIndexChanged += cbDisciplina_SelectedIndexChanged;
            // 
            // cbmSerie
            // 
            cbmSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmSerie.FormattingEnabled = true;
            cbmSerie.Items.AddRange(new object[] { "1º ano", "2º ano" });
            cbmSerie.Location = new Point(118, 148);
            cbmSerie.Name = "cbmSerie";
            cbmSerie.Size = new Size(128, 28);
            cbmSerie.TabIndex = 3;
            cbmSerie.SelectedIndexChanged += cbmSerie_SelectedIndexChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(282, 196);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(135, 51);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.OK;
            btnCancelar.Location = new Point(423, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 51);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 48);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 11;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 12;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 13;
            label3.Text = "Disciplina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 148);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 14;
            label4.Text = "Série:";
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 259);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cbmSerie);
            Controls.Add(cbDisciplina);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Matérias";
            Load += TelaMateriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private ComboBox cbDisciplina;
        private ComboBox cbmSerie;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}