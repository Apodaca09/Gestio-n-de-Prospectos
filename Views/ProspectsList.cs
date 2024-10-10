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
    public partial class ProspectsList : UserControl
    {
        public ProspectsList()
        {
            InitializeComponent();
            lstDetailsProspects.View = View.Details;
            int columnWidth = lstDetailsProspects.Width / 4;
            lstDetailsProspects.Columns.Add("Nombre", columnWidth);
            lstDetailsProspects.Columns.Add("1er Apellido", columnWidth);
            lstDetailsProspects.Columns.Add("2do Apellido", columnWidth);
            lstDetailsProspects.Columns.Add("Estatus", columnWidth);
        }
    }
}
