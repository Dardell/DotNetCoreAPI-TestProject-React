using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotNetCoreTestProject.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "character varying(100000)", maxLength: 100000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is post 1 and that's it.", "Post 1" },
                    { 2, "This is post 2 and that's it.", "Post 2" },
                    { 3, "This is post 3 and that's it.", "Post 3" },
                    { 4, "This is post 4 and that's it.", "Post 4" },
                    { 5, "This is post 5 and that's it.", "Post 5" },
                    { 6, "This is post 6 and that's it.", "Post 6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
