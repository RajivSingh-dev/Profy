using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Link_D.Migrations
{
    /// <inheritdoc />
    public partial class AddingReplyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name", 
                table: "post");

            migrationBuilder.DropColumn(
                name: "PostBy",
                table: "post");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "comment",
                newName: "Content");

            migrationBuilder.CreateTable(
                name: "reply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reply_comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_reply_CommentId",
                table: "reply",
                column: "CommentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reply");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "comment",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostBy",
                table: "post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
