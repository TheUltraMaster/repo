using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentaBlazor.Server.Models;

public partial class Ventum
{
    [Key]
    [Column("idVenta")]
    public int IdVenta { get; set; }

    [Column("numeroDocumento")]
    [StringLength(40)]
    [Unicode(false)]
    public string? NumeroDocumento { get; set; }

    [Column("tipoPago")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TipoPago { get; set; }

    [Column("fechaRegistro", TypeName = "datetime")]
    public DateTime? FechaRegistro { get; set; }

    [Column("total", TypeName = "decimal(10, 2)")]
    public decimal? Total { get; set; }

    [InverseProperty("IdVentaNavigation")]
    public virtual ICollection<DetalleVentum> DetalleVenta { get; } = new List<DetalleVentum>();
}
