using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentaBlazor.Server.Models;

public partial class Categorium
{
    [Key]
    [Column("idCategoria")]
    public int IdCategoria { get; set; }

    [Column("descripcion")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("esActivo")]
    public bool? EsActivo { get; set; }

    [Column("fechaRegistro", TypeName = "datetime")]
    public DateTime? FechaRegistro { get; set; }

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
