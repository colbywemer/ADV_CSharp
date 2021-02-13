using Microsoft.EntityFrameworkCore.Migrations;

namespace WemerMultiPageWebAppDb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Adress", "Name", "Note", "PhoneNumber" },
                values: new object[] { 1, "201 Hazel Street Van Meter Iowa 50261", "Glenn", "Dad", "(515)-210-8346" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Adress", "Name", "Note", "PhoneNumber" },
                values: new object[] { 2, "201 Hazel Street Van Meter Iowa 50261", "Colby", "Me", "(515)-478-4955" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Adress", "Name", "Note", "PhoneNumber" },
                values: new object[] { 3, "201 Hazel Street Van Meter Iowa 50261", "kim", "Mom", "(515)-210-8347" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
