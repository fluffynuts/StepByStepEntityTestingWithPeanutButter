using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeProjectUsingEntity.Tests
{
    public class SomeDBSchema
    {
        public const string DB_SCHEMA =
            @"create table SomeEntities(Id int primary key identity, Name nvarchar(100) not null, Notes nvarchar(max))";
    }
}
