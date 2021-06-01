using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BgFishingPlaces.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baits",
                columns: table => new
                {
                    BaitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PictureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baits", x => x.BaitId);
                });

            migrationBuilder.CreateTable(
                name: "Fishes",
                columns: table => new
                {
                    FishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FishName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fishes", x => x.FishId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BaitFish",
                columns: table => new
                {
                    BaitsBaitId = table.Column<int>(type: "int", nullable: false),
                    FishesFishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaitFish", x => new { x.BaitsBaitId, x.FishesFishId });
                    table.ForeignKey(
                        name: "FK_BaitFish_Baits_BaitsBaitId",
                        column: x => x.BaitsBaitId,
                        principalTable: "Baits",
                        principalColumn: "BaitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaitFish_Fishes_FishesFishId",
                        column: x => x.FishesFishId,
                        principalTable: "Fishes",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservoirs",
                columns: table => new
                {
                    ReservoirId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservoirName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReservoirAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ReservoirCoordinates = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    AddedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ApprovalCounter = table.Column<int>(type: "int", nullable: false),
                    SavedReservoirUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservoirDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservoirs", x => x.ReservoirId);
                    table.ForeignKey(
                        name: "FK_Reservoirs_Users_AddedByUserId",
                        column: x => x.AddedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservoirs_Users_SavedReservoirUserId",
                        column: x => x.SavedReservoirUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FishReservoir",
                columns: table => new
                {
                    FishesFishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservoirsReservoirId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishReservoir", x => new { x.FishesFishId, x.ReservoirsReservoirId });
                    table.ForeignKey(
                        name: "FK_FishReservoir_Fishes_FishesFishId",
                        column: x => x.FishesFishId,
                        principalTable: "Fishes",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishReservoir_Reservoirs_ReservoirsReservoirId",
                        column: x => x.ReservoirsReservoirId,
                        principalTable: "Reservoirs",
                        principalColumn: "ReservoirId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    PictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PictureExtension = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ReservoirId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FishId = table.Column<int>(type: "int", nullable: true),
                    BaitId = table.Column<int>(type: "int", nullable: true),
                    UserAddedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PictureId);
                    table.ForeignKey(
                        name: "FK_Pictures_Baits_BaitId",
                        column: x => x.BaitId,
                        principalTable: "Baits",
                        principalColumn: "BaitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pictures_Fishes_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Fishes",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pictures_Reservoirs_ReservoirId",
                        column: x => x.ReservoirId,
                        principalTable: "Reservoirs",
                        principalColumn: "ReservoirId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pictures_Users_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SimilarNames",
                columns: table => new
                {
                    SimilarNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ReservoirId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaitId = table.Column<int>(type: "int", nullable: true),
                    FishId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimilarNames", x => x.SimilarNameId);
                    table.ForeignKey(
                        name: "FK_SimilarNames_Baits_BaitId",
                        column: x => x.BaitId,
                        principalTable: "Baits",
                        principalColumn: "BaitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SimilarNames_Fishes_FishId",
                        column: x => x.FishId,
                        principalTable: "Fishes",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SimilarNames_Reservoirs_ReservoirId",
                        column: x => x.ReservoirId,
                        principalTable: "Reservoirs",
                        principalColumn: "ReservoirId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9f4d859f-74fc-49e2-8b7e-7040fba11d55"), "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_BaitFish_FishesFishId",
                table: "BaitFish",
                column: "FishesFishId");

            migrationBuilder.CreateIndex(
                name: "IX_FishReservoir_ReservoirsReservoirId",
                table: "FishReservoir",
                column: "ReservoirsReservoirId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_BaitId",
                table: "Pictures",
                column: "BaitId",
                unique: true,
                filter: "[BaitId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ReservoirId",
                table: "Pictures",
                column: "ReservoirId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_UserAddedId",
                table: "Pictures",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservoirs_AddedByUserId",
                table: "Reservoirs",
                column: "AddedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservoirs_SavedReservoirUserId",
                table: "Reservoirs",
                column: "SavedReservoirUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersUserId",
                table: "RoleUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SimilarNames_BaitId",
                table: "SimilarNames",
                column: "BaitId");

            migrationBuilder.CreateIndex(
                name: "IX_SimilarNames_FishId",
                table: "SimilarNames",
                column: "FishId");

            migrationBuilder.CreateIndex(
                name: "IX_SimilarNames_ReservoirId",
                table: "SimilarNames",
                column: "ReservoirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaitFish");

            migrationBuilder.DropTable(
                name: "FishReservoir");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "SimilarNames");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Baits");

            migrationBuilder.DropTable(
                name: "Fishes");

            migrationBuilder.DropTable(
                name: "Reservoirs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
