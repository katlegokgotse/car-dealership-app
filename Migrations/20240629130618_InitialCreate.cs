using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealershipApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    AdministratorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministratorUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdministratorPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdministratorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarYear = table.Column<int>(type: "int", nullable: false),
                    CarColour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarState = table.Column<int>(type: "int", nullable: false),
                    CarExtras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarAdvertisementState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "InterestedPeople",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarAdvertId = table.Column<int>(type: "int", nullable: false),
                    CarsCarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestedPeople", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_InterestedPeople_Cars_CarsCarId",
                        column: x => x.CarsCarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestedPeople_CarsCarId",
                table: "InterestedPeople",
                column: "CarsCarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "InterestedPeople");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
