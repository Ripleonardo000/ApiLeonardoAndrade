using System;
using System.Collections.Generic;

namespace ApiLeonardoAndrade.DataModels;

public partial class Burger
{
    public int BurgerId { get; set; }

    public string Name { get; set; } = null!;

    public bool WithCheese { get; set; }

    public decimal Costo { get; set; }

    public virtual ICollection<Promo> Promos { get; set; } = new List<Promo>();
}
