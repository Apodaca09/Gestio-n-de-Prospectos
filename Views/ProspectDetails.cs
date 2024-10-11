using Patagames.Pdf.Net.Controls.WinForms;
using Prospect_System.Models;
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
    public partial class ProspectDetails : Form
    {
        private PdfViewer pdfViewer;
        private List<byte[]> documentos = new List<byte[]>();
        public ProspectDetails(Prospecto prospecto)
        {
            InitializeComponent();
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill
            };
            this.pdfPanel.Controls.Add(pdfViewer);
            this.DoubleBuffered = true;
            lblName.Text = prospecto.Nombre;
            lblFirstLastName.Text = prospecto.PrimerApellido;
            lblSecondLastName.Text = prospecto.SegundoApellido;
            lblNumber.Text = prospecto.Numero;
            lblColony.Text = prospecto.Colonia;
            lblStreet.Text = prospecto.Calle;
            lblStatus.Text = prospecto.Estatus;
            lblRfc.Text = prospecto.Rfc;
            lblPhoneNumber.Text = prospecto.Telefono;
            lblZipCode.Text = prospecto.CodigoPostal;
            rchObservations.Enabled = false;
            foreach (var document in prospecto.Documentos)
            {
                cmbDocuments.Items.Add(document.NombreArchivo);
                documentos.Add(document.ContenidoArchivo);
            }

            foreach (var evaluation in prospecto.Evaluacions)
            {
                if (prospecto.Estatus == "Rechazado" || evaluation.Estatus == "Rechazado")
                {
                    rchObservations.Text = evaluation.ObservacionesRechazo;
                }
            }
        }

        

        private void LoadPdfFromMemory(byte[] pdfData)
        {
            var stream = new MemoryStream(pdfData);
            pdfViewer.LoadDocument(stream);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDocuments_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cmbDocuments.SelectedIndex;

            LoadPdfFromMemory(documentos[index]);
        }

    }
}
