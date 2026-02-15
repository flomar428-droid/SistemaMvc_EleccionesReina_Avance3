namespace SistemaMvc_EleccionesReina
{
    partial class FrmVerCandidatas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerCandidatas));
            dgvCandidatas = new DataGridView();
            btnVolver = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvCandidatas
            // 
            dgvCandidatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatas.Location = new Point(65, 172);
            dgvCandidatas.Name = "dgvCandidatas";
            dgvCandidatas.RowHeadersWidth = 72;
            dgvCandidatas.Size = new Size(1163, 697);
            dgvCandidatas.TabIndex = 0;
            dgvCandidatas.SelectionChanged += dgvCandidatas_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(65, 67);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(49, 46);
            btnVolver.TabIndex = 21;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(65, 116);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 22;
            label1.Text = "volver";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1263, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 227);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.VisibleChanged += dgvCandidatas_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(564, 67);
            label2.Name = "label2";
            label2.Size = new Size(418, 50);
            label2.TabIndex = 24;
            label2.Text = "LISTA DE CANDIDATAS";
            // 
            // FrmVerCandidatas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 951);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(dgvCandidatas);
            Name = "FrmVerCandidatas";
            Text = "FrmVerCandidatas";
            ((System.ComponentModel.ISupportInitialize)dgvCandidatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCandidatas;
        private Button btnVolver;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}