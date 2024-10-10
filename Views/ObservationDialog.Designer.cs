namespace Prospect_System.Views
{
    partial class ObservationDialog
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
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            label2 = new Label();
            rchObservations = new RichTextBox();
            AcceptBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(368, 15);
            label1.TabIndex = 0;
            label1.Text = "Es necesario proporcionar observaciones para rechazar al prospecto. ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 45);
            label2.Name = "label2";
            label2.Size = new Size(229, 15);
            label2.TabIndex = 1;
            label2.Text = "Por favor, ingresa los motivos del rechazo.";
            // 
            // rchObservations
            // 
            rchObservations.Location = new Point(24, 73);
            rchObservations.Name = "rchObservations";
            rchObservations.Size = new Size(444, 183);
            rchObservations.TabIndex = 2;
            rchObservations.Text = "";
            // 
            // AcceptBtn
            // 
            AcceptBtn.BackColor = SystemColors.Control;
            AcceptBtn.Location = new Point(355, 272);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(113, 30);
            AcceptBtn.TabIndex = 3;
            AcceptBtn.Text = "Aceptar";
            AcceptBtn.UseVisualStyleBackColor = false;
            AcceptBtn.Click += AcceptBtn_Click;
            // 
            // ObservationDialog
            // 
            AcceptButton = AcceptBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 323);
            ControlBox = false;
            Controls.Add(AcceptBtn);
            Controls.Add(rchObservations);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ObservationDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Observaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Label label1;
        private Label label2;
        private RichTextBox rchObservations;
        private Button AcceptBtn;
    }
}