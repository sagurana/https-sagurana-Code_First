using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Code_First_Demo.Model;

namespace Code_First_Demo.Repository
{
    public class CDBContext:DbContext
    {
        public CDBContext() : base("StringDBContext")
        {
        }
        public DbSet<MyTable>FirstTable { get; set; }
    }
}
