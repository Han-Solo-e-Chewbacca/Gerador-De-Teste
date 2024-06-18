namespace Gerador_De_Teste.ModuloTestes
{
    partial class TelaVisualizacaoTeste
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            btnFechar = new Button();
            lblTitulo = new Label();
            lblDisciplina = new Label();
            lblMateria = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 143);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 384);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.BackColor = SystemColors.Control;
            listQuestoes.Dock = DockStyle.Fill;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 28;
            listQuestoes.Location = new Point(3, 30);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(500, 351);
            listQuestoes.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(381, 618);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(134, 45);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(119, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(84, 28);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "lblTitulo";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(119, 88);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(118, 28);
            lblDisciplina.TabIndex = 6;
            lblDisciplina.Text = "lblDisciplina";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMateria.Location = new Point(119, 143);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(101, 28);
            lblMateria.TabIndex = 7;
            lblMateria.Text = "lblMateria";
            // 
            // TelaVisualizacaoTeste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 675);
            Controls.Add(lblMateria);
            Controls.Add(lblDisciplina);
            Controls.Add(lblTitulo);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVisualizacaoTeste";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualização de Testes";
            Load += TelaVisualizacaoTeste_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnFechar;
        private Label lblTitulo;
        private Label lblDisciplina;
        private Label lblMateria;
        private ListBox listQuestoes;
    }
}