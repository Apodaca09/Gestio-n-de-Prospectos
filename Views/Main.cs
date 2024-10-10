
namespace Prospect_System.Views
{
    public partial class Main : Form
    {
        CaptureInfo capture = new CaptureInfo();
        ProspectsList prospects = new ProspectsList();
        Evaluation evaluation = new Evaluation();
        public Main()
        {
            InitializeComponent();
            capture.Dock = DockStyle.Fill;
            this.ContainerPages.Controls.Add(capture);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            ContainerPages = new Panel();
            CaptureIconButton = new PictureBox();
            ProspectIconButton = new PictureBox();
            EvaluationIconButton = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CaptureIconButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProspectIconButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EvaluationIconButton).BeginInit();
            SuspendLayout();
            // 
            // ContainerPages
            // 
            ContainerPages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContainerPages.Location = new Point(0, 97);
            ContainerPages.Name = "ContainerPages";
            ContainerPages.Size = new Size(1041, 408);
            ContainerPages.TabIndex = 0;
            // 
            // CaptureIconButton
            // 
            CaptureIconButton.Anchor = AnchorStyles.Top;
            CaptureIconButton.Image = (Image)resources.GetObject("CaptureIconButton.Image");
            CaptureIconButton.Location = new Point(334, 12);
            CaptureIconButton.Name = "CaptureIconButton";
            CaptureIconButton.Size = new Size(51, 57);
            CaptureIconButton.SizeMode = PictureBoxSizeMode.Zoom;
            CaptureIconButton.TabIndex = 1;
            CaptureIconButton.TabStop = false;
            CaptureIconButton.Click += CaptureIconButton_Click;
            // 
            // ProspectIconButton
            // 
            ProspectIconButton.Anchor = AnchorStyles.Top;
            ProspectIconButton.Image = (Image)resources.GetObject("ProspectIconButton.Image");
            ProspectIconButton.Location = new Point(474, 13);
            ProspectIconButton.Name = "ProspectIconButton";
            ProspectIconButton.Size = new Size(52, 57);
            ProspectIconButton.SizeMode = PictureBoxSizeMode.Zoom;
            ProspectIconButton.TabIndex = 2;
            ProspectIconButton.TabStop = false;
            ProspectIconButton.Click += ProspectIconButton_Click;
            // 
            // EvaluationIconButton
            // 
            EvaluationIconButton.Anchor = AnchorStyles.Top;
            EvaluationIconButton.Image = (Image)resources.GetObject("EvaluationIconButton.Image");
            EvaluationIconButton.Location = new Point(622, 13);
            EvaluationIconButton.Name = "EvaluationIconButton";
            EvaluationIconButton.Size = new Size(52, 57);
            EvaluationIconButton.SizeMode = PictureBoxSizeMode.Zoom;
            EvaluationIconButton.TabIndex = 3;
            EvaluationIconButton.TabStop = false;
            EvaluationIconButton.Click += this.EvaluationIconButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 72);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 4;
            label1.Text = "Captura";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(460, 72);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 5;
            label2.Text = "Prospectos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(606, 72);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 5;
            label3.Text = "Evaluación";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            ClientSize = new Size(1041, 505);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EvaluationIconButton);
            Controls.Add(ProspectIconButton);
            Controls.Add(CaptureIconButton);
            Controls.Add(ContainerPages);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Prospectos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)CaptureIconButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProspectIconButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EvaluationIconButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void EvaluationIconButton_Click(object? sender, EventArgs e)
        {
            evaluation.Dock = DockStyle.Fill;
            this.ContainerPages.Controls.Clear();
            this.ContainerPages.Controls.Add(evaluation);
        }

        private void ProspectIconButton_Click(object? sender, EventArgs e)
        {
            prospects.Dock = DockStyle.Fill;
            this.ContainerPages.Controls.Clear();
            this.ContainerPages.Controls.Add(prospects);
        }

        private void CaptureIconButton_Click(object? sender, EventArgs e)
        {
            capture.Dock = DockStyle.Fill;
            this.ContainerPages.Controls.Clear();
            this.ContainerPages.Controls.Add(capture);
        }

        private Panel ContainerPages;
        private ListBox listBox1;
        private PictureBox CaptureIconButton;
        private PictureBox ProspectIconButton;
        private PictureBox EvaluationIconButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
