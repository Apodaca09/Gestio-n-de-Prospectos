namespace Prospect_System.Views
{
    partial class ProspectsList
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
            dgvProspects = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProspects).BeginInit();
            SuspendLayout();
            // 
            // dgvProspects
            // 
            dgvProspects.BackgroundColor = SystemColors.Control;
            dgvProspects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProspects.Dock = DockStyle.Fill;
            dgvProspects.Location = new Point(0, 0);
            dgvProspects.Name = "dgvProspects";
            dgvProspects.Size = new Size(1256, 457);
            dgvProspects.TabIndex = 0;
            dgvProspects.CellClick += dgvProspects_CellClick;
            // 
            // ProspectsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvProspects);
            Name = "ProspectsList";
            Size = new Size(1256, 457);
            ((System.ComponentModel.ISupportInitialize)dgvProspects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProspects;
    }
}