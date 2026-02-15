namespace SistemaMvc_EleccionesReina
{
    partial class FrmMenu
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
            btnInscripcion = new Button();
            btnVerCandidatas = new Button();
            SuspendLayout();
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = SystemColors.GradientActiveCaption;
            btnInscripcion.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscripcion.Location = new Point(382, 177);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(522, 172);
            btnInscripcion.TabIndex = 0;
            btnInscripcion.Text = "Inscribir Candidata";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnVerCandidatas
            // 
            btnVerCandidatas.BackColor = SystemColors.GradientActiveCaption;
            btnVerCandidatas.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerCandidatas.Location = new Point(382, 435);
            btnVerCandidatas.Name = "btnVerCandidatas";
            btnVerCandidatas.Size = new Size(522, 172);
            btnVerCandidatas.TabIndex = 1;
            btnVerCandidatas.Text = "Ver Candidatas";
            btnVerCandidatas.UseVisualStyleBackColor = false;
            btnVerCandidatas.Click += btnVerCandidatas_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 761);
            Controls.Add(btnVerCandidatas);
            Controls.Add(btnInscripcion);
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscripcion;
        private Button btnVerCandidatas;
    }
}