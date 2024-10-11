using System;
using System.Collections.Generic;

namespace Prospect_System.Models;

public partial class Documento
{
    public int Id { get; set; }

    public int ProspectoId { get; set; }

    public byte[]? ContenidoArchivo { get; set; }

    public string NombreArchivo { get; set; } = null!;

    public DateTime? FechaCaptura { get; set; }

    public virtual Prospecto Prospecto { get; set; } = null!;
}
