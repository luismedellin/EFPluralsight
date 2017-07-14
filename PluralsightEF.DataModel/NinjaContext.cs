using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightEF.DataModel
{
    public class NinjaContext:DbContext
    {
        public NinjaContext():base("conexion")
        {

        }

        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }



    }
}
