using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubscriptionOfferSheets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PublishDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionOfferSheets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromotionLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConditionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriorityWeight = table.Column<int>(type: "int", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionOfferSheetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeniorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromotionLines_SubscriptionOfferSheets_SubscriptionOfferSheetId",
                        column: x => x.SubscriptionOfferSheetId,
                        principalTable: "SubscriptionOfferSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SubscriptionOfferSheets",
                columns: new[] { "Id", "Country", "Created", "CreationDate", "Description", "LastUpdated", "PublishDate" },
                values: new object[] { new Guid("c784ba51-c713-4eaa-b7ec-6cc890223c91"), "O0QJWNTA9R", new DateTimeOffset(new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2011, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "HSWGGO7QOKHZ1OU73G0APMI98", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2004, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "SubscriptionOfferSheets",
                columns: new[] { "Id", "Country", "Created", "CreationDate", "Description", "LastUpdated", "PublishDate" },
                values: new object[] { new Guid("caa7101c-47c3-481d-ad85-b1084ebefe8f"), "UWW614P1AO", new DateTimeOffset(new DateTime(2016, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2005, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "6HVUJYAWFPSIRIGOXBFMHG0XY", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2003, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "PromotionLines",
                columns: new[] { "Id", "Code", "ConditionDescription", "Country", "Created", "LastUpdated", "Name", "OfferId", "PriorityWeight", "SeniorityId", "SubscriptionOfferSheetId" },
                values: new object[,]
                {
                    { new Guid("2344d940-9739-47a8-aa7d-4612c5031c11"), "KAH2HKGTZ2", "FPS97BWKFCVUOKMTKT1CK8VS7", "RN0TT9MJSB", new DateTimeOffset(new DateTime(2002, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "AYOZ8JD6QWWGNSKRRK2MLZYDR", new Guid("00000000-0000-0000-0000-000000000000"), 1, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("caa7101c-47c3-481d-ad85-b1084ebefe8f") },
                    { new Guid("2986fc35-42b6-48e1-a511-ef2a9d758daa"), "6ARHEQ28Q7", "IUXPI654C7ATDX1MSHNPJUL24", "79D3K6GDMS", new DateTimeOffset(new DateTime(2010, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2XESDI7263Q706COTZRI0FSCD", new Guid("00000000-0000-0000-0000-000000000000"), 1, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("caa7101c-47c3-481d-ad85-b1084ebefe8f") },
                    { new Guid("5d8f24f7-aae3-4e7f-b9d2-9092d05fbc29"), "GBDZ31CC8L", "OQMINY1KLST01PS1V3S8RO4YV", "DUJW3VVSFN", new DateTimeOffset(new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LWU16WCM2JPYIL33RJ97JBAKM", new Guid("00000000-0000-0000-0000-000000000000"), 1, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c784ba51-c713-4eaa-b7ec-6cc890223c91") },
                    { new Guid("8cfa7de2-7f78-4786-bbf7-9ca84dba0d7b"), "UBF2VM046W", "QJH9HQA60GFTI382SL0PPELXF", "O7I8YDLIG7", new DateTimeOffset(new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "5BHGFP5PM702G0VX7XVV59D4A", new Guid("00000000-0000-0000-0000-000000000000"), 1, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("caa7101c-47c3-481d-ad85-b1084ebefe8f") },
                    { new Guid("95c6eacd-dd07-461d-b1d7-b61cf1adb113"), "U9JCC4402L", "C1NM1B2Y3W6G5PETWCVYST1TV", "E2WGTQCGFG", new DateTimeOffset(new DateTime(2017, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "11B20MT2OCESLOMLGYPHSCFPU", new Guid("00000000-0000-0000-0000-000000000000"), 1, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c784ba51-c713-4eaa-b7ec-6cc890223c91") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PromotionLines_SubscriptionOfferSheetId",
                table: "PromotionLines",
                column: "SubscriptionOfferSheetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PromotionLines");

            migrationBuilder.DropTable(
                name: "SubscriptionOfferSheets");
        }
    }
}
