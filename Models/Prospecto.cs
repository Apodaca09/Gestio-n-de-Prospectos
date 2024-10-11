using System;
using System.Collections.Generic;

namespace Prospect_System.Models;

public partial class Prospecto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public string Calle { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<Evaluacion> Evaluacions { get; set; } = new List<Evaluacion>();
}
