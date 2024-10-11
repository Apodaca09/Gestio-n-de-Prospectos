using Microsoft.EntityFrameworkCore;
using Prospect_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect_System.Controllers
{
    public class EvaluationController
    {
        public async Task<List<Prospecto>> GetAllWithStatusSend()
        {
            List<Prospecto> prospectos;
            using (var context = new ApplicationDbContext())
            {
                prospectos = await context.Prospectos
                    .Include(p => p.Documentos)
                    .Include(p => p.Evaluacions)
                    .Where(p => p.Estatus == "Enviado")
                    .ToListAsync();
            }
           return prospectos;
        }

        public async Task<bool> UpdateStatus(string newStatus, Evaluacion evaluacion)
        {
            using (var context = new ApplicationDbContext())
            {
                var prospect = await context.Prospectos.FindAsync(evaluacion.ProspectoId);
                if(prospect == null)
                {
                    return false;
                }

                prospect.Estatus = newStatus;
                if(evaluacion!=null)
                {
                   context.Evaluacions.Add(evaluacion);
                }

                await context.SaveChangesAsync();

                return true;
            }
        }
    }
}
