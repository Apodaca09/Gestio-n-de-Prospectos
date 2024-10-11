namespace Prospect_System.Views
{
    partial class CaptureInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureInfo));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtName = new TextBox();
            txtFirstLastName = new TextBox();
            txtSecondLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtRfc = new TextBox();
            txtStreet = new TextBox();
            txtNumber = new TextBox();
            txtColony = new TextBox();
            txtZipCode = new TextBox();
            BtnAdd = new PictureBox();
            BtnExam = new Button();
            BtnSend = new PictureBox();
            toolTipMessage = new ToolTip(components);
            lstDetailsFiles = new ListView();
            BtnDelete = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(149, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "* Nombre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(111, 71);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "* Primer Apellido";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(107, 117);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(148, 161);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "* Teléfono";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(170, 203);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "* RFC";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(165, 238);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 5;
            label6.Text = "* Calle";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(150, 276);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 6;
            label7.Text = "* Número";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(149, 314);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 7;
            label8.Text = "* Colonia";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(165, 354);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 8;
            label9.Text = "* C.P.";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(111, 414);
            label10.Name = "label10";
            label10.Size = new Size(118, 15);
            label10.TabIndex = 9;
            label10.Text = "*  Campo obligatorio";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(633, 34);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 10;
            label11.Text = "Documentación";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.Location = new Point(214, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 23);
            txtName.TabIndex = 11;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // txtFirstLastName
            // 
            txtFirstLastName.Anchor = AnchorStyles.Left;
            txtFirstLastName.Location = new Point(214, 71);
            txtFirstLastName.Name = "txtFirstLastName";
            txtFirstLastName.Size = new Size(275, 23);
            txtFirstLastName.TabIndex = 12;
            txtFirstLastName.KeyPress += txtFirstLastName_KeyPress;
            // 
            // txtSecondLastName
            // 
            txtSecondLastName.Anchor = AnchorStyles.Left;
            txtSecondLastName.Location = new Point(214, 114);
            txtSecondLastName.Name = "txtSecondLastName";
            txtSecondLastName.Size = new Size(275, 23);
            txtSecondLastName.TabIndex = 13;
            txtSecondLastName.KeyPress += txtSecondLastName_KeyPress;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Left;
            txtPhoneNumber.Location = new Point(214, 161);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(275, 23);
            txtPhoneNumber.TabIndex = 14;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtRfc
            // 
            txtRfc.Anchor = AnchorStyles.Left;
            txtRfc.Location = new Point(212, 200);
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(275, 23);
            txtRfc.TabIndex = 15;
            txtRfc.KeyPress += txtRfc_KeyPress;
            // 
            // txtStreet
            // 
            txtStreet.Anchor = AnchorStyles.Left;
            txtStreet.Location = new Point(212, 238);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(275, 23);
            txtStreet.TabIndex = 16;
            txtStreet.KeyPress += txtStreet_KeyPress;
            // 
            // txtNumber
            // 
            txtNumber.Anchor = AnchorStyles.Left;
            txtNumber.Location = new Point(212, 276);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(275, 23);
            txtNumber.TabIndex = 17;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // txtColony
            // 
            txtColony.Anchor = AnchorStyles.Left;
            txtColony.Location = new Point(211, 314);
            txtColony.Name = "txtColony";
            txtColony.Size = new Size(275, 23);
            txtColony.TabIndex = 18;
            txtColony.KeyPress += txtColony_KeyPress;
            // 
            // txtZipCode
            // 
            txtZipCode.Anchor = AnchorStyles.Left;
            txtZipCode.Location = new Point(211, 351);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(275, 23);
            txtZipCode.TabIndex = 19;
            txtZipCode.KeyPress += txtZipCode_KeyPress;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Left;
            BtnAdd.BackColor = Color.FromArgb(112, 179, 255);
            BtnAdd.BorderStyle = BorderStyle.FixedSingle;
            BtnAdd.Image = (Image)resources.GetObject("BtnAdd.Image");
            BtnAdd.Location = new Point(633, 97);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(107, 35);
            BtnAdd.SizeMode = PictureBoxSizeMode.Zoom;
            BtnAdd.TabIndex = 21;
            BtnAdd.TabStop = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnExam
            // 
            BtnExam.Anchor = AnchorStyles.Left;
            BtnExam.BackColor = Color.FromArgb(112, 179, 255);
            BtnExam.FlatStyle = FlatStyle.Flat;
            BtnExam.Location = new Point(633, 61);
            BtnExam.Name = "BtnExam";
            BtnExam.Size = new Size(394, 25);
            BtnExam.TabIndex = 22;
            BtnExam.Text = "Examinar";
            BtnExam.UseVisualStyleBackColor = false;
            BtnExam.Click += BtnExam_Click;
            // 
            // BtnSend
            // 
            BtnSend.Anchor = AnchorStyles.Left;
            BtnSend.BackColor = Color.FromArgb(58, 236, 79);
            BtnSend.BorderStyle = BorderStyle.FixedSingle;
            BtnSend.Image = (Image)resources.GetObject("BtnSend.Image");
            BtnSend.Location = new Point(920, 97);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(107, 35);
            BtnSend.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSend.TabIndex = 23;
            BtnSend.TabStop = false;
            BtnSend.Click += BtnSend_Click;
            // 
            // lstDetailsFiles
            // 
            lstDetailsFiles.Anchor = AnchorStyles.Left;
            lstDetailsFiles.Location = new Point(633, 143);
            lstDetailsFiles.Name = "lstDetailsFiles";
            lstDetailsFiles.Size = new Size(394, 231);
            lstDetailsFiles.TabIndex = 24;
            lstDetailsFiles.UseCompatibleStateImageBehavior = false;
            lstDetailsFiles.View = View.Details;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Left;
            BtnDelete.BackColor = Color.Red;
            BtnDelete.BorderStyle = BorderStyle.FixedSingle;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(773, 97);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(107, 35);
            BtnDelete.SizeMode = PictureBoxSizeMode.Zoom;
            BtnDelete.TabIndex = 25;
            BtnDelete.TabStop = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // CaptureInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(BtnDelete);
            Controls.Add(lstDetailsFiles);
            Controls.Add(BtnSend);
            Controls.Add(BtnExam);
            Controls.Add(BtnAdd);
            Controls.Add(txtZipCode);
            Controls.Add(txtColony);
            Controls.Add(txtNumber);
            Controls.Add(txtStreet);
            Controls.Add(txtRfc);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtSecondLastName);
            Controls.Add(txtFirstLastName);
            Controls.Add(txtName);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CaptureInfo";
            Size = new Size(1137, 457);
            ((System.ComponentModel.ISupportInitialize)BtnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSend).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtName;
        private TextBox txtFirstLastName;
        private TextBox txtSecondLastName;
        private TextBox txtPhoneNumber;
        private TextBox txtRfc;
        private TextBox txtStreet;
        private TextBox txtNumber;
        private TextBox txtColony;
        private TextBox txtZipCode;
        private PictureBox BtnAdd;
        private Button BtnExam;
        private PictureBox BtnSend;
        private ToolTip toolTipMessage;
        private ListView lstDetailsFiles;
        private PictureBox BtnDelete;
    }
}