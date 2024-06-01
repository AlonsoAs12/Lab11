using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int idProducts { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public ICollection<Detail> Details { get; set; }
}