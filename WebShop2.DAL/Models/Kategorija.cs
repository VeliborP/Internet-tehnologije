using System;
using System.Collections.Generic;

namespace WebShop2.DAL.Models;

public partial class Kategorija
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;
}
