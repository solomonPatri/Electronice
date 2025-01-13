using Electronice;
using FluentMigrator;

namespace Electronice.Data.migrations
{

    [Migration(10112025)]
    public class TestMigrate:Migration
    {

        public override void Up()
        {
            Execute.Script(@"Data/scripts/data.sql");
        }



        public override void Down()
        {
            throw new NotImplementedException();
        }



    }
}
