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
    public partial class Evaluation : UserControl
    {
        public Evaluation()
        {
            InitializeComponent();
            toolTipMessage.SetToolTip(AcceptBtn, "Aceptar");
            toolTipMessage.SetToolTip(DeclineBtn, "Rechazar");
            toolTipMessage.IsBalloon = true;
        }

        private void DeclineBtn_Click(object sender, EventArgs e)
        {
            ObservationDialog observation = new ObservationDialog();
            if(observation.ShowDialog() == DialogResult.OK)
            {
                string observations = observation.observationsContent;
                MessageBox.Show(observations);
            }
        }
    }
}
