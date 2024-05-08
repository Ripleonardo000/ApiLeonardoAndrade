using System;
using System.Collections.Generic;

namespace ApiLeonardoAndrade.DataModels;

public partial class Promo
{
    public int PromoId { get; set; }

    public string? Descripcion { get; set; }

    public int FechaPromo { get; set; }

    public int BurgerId { get; set; }

    public virtual Burger Burger { get; set; } = null!;
}
