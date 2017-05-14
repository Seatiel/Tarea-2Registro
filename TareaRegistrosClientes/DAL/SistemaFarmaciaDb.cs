using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TareaRegistrosClientes.Models;

namespace TareaRegistrosClientes.DAL
{
    public class SistemaFarmaciaDb : DbContext 
    {
        public SistemaFarmaciaDb() : base("ConStr")
        {
                
        }

        public DbSet<Clientes> Cliente { get; set; }
    }

}