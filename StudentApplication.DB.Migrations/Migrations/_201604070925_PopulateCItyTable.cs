using System;
using FluentMigrator;
using _City = StudentApplication.DB.DBConstants.Tables.City;
namespace StudentApplication.DB.Migrations.Migrations
{
    [Migration(201604070925)]
    public class _201604070925_PopulateCItyTable: Migration
    {
        public override void Up()
        {
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Duiwelskloof", Created = DateTime.Now.AddSeconds(-35) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Bela Bela", Created = DateTime.Now.AddSeconds(-34) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Alberton", Created = DateTime.Now.AddSeconds(-33) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Lephalale", Created = DateTime.Now.AddSeconds(-32) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Vryburg", Created = DateTime.Now.AddSeconds(-31) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Dutywa", Created = DateTime.Now.AddSeconds(-30) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Broederstroom", Created = DateTime.Now.AddSeconds(-29) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Delareyville", Created = DateTime.Now.AddSeconds(-28) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Bloemhof", Created = DateTime.Now.AddSeconds(-27) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Mokopane", Created = DateTime.Now.AddSeconds(-26) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Louis Trichardt", Created = DateTime.Now.AddSeconds(-25) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Klerksdorp", Created = DateTime.Now.AddSeconds(-24) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Benoni", Created = DateTime.Now.AddSeconds(-23) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Kimberley", Created = DateTime.Now.AddSeconds(-22) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Rustenbrug", Created = DateTime.Now.AddSeconds(-21) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Mpumalanga", Created = DateTime.Now.AddSeconds(-20) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Centurion", Created = DateTime.Now.AddSeconds(-19) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Bushbuckridge", Created = DateTime.Now.AddSeconds(-18) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Tshawane", Created = DateTime.Now.AddSeconds(-17) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Bhisho", Created = DateTime.Now.AddSeconds(-16) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Tembisa", Created = DateTime.Now.AddSeconds(-15) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Mahikeng", Created = DateTime.Now.AddSeconds(-14) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Soweto", Created = DateTime.Now.AddSeconds(-13) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Ga-Rankuwa", Created = DateTime.Now.AddSeconds(-12) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Boksburg", Created = DateTime.Now.AddSeconds(-11) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Mthatha", Created = DateTime.Now.AddSeconds(-10) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Nelspruit", Created = DateTime.Now.AddSeconds(-9) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "East London", Created = DateTime.Now.AddSeconds(-8) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Cape Town", Created = DateTime.Now.AddSeconds(-7) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Johannesburg", Created = DateTime.Now.AddSeconds(-6) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Bloemfontein", Created = DateTime.Now.AddSeconds(-5) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Durban", Created = DateTime.Now.AddSeconds(-4) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Pretoria", Created = DateTime.Now.AddSeconds(-3) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Polokwane", Created = DateTime.Now.AddSeconds(-2) });
            this.Insert.IntoTable(_City.TableName).Row(new { CityName = "Port Elizabeth", Created = DateTime.Now.AddSeconds(-1) });
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}