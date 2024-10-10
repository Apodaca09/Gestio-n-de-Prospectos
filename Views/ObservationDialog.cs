using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prospect_System.Views
{
    public partial class ObservationDialog : Form
    {
        public string observationsContent;
        public ObservationDialog()
        {
            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            observationsContent = rchObservations.Text;
            if(string.IsNullOrWhiteSpace(observationsContent))
            {
                MessageBox.Show("Las observaciones son obligatorias", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
        }
    }
}
