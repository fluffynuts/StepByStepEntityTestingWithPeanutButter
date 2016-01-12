using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity
{
    public class SomeContext: DbContext
    {
        public IDbSet<SomeEntity> SomeEntities { get; set; }
         
        public SomeContext(DbConnection connection): base(connection, true)
        {
        }
    }
}
