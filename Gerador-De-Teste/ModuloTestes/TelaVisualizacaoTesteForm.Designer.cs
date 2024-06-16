namespace Gerador_De_Teste.ModuloTestes
{
    partial class TelaVisualizacaoTesteForm
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
            listBox1 = new ListBox();
            lblTitulo = new Label();
            lblMatematica = new Label();
            lblMateria = new Label();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 75);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 113);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 460);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas:";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(3, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(525, 427);
            listBox1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(115, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(84, 28);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "lblTitulo";
            // 
            // lblMatematica
            // 
            lblMatematica.AutoSize = true;
            lblMatematica.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatematica.Location = new Point(115, 75);
            lblMatematica.Name = "lblMatematica";
            lblMatematica.Size = new Size(137, 28);
            lblMatematica.TabIndex = 5;
            lblMatematica.Text = "lblMatematica";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMateria.Location = new Point(115, 113);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(101, 28);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "lblMateria";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(405, 610);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(135, 34);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // TelaVisualizacaoTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 656);
            Controls.Add(btnFechar);
            Controls.Add(lblMateria);
            Controls.Add(lblMatematica);
            Controls.Add(lblTitulo);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVisualizacaoTesteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualização de Teste";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label lblTitulo;
        private Label lblMatematica;
        private Label lblMateria;
        private Button btnFechar;
    }
}