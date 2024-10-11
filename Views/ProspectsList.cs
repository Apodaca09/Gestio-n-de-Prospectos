using Prospect_System.Controllers;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prospect_System.Views
{
    public partial class ProspectsList : UserControl
    {

        ProspectsListController listController = new ProspectsListController();
        List<Prospecto> AllProspectos = new List<Prospecto>();
        public ProspectsList()
        {
            InitializeComponent();
            dgvProspects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProspects.MultiSelect = false;
            int columnWidth = (dgvProspects.Width + 150) / 4;
            dgvProspects.AllowUserToAddRows = false;
            dgvProspects.Columns.Add("Id", "Id");
            dgvProspects.Columns.Add("Nombre", "Nombre");
            dgvProspects.Columns.Add("1er Apellido", "1er Apellido");
            dgvProspects.Columns.Add("2do Apellido", "2do Apellido");
            dgvProspects.Columns.Add("Estatus", "Estatus");
            dgvProspects.Columns[0].Width = 50;
            dgvProspects.Columns[1].Width = columnWidth;
            dgvProspects.Columns[2].Width = columnWidth;
            dgvProspects.Columns[3].Width = columnWidth;
            dgvProspects.Columns[4].Width = columnWidth;
        }

        public async void LoadAsync()
        {
            dgvProspects.Rows.Clear();
            AllProspectos.Clear();
            AllProspectos = await listController.GetAllInfoProspects();
            for (int i = 0; i < AllProspectos.Count; i++)
            {
                dgvProspects.Rows.Add(AllProspectos[i].Id, AllProspectos[i].Nombre, AllProspectos[i].PrimerApellido, AllProspectos[i].SegundoApellido, AllProspectos[i].Estatus);
            }
        }

        private void dgvProspects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvProspects.ClearSelection();
                dgvProspects.Rows[e.RowIndex].Selected = true;
                int selectedId = Convert.ToInt32(dgvProspects.Rows[e.RowIndex].Cells["Id"].Value);
                ProspectDetails details = new ProspectDetails(AllProspectos[selectedId]);
                details.ShowDialog();
                dgvProspects.Rows[e.RowIndex].Selected = false;
            }
        }
    }
}
