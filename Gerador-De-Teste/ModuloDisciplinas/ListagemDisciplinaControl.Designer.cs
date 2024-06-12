namespace Gerador_De_Teste.ModuloDisciplinas
{
    partial class ListagemDisciplinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listDisciplinas = new ListBox();
            SuspendLayout();
            // 
            // listDisciplinas
            // 
            listDisciplinas.Dock = DockStyle.Fill;
            listDisciplinas.FormattingEnabled = true;
            listDisciplinas.Location = new Point(0, 0);
            listDisciplinas.Name = "listDisciplinas";
            listDisciplinas.Size = new Size(657, 404);
            listDisciplinas.TabIndex = 0;
            listDisciplinas.SelectedIndexChanged += listDisciplinas_SelectedIndexChanged;
            // 
            // ListagemDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listDisciplinas);
            Name = "ListagemDisciplinaControl";
            Size = new Size(657, 404);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listDisciplinas;
    }
}
