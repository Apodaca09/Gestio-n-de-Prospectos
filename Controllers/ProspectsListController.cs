using Microsoft.EntityFrameworkCore;
using Prospect_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect_System.Controllers
{
    public class ProspectsListController
   {
        public async Task<List<Prospecto>> GetAllInfoProspects()
        {
            List<Prospecto> prospectos;
                using (var context = new ApplicationDbContext())
                {
                         prospectos = await context.Prospectos
                        .Include(p => p.Documentos)
                        .Include(p => p.Evaluacions)
                        .ToListAsync();
               }
            return prospectos;
        }
    }
}
