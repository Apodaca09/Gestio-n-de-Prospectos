using Microsoft.EntityFrameworkCore;
using Prospect_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prospect_System.Controllers
{
    public class CaptureInfoController
    {
        public  async Task Create(Prospecto prospect)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    await context.Prospectos.AddAsync(prospect);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Prospecto guardado correctamente.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar el prospecto." + ex.Message,"Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
