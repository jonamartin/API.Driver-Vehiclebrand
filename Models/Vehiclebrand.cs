using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Vehiclebrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Entrepriseid { get; set; }
        public string Active { get; set; }
    }
}
