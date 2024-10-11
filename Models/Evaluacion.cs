using System;
using System.Collections.Generic;

namespace Prospect_System.Models;

public partial class Evaluacion
{
    public int Id { get; set; }

    public int ProspectoId { get; set; }

    public string Estatus { get; set; } = null!;

    public string? ObservacionesRechazo { get; set; }

    public DateTime? FechaEvaluacion { get; set; }

    public virtual Prospecto Prospecto { get; set; } = null!;
}
