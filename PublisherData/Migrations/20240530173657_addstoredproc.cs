using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    public partial class addstoredproc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE PROCEDURE dbo.AuthorsPublishedInYearRange
                    @yearsStart int,
                    @yearsEnd int
                  AS
                  SELECT Distinct Authors.* FROM authors
                  LEFT JOIN Books ON Authors.AuthorId = books.AuthorId
                  WHERE Year(books.PublishDate) >= @yearsStart AND Year(books.PublishDate) <= @yearsEnd"
                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"DROP PROCEDURE dbo.AuthorsPublishedInYearRange"
            );
        }
    }
}
