using Lab11.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int idCustomers { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DocumentNumber { get; set; }
    public ICollection<Invoice> Invoices { get; set; }
}