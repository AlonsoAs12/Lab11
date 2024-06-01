using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Detail
{
    [Key]
    public int idDetails { get; set; }
    public int Products_idProducts { get; set; }
    [ForeignKey("Products_idProducts")]
    public Product Product { get; set; }
    public int Invoices_idInvoices { get; set; }
    [ForeignKey("Invoices_idInvoices")]
    public Invoice Invoice { get; set; }
    public int Amount { get; set; }
    public float Price { get; set; }
    public float SubTotal { get; set; }
}