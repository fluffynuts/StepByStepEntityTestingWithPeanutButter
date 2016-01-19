using System.Data.Common;
using System.Data.Entity;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity
{
    public class SomeContext: DbContext
    {
        public IDbSet<SomeEntity> SomeEntities { get; set; }
        public IDbSet<SomeChildEntity> SomeChildEntities { get; set; }

        public SomeContext(DbConnection connection): base(connection, true)
        {
        }

        static SomeContext()
        {
            Database.SetInitializer<SomeContext>(null);
        }
    }
}
