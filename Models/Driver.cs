using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Driver
    {
    public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string idnumber { get; set; }
    public string driverlicense { get; set; }
    public DateTime driverlicenseexpirationdate { get; set; }
    public string area { get; set; }
    public string imageurl { get; set; }
    public int adressid { get; set; }
    public int enterpriseid { get; set; }
    public string active { get; set; }
    }
}
