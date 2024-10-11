using Microsoft.VisualBasic;
using Prospect_System.Controllers;
using Prospect_System.Models;

namespace Prospect_System.Views
{
    public partial class CaptureInfo : UserControl
    {
        ImageList tipoArchivo = new ImageList();
        List<Documento> documents = new List<Documento>();
        CaptureInfoController infoController = new CaptureInfoController();
        public CaptureInfo()
        {
            InitializeComponent();
            txtName.Focus();
            //Mensajes de sugerencia para el usuario
            toolTipMessage.SetToolTip(BtnAdd, "Agregar 1 archivo");
            toolTipMessage.SetToolTip(BtnSend, "Enviar datos");
            toolTipMessage.SetToolTip(BtnExam, "Buscar y agregar 1 o más archivos");
            toolTipMessage.SetToolTip(BtnDelete, "Eliminar archivos de la lista");
            toolTipMessage.IsBalloon = true;
            int columnWidth = lstDetailsFiles.Width / 2;
            lstDetailsFiles.Columns.Add("Nombre del Archivo", columnWidth);

            //Configuracion de imagenes para el ListView
            tipoArchivo.ImageSize = new Size(32, 32);
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string rootDitectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
            string imagePath = Path.Combine(rootDitectory, "Images", "archivo_pdf.png");
            if (File.Exists(imagePath))
            {
                tipoArchivo.Images.Add("pdf", Image.FromFile(imagePath));
                lstDetailsFiles.LargeImageList = tipoArchivo;
                lstDetailsFiles.SmallImageList = tipoArchivo;
            }
            else
            {
                MessageBox.Show("La imagen no se encontró en: " + imagePath);
            }
        }

        private async void BtnExam_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "(*.pdf) | *.pdf";
            dialog.Title = "Seleccione los documentos del prospecto en formato PDF";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lstDetailsFiles.Items.Clear();
                documents.Clear();
                foreach (string archivo in dialog.FileNames)
                {
                    string nombreArchivo = System.IO.Path.GetFileName(archivo);
                    string pathArchivo = System.IO.Path.GetFullPath(archivo);
                    lstDetailsFiles.Items.Add(new ListViewItem(new[] { nombreArchivo, "" }, "pdf"));

                    using (var ms = new MemoryStream())
                    {
                        var file = new Documento();
                        file.NombreArchivo = nombreArchivo;
                        file.ContenidoArchivo = await System.IO.File.ReadAllBytesAsync(pathArchivo);
                        documents.Add(file);
                    }
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (documents.Count == 0)
            {
                MessageBox.Show("Debes agregar documentos", "Información", MessageBoxButtons.OK);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtFirstLastName.Text) && !string.IsNullOrEmpty(txtSecondLastName.Text)
                && !string.IsNullOrEmpty(txtStreet.Text) && !string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtColony.Text)
                && !string.IsNullOrEmpty(txtZipCode.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text) && !string.IsNullOrEmpty(txtRfc.Text)
                && documents.Count > 0)
                {
                    var prospecto = new Prospecto()
                    {
                        Nombre = txtName.Text,
                        PrimerApellido = txtFirstLastName.Text,
                        SegundoApellido = txtSecondLastName.Text,
                        Calle = txtStreet.Text,
                        Numero = txtNumber.Text,
                        Colonia = txtColony.Text,
                        CodigoPostal = txtZipCode.Text,
                        Telefono = txtPhoneNumber.Text,
                        Rfc = txtRfc.Text,
                        Documentos = documents
                    };

                    var result = infoController.Create(prospecto);
                    ClearCaptureInfo();
                }
                else
                {
                    MessageBox.Show("Debes completar la información requerida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool HasUnsavedData()
        {
            bool algo;
            return algo = !string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrEmpty(txtFirstLastName.Text) || !string.IsNullOrEmpty(txtSecondLastName.Text)
                || !string.IsNullOrEmpty(txtStreet.Text) || !string.IsNullOrEmpty(txtNumber.Text) || !string.IsNullOrEmpty(txtColony.Text)
                || !string.IsNullOrEmpty(txtZipCode.Text) || !string.IsNullOrEmpty(txtPhoneNumber.Text) || !string.IsNullOrEmpty(txtRfc.Text)
                || documents.Count > 0;

        }

        public void ClearCaptureInfo()
        {
            txtName.Clear();
            txtFirstLastName.Clear();
            txtSecondLastName.Clear();
            txtStreet.Clear();
            txtNumber.Clear();
            txtColony.Clear();
            txtZipCode.Clear();
            txtPhoneNumber.Clear();
            txtRfc.Clear();
            documents.Clear();
            lstDetailsFiles.Clear();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtFirstLastName.Focus();
            }
        }

        private void txtSecondLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPhoneNumber.Focus();
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRfc.Focus();
            }
        }

        private void txtFirstLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSecondLastName.Focus();
            }
        }

        private void txtRfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtStreet.Focus();
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumber.Focus();
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtColony.Focus();
            }
        }

        private void txtColony_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtZipCode.Focus();
            }
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnExam.Focus();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lstDetailsFiles.Items.Clear();
            documents.Clear();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "(*.pdf) | *.pdf";
            dialog.Title = "Seleccione los documentos del prospecto en formato PDF";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
             string nombreArchivo = System.IO.Path.GetFileName(dialog.FileName);
             string pathArchivo = System.IO.Path.GetFullPath(dialog.FileName);
             lstDetailsFiles.Items.Add(new ListViewItem(new[] { nombreArchivo, "" }, "pdf"));

             using (var ms = new MemoryStream())
             {
                 var file = new Documento();
                 file.NombreArchivo = nombreArchivo;
                 file.ContenidoArchivo = await System.IO.File.ReadAllBytesAsync(pathArchivo);
                 documents.Add(file);
             }
            }
        }
    }
}
