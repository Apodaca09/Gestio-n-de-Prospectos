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
    public partial class CaptureInfo : UserControl
    {
        public CaptureInfo()
        {
            InitializeComponent();
            toolTipMessage.SetToolTip(BtnAdd, "Agregar");
            toolTipMessage.SetToolTip(BtnSend, "Enviar");
            toolTipMessage.SetToolTip(BtnExam, "Buscar archivo");
            toolTipMessage.IsBalloon = true;
            int columnWidth =  lstDetailsFiles.Width/ 2;
            lstDetailsFiles.Columns.Add("Nombre del Archivo", columnWidth);
            lstDetailsFiles.Columns.Add("Tipo", columnWidth);
        }
    }
}
