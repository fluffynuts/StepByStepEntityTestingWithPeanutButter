using FluentMigrator;
using _Table = SomeProjectUsingEntity.DataConstants.Tables.SomeChildEntity;
using _Columns = SomeProjectUsingEntity.DataConstants.Tables.SomeChildEntity.Columns;
using _SomeEntity = SomeProjectUsingEntity.DataConstants.Tables.SomeEntity;

namespace SomeProjectUsingEntity.DbMigrations.Migrations
{
    [Migration(201601131633)]
    public class Migration_201601131633_CreateSomeChildEntityTable: Migration
    {
        public override void Up()
        {
            Create.Table(_Table.NAME)
                .WithColumn(_Columns.ID).AsInt32().PrimaryKey().Identity()
                .WithColumn(_Columns.SOME_ENTITY_ID).AsInt32().NotNullable()
                    .ForeignKey(_SomeEntity.NAME, _SomeEntity.Columns.ID)
                .WithColumn(_Columns.NAME).AsString();
        }

        public override void Down()
        {
        }
    }
}
