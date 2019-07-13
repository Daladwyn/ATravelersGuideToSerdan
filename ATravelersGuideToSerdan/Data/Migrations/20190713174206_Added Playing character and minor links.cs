using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATravelersGuideToSerdan.Data.Migrations
{
    public partial class AddedPlayingcharacterandminorlinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(maxLength: 40, nullable: false),
                    CityIsCapital = table.Column<bool>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    CityDescription = table.Column<string>(maxLength: 200, nullable: true),
                    CityPopulation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "NpcMagics",
                columns: table => new
                {
                    NpcMagicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    MagiVisuellt = table.Column<bool>(nullable: false),
                    MagiSymbol = table.Column<bool>(nullable: false),
                    MagiAlkemi = table.Column<bool>(nullable: false),
                    MagiBlod = table.Column<bool>(nullable: false),
                    MagiKraft = table.Column<bool>(nullable: false),
                    MagiVerkligheten = table.Column<bool>(nullable: false),
                    MagiDraperiet = table.Column<bool>(nullable: false),
                    MagiDysterheten = table.Column<bool>(nullable: false),
                    MagiEtnor = table.Column<bool>(nullable: false),
                    MagiDrommen = table.Column<bool>(nullable: false),
                    MagiSlojan = table.Column<bool>(nullable: false),
                    MagiParallellium = table.Column<bool>(nullable: false),
                    MagiElementa = table.Column<bool>(nullable: false),
                    MagiSe = table.Column<bool>(nullable: false),
                    MagiOkaMinska = table.Column<bool>(nullable: false),
                    MagiOmvandling = table.Column<bool>(nullable: false),
                    MagiTransformering = table.Column<bool>(nullable: false),
                    MagiSkapa = table.Column<bool>(nullable: false),
                    MagiEnergi = table.Column<bool>(nullable: false),
                    MagiRum = table.Column<bool>(nullable: false),
                    MagiMateria = table.Column<bool>(nullable: false),
                    MagiSinne = table.Column<bool>(nullable: false),
                    MagiLiv = table.Column<bool>(nullable: false),
                    MagiSjal = table.Column<bool>(nullable: false),
                    MagiTid = table.Column<bool>(nullable: false),
                    SummaPoangMagi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcMagics", x => x.NpcMagicId);
                });

            migrationBuilder.CreateTable(
                name: "NpcPowers",
                columns: table => new
                {
                    NpcPowerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    PowerDragon = table.Column<byte>(nullable: false),
                    PowerUnicorn = table.Column<byte>(nullable: false),
                    PowerHealer = table.Column<byte>(nullable: false),
                    PowerGriffon = table.Column<byte>(nullable: false),
                    PowerManticore = table.Column<byte>(nullable: false),
                    PowerBody = table.Column<byte>(nullable: false),
                    PowerSymbol = table.Column<byte>(nullable: false),
                    PowerDoor = table.Column<byte>(nullable: false),
                    PowerElementa = table.Column<byte>(nullable: false),
                    PowerMind = table.Column<byte>(nullable: false),
                    PowerNature = table.Column<byte>(nullable: false),
                    PowerAnimal = table.Column<byte>(nullable: false),
                    PowerWater = table.Column<byte>(nullable: false),
                    PowerEarth = table.Column<byte>(nullable: false),
                    PowerLight = table.Column<byte>(nullable: false),
                    PowerElectricity = table.Column<byte>(nullable: false),
                    PowerFire = table.Column<byte>(nullable: false),
                    PowerWind = table.Column<byte>(nullable: false),
                    PowerDarkness = table.Column<byte>(nullable: false),
                    PowerSword = table.Column<byte>(nullable: false),
                    PowerMateria = table.Column<byte>(nullable: false),
                    SummaPoangKrafter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcPowers", x => x.NpcPowerId);
                });

            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    NpcId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcName = table.Column<string>(maxLength: 40, nullable: false),
                    NpcEvenKnownAs = table.Column<string>(nullable: true),
                    NpcAlias = table.Column<string>(maxLength: 40, nullable: true),
                    NpcDescriptivePhrase = table.Column<string>(maxLength: 100, nullable: true),
                    NpcLooks = table.Column<string>(maxLength: 100, nullable: true),
                    NpcDescription = table.Column<string>(maxLength: 200, nullable: true),
                    NpcCurrentResidence = table.Column<string>(maxLength: 40, nullable: true),
                    NpcRace = table.Column<string>(maxLength: 20, nullable: true),
                    NpcIsAPlayer = table.Column<bool>(nullable: false),
                    NpcFamily = table.Column<string>(maxLength: 40, nullable: true),
                    NpcArchetyp = table.Column<int>(nullable: false),
                    NpcKilledBy = table.Column<int>(nullable: false),
                    NpcBehaviour = table.Column<string>(maxLength: 200, nullable: true),
                    NpcAsAParent = table.Column<string>(maxLength: 200, nullable: true),
                    NpcGoal = table.Column<string>(maxLength: 200, nullable: true),
                    NpcInBattle = table.Column<string>(maxLength: 200, nullable: true),
                    NpcsMother = table.Column<int>(nullable: false),
                    NpcsFather = table.Column<int>(nullable: false),
                    NpcRegardingAets = table.Column<string>(maxLength: 100, nullable: true),
                    NpcRegardingDemons = table.Column<string>(maxLength: 100, nullable: true),
                    NpcRegardingDragons = table.Column<string>(maxLength: 100, nullable: true),
                    NpcRegardingGrips = table.Column<string>(maxLength: 100, nullable: true),
                    NpcRegardingOthers = table.Column<string>(maxLength: 100, nullable: true),
                    NpcOtherResideces = table.Column<string>(maxLength: 200, nullable: true),
                    NpcInTheHistory = table.Column<string>(maxLength: 300, nullable: true),
                    NpcSecrets = table.Column<string>(maxLength: 300, nullable: true),
                    NpcAssets = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.NpcId);
                });

            migrationBuilder.CreateTable(
                name: "NpcStats",
                columns: table => new
                {
                    NpcStatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    KoordinationMotorikTot = table.Column<int>(nullable: false),
                    KoordinationMotorikUts = table.Column<int>(nullable: false),
                    WeaponValue = table.Column<int>(nullable: false),
                    WeaponTp = table.Column<int>(nullable: false),
                    WeaponExp = table.Column<int>(nullable: false),
                    WeaponTalang = table.Column<string>(nullable: true),
                    WeaponTTp = table.Column<int>(nullable: false),
                    WeaponSkills = table.Column<string>(nullable: true),
                    BalisticValue = table.Column<int>(nullable: false),
                    BalisticTp = table.Column<int>(nullable: false),
                    BalisticExp = table.Column<int>(nullable: false),
                    BalisticTalang = table.Column<string>(nullable: true),
                    BalisticTTp = table.Column<int>(nullable: false),
                    BalisticSkills = table.Column<string>(nullable: true),
                    FineMotorValue = table.Column<int>(nullable: false),
                    FineMotorTp = table.Column<int>(nullable: false),
                    FineMotorExp = table.Column<int>(nullable: false),
                    FineMotorTalang = table.Column<string>(nullable: true),
                    FineMotorTTp = table.Column<int>(nullable: false),
                    FineMotorSkills = table.Column<string>(nullable: true),
                    PhysiqueTot = table.Column<int>(nullable: false),
                    PhysiqueUts = table.Column<int>(nullable: false),
                    PhysicsValue = table.Column<int>(nullable: false),
                    PhysicsTp = table.Column<int>(nullable: false),
                    PhysicsExp = table.Column<int>(nullable: false),
                    PhysicsTalang = table.Column<string>(nullable: true),
                    PhysicsTTp = table.Column<int>(nullable: false),
                    PhysicsSkills = table.Column<string>(nullable: true),
                    StrenghtValue = table.Column<int>(nullable: false),
                    StrenghtTp = table.Column<int>(nullable: false),
                    StrenghtExp = table.Column<int>(nullable: false),
                    StrenghtTalang = table.Column<string>(nullable: true),
                    StrenghtTTp = table.Column<int>(nullable: false),
                    StrenghtSkills = table.Column<string>(nullable: true),
                    MobilityValue = table.Column<int>(nullable: false),
                    MobilityTp = table.Column<int>(nullable: false),
                    MobilityExp = table.Column<int>(nullable: false),
                    MobilityTalang = table.Column<string>(nullable: true),
                    MobilityTTp = table.Column<int>(nullable: false),
                    MobilitySkills = table.Column<string>(nullable: true),
                    PsykeTot = table.Column<int>(nullable: false),
                    PsykeUts = table.Column<int>(nullable: false),
                    WillValue = table.Column<int>(nullable: false),
                    WillTp = table.Column<int>(nullable: false),
                    WillExp = table.Column<int>(nullable: false),
                    WillTalang = table.Column<string>(nullable: true),
                    WillTTp = table.Column<int>(nullable: false),
                    WillSkills = table.Column<string>(nullable: true),
                    CreativityValue = table.Column<int>(nullable: false),
                    CreativityTp = table.Column<int>(nullable: false),
                    CreativityExp = table.Column<int>(nullable: false),
                    CreativityTalang = table.Column<string>(nullable: true),
                    CreativityTTp = table.Column<int>(nullable: false),
                    CreativitySkills = table.Column<string>(nullable: true),
                    EducationValue = table.Column<int>(nullable: false),
                    EducationTp = table.Column<int>(nullable: false),
                    EducationExp = table.Column<int>(nullable: false),
                    EducationTalang = table.Column<string>(nullable: true),
                    EducationTTp = table.Column<int>(nullable: false),
                    EducationSkills = table.Column<string>(nullable: true),
                    PerceptionTot = table.Column<int>(nullable: false),
                    PerceptionUts = table.Column<int>(nullable: false),
                    IntuitionValue = table.Column<int>(nullable: false),
                    IntuitionTp = table.Column<int>(nullable: false),
                    IntuitionExp = table.Column<int>(nullable: false),
                    IntuitionTalang = table.Column<string>(nullable: true),
                    IntuitionTTp = table.Column<int>(nullable: false),
                    IntuitionSkills = table.Column<string>(nullable: true),
                    MagicVisionValue = table.Column<int>(nullable: false),
                    MagicVisionTp = table.Column<int>(nullable: false),
                    MagicVisionExp = table.Column<int>(nullable: false),
                    MagicVisionTalang = table.Column<string>(nullable: true),
                    MagicVisionTTp = table.Column<int>(nullable: false),
                    MagicVisionSkills = table.Column<string>(nullable: true),
                    AttentionValue = table.Column<int>(nullable: false),
                    AttentionTp = table.Column<int>(nullable: false),
                    AttentionExp = table.Column<int>(nullable: false),
                    AttentionTalang = table.Column<string>(nullable: true),
                    AttentionTTp = table.Column<int>(nullable: false),
                    AttentionSkills = table.Column<string>(nullable: true),
                    SocialTot = table.Column<int>(nullable: false),
                    SocialUts = table.Column<int>(nullable: false),
                    CharismaValue = table.Column<int>(nullable: false),
                    CharismaTp = table.Column<int>(nullable: false),
                    CharismaExp = table.Column<int>(nullable: false),
                    CharismaTalang = table.Column<string>(nullable: true),
                    CharismaTTp = table.Column<int>(nullable: false),
                    CharismaSkills = table.Column<string>(nullable: true),
                    InsightValue = table.Column<int>(nullable: false),
                    InsightTp = table.Column<int>(nullable: false),
                    InsightExp = table.Column<int>(nullable: false),
                    InsightTalang = table.Column<string>(nullable: true),
                    InsightTTp = table.Column<int>(nullable: false),
                    InsightSkills = table.Column<string>(nullable: true),
                    ResistanceValue = table.Column<int>(nullable: false),
                    ResistanceTp = table.Column<int>(nullable: false),
                    ResistanceExp = table.Column<int>(nullable: false),
                    ResistanceTalang = table.Column<string>(nullable: true),
                    ResistanceTTp = table.Column<int>(nullable: false),
                    ResistanceSkills = table.Column<string>(nullable: true),
                    PhysicalDamageMax = table.Column<int>(nullable: false),
                    PhysicalDamage = table.Column<int>(nullable: false),
                    SoulDamageMax = table.Column<int>(nullable: false),
                    SoulDamage = table.Column<int>(nullable: false),
                    DragonContact = table.Column<byte>(nullable: false),
                    DragonContactWho = table.Column<string>(maxLength: 50, nullable: true),
                    GriffonContact = table.Column<byte>(nullable: false),
                    GriffonContactWho = table.Column<string>(maxLength: 50, nullable: true),
                    DemonContact = table.Column<byte>(nullable: false),
                    DemonContactWho = table.Column<string>(maxLength: 50, nullable: true),
                    AetContact = table.Column<byte>(nullable: false),
                    AetContactWho = table.Column<string>(maxLength: 50, nullable: true),
                    SerdanContact = table.Column<byte>(nullable: false),
                    SerdanContactWho = table.Column<string>(maxLength: 50, nullable: true),
                    EdlosiContact = table.Column<byte>(nullable: false),
                    EdlosiContactWho = table.Column<string>(maxLength: 50, nullable: true),
                    GuardianFriend = table.Column<int>(nullable: false),
                    GuardianFriendWho = table.Column<string>(maxLength: 50, nullable: true),
                    BraDaligtBlod = table.Column<int>(nullable: false),
                    SummaPoangKontakter = table.Column<int>(nullable: false),
                    TotalaPoang = table.Column<int>(nullable: false),
                    UtdeladePoang = table.Column<int>(nullable: false),
                    SparadePoang = table.Column<int>(nullable: false),
                    KraftPoang = table.Column<int>(nullable: false),
                    BundnaKraftPoang = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcStats", x => x.NpcStatId);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlaceName = table.Column<string>(maxLength: 40, nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    PlaceDescription = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    PlanetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanetName = table.Column<string>(maxLength: 40, nullable: false),
                    PlanetRulerId = table.Column<int>(nullable: false),
                    DistanceToGalo = table.Column<string>(maxLength: 100, nullable: true),
                    PlanetDescription = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.PlanetId);
                });

            migrationBuilder.CreateTable(
                name: "NpcAlly",
                columns: table => new
                {
                    NpcAllyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    AllyId = table.Column<int>(nullable: false),
                    AllyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcAlly", x => x.NpcAllyId);
                    table.ForeignKey(
                        name: "FK_NpcAlly_NPCs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "NPCs",
                        principalColumn: "NpcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NpcEnemy",
                columns: table => new
                {
                    NpcEnemyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    EnemyId = table.Column<int>(nullable: false),
                    EnemyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcEnemy", x => x.NpcEnemyId);
                    table.ForeignKey(
                        name: "FK_NpcEnemy_NPCs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "NPCs",
                        principalColumn: "NpcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NpcFriend",
                columns: table => new
                {
                    NpcFriendId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    FriendId = table.Column<int>(nullable: false),
                    FriendName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcFriend", x => x.NpcFriendId);
                    table.ForeignKey(
                        name: "FK_NpcFriend_NPCs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "NPCs",
                        principalColumn: "NpcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NpcRival",
                columns: table => new
                {
                    NpcRivalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    RivalId = table.Column<int>(nullable: false),
                    RivalName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcRival", x => x.NpcRivalId);
                    table.ForeignKey(
                        name: "FK_NpcRival_NPCs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "NPCs",
                        principalColumn: "NpcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NpcsRegularChild",
                columns: table => new
                {
                    NpcsRegularChildId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    ChildId = table.Column<int>(nullable: false),
                    ChildName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcsRegularChild", x => x.NpcsRegularChildId);
                    table.ForeignKey(
                        name: "FK_NpcsRegularChild_NPCs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "NPCs",
                        principalColumn: "NpcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NpcsSerdanEdlosiChild",
                columns: table => new
                {
                    NpcsSerdanEdlosiChildId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    ChildId = table.Column<int>(nullable: false),
                    ChildName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcsSerdanEdlosiChild", x => x.NpcsSerdanEdlosiChildId);
                    table.ForeignKey(
                        name: "FK_NpcsSerdanEdlosiChild_NPCs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "NPCs",
                        principalColumn: "NpcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanetId = table.Column<int>(nullable: false),
                    CountryName = table.Column<string>(maxLength: 40, nullable: false),
                    Government = table.Column<string>(maxLength: 40, nullable: true),
                    HeadOfStateId = table.Column<int>(nullable: false),
                    CapitalId = table.Column<int>(nullable: false),
                    CountryDescription = table.Column<string>(maxLength: 200, nullable: true),
                    CountryHistory = table.Column<string>(maxLength: 500, nullable: true),
                    CountryPopulation = table.Column<int>(nullable: false),
                    CountryClimat = table.Column<string>(maxLength: 200, nullable: true),
                    CountryGeography = table.Column<string>(maxLength: 200, nullable: true),
                    Fauna = table.Column<string>(maxLength: 200, nullable: true),
                    Flora = table.Column<string>(maxLength: 200, nullable: true),
                    Export = table.Column<string>(maxLength: 200, nullable: true),
                    Import = table.Column<string>(maxLength: 200, nullable: true),
                    ArmySize = table.Column<string>(maxLength: 200, nullable: true),
                    ArmyStrenght = table.Column<string>(maxLength: 200, nullable: true),
                    NavalSize = table.Column<string>(maxLength: 200, nullable: true),
                    NavalStrenght = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_PlanetId",
                table: "Countries",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcAlly_NpcId",
                table: "NpcAlly",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcEnemy_NpcId",
                table: "NpcEnemy",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcFriend_NpcId",
                table: "NpcFriend",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcRival_NpcId",
                table: "NpcRival",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcsRegularChild_NpcId",
                table: "NpcsRegularChild",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcsSerdanEdlosiChild_NpcId",
                table: "NpcsSerdanEdlosiChild",
                column: "NpcId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "NpcAlly");

            migrationBuilder.DropTable(
                name: "NpcEnemy");

            migrationBuilder.DropTable(
                name: "NpcFriend");

            migrationBuilder.DropTable(
                name: "NpcMagics");

            migrationBuilder.DropTable(
                name: "NpcPowers");

            migrationBuilder.DropTable(
                name: "NpcRival");

            migrationBuilder.DropTable(
                name: "NpcsRegularChild");

            migrationBuilder.DropTable(
                name: "NpcsSerdanEdlosiChild");

            migrationBuilder.DropTable(
                name: "NpcStats");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "NPCs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
