using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyCleanArchitectureApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Smith" },
                    { 3, "Michael Johnson" },
                    { 4, "Emily Davis" },
                    { 5, "Sarah Brown" }
                });



            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AverageRating", "GenreId", "Name" },
                values: new object[,]
                {
                    { 2, 7.7000000000000002, 2, "The Hangover" },
                    { 3, 8.8000000000000007, 5, "Inception" },
                    { 4, 9.1999999999999993, 3, "The Godfather" },
                    { 5, 6.7999999999999998, 4, "It" },
                    { 6, 7.7999999999999998, 6, "Titanic" },
                    { 7, 9.0, 1, "The Dark Knight" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
