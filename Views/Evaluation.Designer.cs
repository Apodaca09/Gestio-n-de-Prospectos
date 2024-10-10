namespace Prospect_System.Views
{
    partial class Evaluation
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluation));
            cmbProspects = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AcceptBtn = new PictureBox();
            DeclineBtn = new PictureBox();
            toolTipMessage = new ToolTip(components);
            comboBox1 = new ComboBox();
            lblName = new Label();
            lblPhoneNumber = new Label();
            lblNumber = new Label();
            lblFirstLastName = new Label();
            lblRfc = new Label();
            lblColony = new Label();
            lblSecondLastName = new Label();
            lblStreet = new Label();
            lblZipCode = new Label();
            ((System.ComponentModel.ISupportInitialize)AcceptBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeclineBtn).BeginInit();
            SuspendLayout();
            // 
            // cmbProspects
            // 
            cmbProspects.FormattingEnabled = true;
            cmbProspects.Location = new Point(165, 47);
            cmbProspects.Name = "cmbProspects";
            cmbProspects.Size = new Size(420, 23);
            cmbProspects.TabIndex = 0;
            cmbProspects.Text = "Seleccionar prospecto";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(747, 218);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 28;
            label9.Text = "C.P. :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(462, 218);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 27;
            label8.Text = "Colonia:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(166, 218);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 26;
            label7.Text = "Número:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(742, 180);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 25;
            label6.Text = "Calle:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(482, 180);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 24;
            label5.Text = "RFC:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(165, 180);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 23;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(682, 143);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 22;
            label3.Text = "Segundo Apellido:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(421, 143);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 21;
            label2.Text = "Primer Apellido:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(165, 143);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombre:";
            // 
            // AcceptBtn
            // 
            AcceptBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptBtn.BackColor = Color.FromArgb(58, 236, 79);
            AcceptBtn.BorderStyle = BorderStyle.FixedSingle;
            AcceptBtn.Image = (Image)resources.GetObject("AcceptBtn.Image");
            AcceptBtn.Location = new Point(657, 318);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(100, 50);
            AcceptBtn.SizeMode = PictureBoxSizeMode.Zoom;
            AcceptBtn.TabIndex = 29;
            AcceptBtn.TabStop = false;
            // 
            // DeclineBtn
            // 
            DeclineBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeclineBtn.BackColor = Color.FromArgb(209, 26, 26);
            DeclineBtn.BorderStyle = BorderStyle.FixedSingle;
            DeclineBtn.Image = (Image)resources.GetObject("DeclineBtn.Image");
            DeclineBtn.Location = new Point(811, 318);
            DeclineBtn.Name = "DeclineBtn";
            DeclineBtn.Size = new Size(100, 50);
            DeclineBtn.SizeMode = PictureBoxSizeMode.Zoom;
            DeclineBtn.TabIndex = 30;
            DeclineBtn.TabStop = false;
            DeclineBtn.Click += DeclineBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(420, 23);
            comboBox1.TabIndex = 31;
            comboBox1.Text = "Ver documento";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new Point(228, 143);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 32;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(228, 180);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(0, 15);
            lblPhoneNumber.TabIndex = 33;
            // 
            // lblNumber
            // 
            lblNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(228, 218);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(0, 15);
            lblNumber.TabIndex = 34;
            // 
            // lblFirstLastName
            // 
            lblFirstLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFirstLastName.AutoSize = true;
            lblFirstLastName.Location = new Point(519, 143);
            lblFirstLastName.Name = "lblFirstLastName";
            lblFirstLastName.Size = new Size(0, 15);
            lblFirstLastName.TabIndex = 35;
            // 
            // lblRfc
            // 
            lblRfc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRfc.AutoSize = true;
            lblRfc.Location = new Point(519, 180);
            lblRfc.Name = "lblRfc";
            lblRfc.Size = new Size(0, 15);
            lblRfc.TabIndex = 36;
            // 
            // lblColony
            // 
            lblColony.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblColony.AutoSize = true;
            lblColony.Location = new Point(519, 218);
            lblColony.Name = "lblColony";
            lblColony.Size = new Size(0, 15);
            lblColony.TabIndex = 37;
            // 
            // lblSecondLastName
            // 
            lblSecondLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSecondLastName.AutoSize = true;
            lblSecondLastName.Location = new Point(792, 143);
            lblSecondLastName.Name = "lblSecondLastName";
            lblSecondLastName.Size = new Size(0, 15);
            lblSecondLastName.TabIndex = 38;
            // 
            // lblStreet
            // 
            lblStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(792, 180);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(0, 15);
            lblStreet.TabIndex = 39;
            // 
            // lblZipCode
            // 
            lblZipCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(792, 218);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(0, 15);
            lblZipCode.TabIndex = 40;
            // 
            // Evaluation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblZipCode);
            Controls.Add(lblStreet);
            Controls.Add(lblSecondLastName);
            Controls.Add(lblColony);
            Controls.Add(lblRfc);
            Controls.Add(lblFirstLastName);
            Controls.Add(lblNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblName);
            Controls.Add(comboBox1);
            Controls.Add(DeclineBtn);
            Controls.Add(AcceptBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbProspects);
            Name = "Evaluation";
            Size = new Size(942, 450);
            ((System.ComponentModel.ISupportInitialize)AcceptBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeclineBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProspects;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox AcceptBtn;
        private PictureBox DeclineBtn;
        private ToolTip toolTipMessage;
        private ComboBox comboBox1;
        private Label lblName;
        private Label lblPhoneNumber;
        private Label lblNumber;
        private Label lblFirstLastName;
        private Label lblRfc;
        private Label lblColony;
        private Label lblSecondLastName;
        private Label lblStreet;
        private Label lblZipCode;
    }
}