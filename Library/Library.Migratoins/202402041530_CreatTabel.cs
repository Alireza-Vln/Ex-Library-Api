using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202402041530)]
    public class _202402041530_CreatTabel : Migration
    {
        public override void Up()
        {
            Create.Table("Authors")
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("Name").AsString(50).NotNullable();

            Create.Table("Books")
                     .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                     .WithColumn("Name").AsString(50).NotNullable()
                     .WithColumn("Count").AsInt32().NotNullable()
                     .WithColumn("RentBook").AsInt32().NotNullable()
                     .WithColumn("AuthorId").AsInt32().NotNullable().ForeignKey()
                     .WithColumn("UserId").AsInt32().ForeignKey();
            

            Create.Table("Categories")
                     .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                     .WithColumn("Name").AsString(50).NotNullable()
                     .WithColumn("BookId").AsInt32().NotNullable().ForeignKey();

            Create.Table("Users")
                 .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                 .WithColumn("Name").AsString(50).NotNullable()
                 .WithColumn("BookCount").AsInt32().PrimaryKey();
        }
        public override void Down()
        {
            Delete.Table("Categories");
            Delete.Table("Books");
            Delete.Table("Authors");
            Delete.Table("Users");
        }

      
    }
}
