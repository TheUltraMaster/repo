using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentaBlazor.Server.Models;

public partial class DetalleVentum
{
    [Key]
    [Column("idDetalleVenta")]
    public int IdDetalleVenta { get; set; }

    [Column("idVenta")]
    public int? IdVenta { get; set; }

    [Column("idProducto")]
    public int? IdProducto { get; set; }

    [Column("cantidad")]
    public int? Cantidad { get; set; }

    [Column("precio", TypeName = "decimal(10, 2)")]
    public decimal? Precio { get; set; }

    [Column("total", TypeName = "decimal(10, 2)")]
    public decimal? Total { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleVenta")]
    public virtual Producto? IdProductoNavigation { get; set; }

    [ForeignKey("IdVenta")]
    [InverseProperty("DetalleVenta")]
    public virtual Ventum? IdVentaNavigation { get; set; }
}
