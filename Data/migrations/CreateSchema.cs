using Electronice;
using FluentMigrator;

namespace Electronice.Data.migrations
{
    [Migration(10012025)]
    public class CreateSchema:Migration
    {
        public override void Down()
        {
           
        }

        public override void Up()
        {
            Create.Table("electronics")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                   .WithColumn("Dispozitiv").AsString(130).NotNullable()
                   .WithColumn("Model").AsString(150).NotNullable()
                   .WithColumn("Memory").AsInt32().NotNullable()
                   .WithColumn("Price").AsDouble().NotNullable();
            


        }






    }
}
