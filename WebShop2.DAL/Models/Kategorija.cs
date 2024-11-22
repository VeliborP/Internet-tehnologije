using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop2.DAL.Models;

public partial class Kategorija
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Polje je obavezno")]
    [MaxLength(2)]
    public string Naziv { get; set; } = null!;
}
