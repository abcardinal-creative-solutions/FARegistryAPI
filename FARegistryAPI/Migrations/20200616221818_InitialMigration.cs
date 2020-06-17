using Microsoft.EntityFrameworkCore.Migrations;

namespace FARegistryAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistryRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PATHNoNoduSAPH = table.Column<string>(nullable: true),
                    TitleTitre = table.Column<string>(nullable: true),
                    ProvinceTerritory = table.Column<string>(nullable: true),
                    ProvinceTerritoire = table.Column<string>(nullable: true),
                    LatitudeLatitude = table.Column<string>(nullable: true),
                    LongitudeLongitude = table.Column<string>(nullable: true),
                    WatershedNomduBassin = table.Column<string>(nullable: true),
                    PrimaryWork = table.Column<string>(nullable: true),
                    Ouvrageprincipal = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Etat = table.Column<string>(nullable: true),
                    ProponentOrganization = table.Column<string>(nullable: true),
                    PromoteurOrganisme = table.Column<string>(nullable: true),
                    RegistryContactduRegistre = table.Column<string>(nullable: true),
                    ContactURL = table.Column<string>(nullable: true),
                    URLdecontact = table.Column<string>(nullable: true),
                    AuthDateDatedeauth = table.Column<string>(nullable: true),
                    EffectiveDateDateenvigueur = table.Column<string>(nullable: true),
                    ExpiryDateDatedexpire = table.Column<string>(nullable: true),
                    AuthorizationType = table.Column<string>(nullable: true),
                    Typedeauthorization = table.Column<string>(nullable: true),
                    ProjectDescDescduprojet = table.Column<string>(nullable: true),
                    LocationDescAutreinfogeo = table.Column<string>(nullable: true),
                    FederalStakeholders = table.Column<string>(nullable: true),
                    Lespartiesprenantesfed = table.Column<string>(nullable: true),
                    ProvincialStakeholders = table.Column<string>(nullable: true),
                    Lespartiesprenantesprov = table.Column<string>(nullable: true),
                    ProgramActivity = table.Column<string>(nullable: true),
                    REGION = table.Column<string>(nullable: true),
                    RGION = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistryRecords", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistryRecords");
        }
    }
}
