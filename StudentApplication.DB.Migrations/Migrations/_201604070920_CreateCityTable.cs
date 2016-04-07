using FluentMigrator;
using _City = StudentApplication.DB.DBConstants.Tables.City;

namespace StudentApplication.DB.Migrations.Migrations
{
    [Migration(201604070920)]
    public class _201604070920_CreateCityTable: Migration
    {
        public override void Up()
        {
            Create.Table(_City.TableName)
              .WithColumn(_City.Columns.CityId).AsInt32().PrimaryKey("PK_CityId").Identity()
              .WithColumn(_City.Columns.CityName).AsString(250)
              .WithDefaultEntityColumns();
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}