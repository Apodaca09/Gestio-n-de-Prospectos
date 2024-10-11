using Patagames.Pdf.Net.Controls.WinForms;
using Prospect_System.Controllers;
using Prospect_System.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prospect_System.Views
{
    public partial class Evaluation : UserControl
    {
        EvaluationController evaluationCont = new EvaluationController();
        Evaluacion evaluacionPros = new Evaluacion();
        List<Prospecto> all = new List<Prospecto>();
        public int index;
        private List<byte[]> documentos = new List<byte[]>();
        private PdfViewer pdfViewer;
        public Evaluation()
        {
            InitializeComponent();
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill
            };
            this.pdfPanel.Controls.Add(pdfViewer);
            this.DoubleBuffered = true;
            toolTipMessage.SetToolTip(AcceptBtn, "Autorizar");
            toolTipMessage.SetToolTip(DeclineBtn, "Rechazar");
            toolTipMessage.IsBalloon = true;
        }

        private async void DeclineBtn_Click(object sender, EventArgs e)
        {
            if(all.Count > 0)
            {
                ObservationDialog observation = new ObservationDialog();
                if (observation.ShowDialog() == DialogResult.OK)
                {
                    string observations = observation.observationsContent;
                    string status = "Rechazado";
                    evaluacionPros.Estatus = status;
                    evaluacionPros.ObservacionesRechazo = observations;
                    evaluacionPros.ProspectoId = all[index].Id;
                    var res = await evaluationCont.UpdateStatus(status, evaluacionPros);
                    if (res)
                    {
                        DeleteElement(index);
                        MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema al guardar los datos", "Información", MessageBoxButtons.OK);
                    }
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("No es posible realizar esta operación por el momento", "Información", MessageBoxButtons.OK);
            }
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            LoadAsync();
        }

        private void DeleteElement(int index)
        {
            if(index <= all.Count)
            {
                all.RemoveAt(index);
                cmbProspects.Items.Clear();
                cmbDocuments.Items.Clear();
                foreach (var data in all)
                {
                    string FullName = data.Nombre + " " + data.PrimerApellido + " " + data.SegundoApellido;
                    cmbProspects.Items.Add(FullName);
                    foreach(var document in data.Documentos)
                    {
                        cmbDocuments.Items.Add(document.NombreArchivo);
                        documentos.Add(document.ContenidoArchivo);
                    }
                }
            }
        }

        public async void LoadAsync()
        {
            pdfViewer.CloseDocument();
            pdfViewer.ClearRenderBuffer();
            pdfPanel.Controls.Remove(pdfViewer);
            pdfPanel.Controls.Add(pdfViewer);
            cmbProspects.Items.Clear();
            all = await evaluationCont.GetAllWithStatusSend();
            if (all.Count > 0)
            {
                lblName.Text = all[0].Nombre;
                lblFirstLastName.Text = all[0].PrimerApellido;
                lblSecondLastName.Text = all[0].SegundoApellido;
                lblPhoneNumber.Text = all[0].Telefono;
                lblRfc.Text = all[0].Rfc;
                lblStreet.Text = all[0].Calle;
                lblNumber.Text = all[0].Numero;
                lblColony.Text = all[0].Colonia;
                lblZipCode.Text = all[0].CodigoPostal;
                var documents = all[0].Documentos;
                foreach (var document in documents)
                {
                    cmbDocuments.Items.Add(document.NombreArchivo);
                    documentos.Add(document.ContenidoArchivo);
                }
                foreach (var data in all)
                {
                    string FullName = data.Nombre + " " + data.PrimerApellido + " " + data.SegundoApellido;
                    cmbProspects.Items.Add(FullName);
                }
            }
            else
            {
                cmbProspects.Text = "Sin prospecros en estatus enviado";
            }
        }

        public void ClearForm()
        {
            lblName.Text = "";
            lblFirstLastName.Text = "";
            lblSecondLastName.Text = "";
            lblNumber.Text = "";
            lblColony.Text = "";
            lblStreet.Text = "";
            lblRfc.Text = "";
            lblPhoneNumber.Text = "";
            lblZipCode.Text = "";
            cmbDocuments.Items.Clear();
            cmbProspects.Items.Clear();
            documentos.Clear();
            pdfViewer.CloseDocument();
            pdfViewer.ClearRenderBuffer();
            pdfPanel.Controls.Remove(pdfViewer);
        }

        private void LoadPdfFromMemory(byte[] pdfData)
        {
            var stream = new MemoryStream(pdfData);
            pdfViewer.LoadDocument(stream);
        }

        private void cmbDocuments_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cmbDocuments.SelectedIndex;
            LoadPdfFromMemory(documentos[index]);
        }

        private void cmbProspects_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDocuments.Items.Clear();
            documentos.Clear();
            index = cmbProspects.SelectedIndex;
            var data = all[index];
            lblName.Text = data.Nombre;
            lblFirstLastName.Text = data.PrimerApellido;
            lblSecondLastName.Text = data.SegundoApellido;
            lblPhoneNumber.Text = data.Telefono;
            lblRfc.Text = data.Rfc;
            lblStreet.Text = data.Calle;
            lblNumber.Text = data.Numero;
            lblColony.Text = data.Colonia;
            lblZipCode.Text = data.CodigoPostal;
            var documents = data.Documentos;
            foreach (var document in documents)
            {
                cmbDocuments.Items.Add(document.NombreArchivo);
                documentos.Add(document.ContenidoArchivo);
            }
        }

        private async void AcceptBtn_Click(object sender, EventArgs e)
        {
            if(all.Count>0)
            {
                string status = "Autorizado";
                evaluacionPros.Estatus = status;
                evaluacionPros.ProspectoId = all[index].Id;
                var res = await evaluationCont.UpdateStatus(status, evaluacionPros);
               if (res)
                {
                    DeleteElement(index);
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema al guardar los datos", "Información", MessageBoxButtons.OK);
                }
                ClearForm();
            }
            else
            {
                MessageBox.Show("No es posible realizar esta operación por el momento", "Información", MessageBoxButtons.OK);
            }
        }
    }
}
