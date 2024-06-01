using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Invoice
{
    [Key]
    public int idInvoices { get; set; }
    public int Customers_idCustomers { get; set; }
    [ForeignKey("Customers_idCustomers")]
    public Customer Customer { get; set; }
    public DateTime Date { get; set; }
    public string InvoiceNumber { get; set; }
    public float Total { get; set; }
    public ICollection<Detail> Details { get; set; }
}