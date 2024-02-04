using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202402021642)]
    public class _202402021642_Edit:Migration
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
                     .WithColumn("AuthorId").AsInt32().NotNullable().ForeignKey();

            Create.Table("Categories")
                     .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                     .WithColumn("Name").AsString(50).NotNullable()
                     .WithColumn("BookId").AsInt32().NotNullable().ForeignKey();
        }

        public override void Down()
        {
            Delete.Table("Categories");
            Delete.Table("Books");
            Delete.Table("Authors");
        }
    }
}
