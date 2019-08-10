using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATravelersGuideToSerdan.Data.Migrations
{
    public partial class AddedPlayingcharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NpcAlly_NPCs_NpcId",
                table: "NpcAlly");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcEnemy_NPCs_NpcId",
                table: "NpcEnemy");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcFriend_NPCs_NpcId",
                table: "NpcFriend");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcRival_NPCs_NpcId",
                table: "NpcRival");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcsRegularChild_NPCs_NpcId",
                table: "NpcsRegularChild");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcsSerdanEdlosiChild_NPCs_NpcId",
                table: "NpcsSerdanEdlosiChild");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcsSerdanEdlosiChild",
                table: "NpcsSerdanEdlosiChild");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcsRegularChild",
                table: "NpcsRegularChild");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcRival",
                table: "NpcRival");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcFriend",
                table: "NpcFriend");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcEnemy",
                table: "NpcEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcAlly",
                table: "NpcAlly");

            migrationBuilder.RenameTable(
                name: "NpcsSerdanEdlosiChild",
                newName: "NpcsSerdanEdlosiChldren");

            migrationBuilder.RenameTable(
                name: "NpcsRegularChild",
                newName: "NpcsRegularChildren");

            migrationBuilder.RenameTable(
                name: "NpcRival",
                newName: "NpcRivals");

            migrationBuilder.RenameTable(
                name: "NpcFriend",
                newName: "NpcFriends");

            migrationBuilder.RenameTable(
                name: "NpcEnemy",
                newName: "NpcEnemies");

            migrationBuilder.RenameTable(
                name: "NpcAlly",
                newName: "NpcAllies");

            migrationBuilder.RenameIndex(
                name: "IX_NpcsSerdanEdlosiChild_NpcId",
                table: "NpcsSerdanEdlosiChldren",
                newName: "IX_NpcsSerdanEdlosiChldren_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcsRegularChild_NpcId",
                table: "NpcsRegularChildren",
                newName: "IX_NpcsRegularChildren_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcRival_NpcId",
                table: "NpcRivals",
                newName: "IX_NpcRivals_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcFriend_NpcId",
                table: "NpcFriends",
                newName: "IX_NpcFriends_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcEnemy_NpcId",
                table: "NpcEnemies",
                newName: "IX_NpcEnemies_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcAlly_NpcId",
                table: "NpcAllies",
                newName: "IX_NpcAllies_NpcId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcsSerdanEdlosiChldren",
                table: "NpcsSerdanEdlosiChldren",
                column: "NpcsSerdanEdlosiChildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcsRegularChildren",
                table: "NpcsRegularChildren",
                column: "NpcsRegularChildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcRivals",
                table: "NpcRivals",
                column: "NpcRivalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcFriends",
                table: "NpcFriends",
                column: "NpcFriendId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcEnemies",
                table: "NpcEnemies",
                column: "NpcEnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcAllies",
                table: "NpcAllies",
                column: "NpcAllyId");

            migrationBuilder.CreateTable(
                name: "PlayingCharacter",
                columns: table => new
                {
                    PlayingCharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterName = table.Column<string>(maxLength: 40, nullable: false),
                    PlayerName = table.Column<string>(maxLength: 40, nullable: false),
                    CharacterDescription = table.Column<string>(maxLength: 40, nullable: false),
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
                    PowerDragon = table.Column<byte>(nullable: false),
                    PowerUnicorn = table.Column<byte>(nullable: false),
                    PowerHealer = table.Column<byte>(nullable: false),
                    PowerGriffon = table.Column<byte>(nullable: false),
                    PowerManticore = table.Column<byte>(nullable: false),
                    PowerBody = table.Column<byte>(nullable: false),
                    PowerSymbol = table.Column<byte>(nullable: false),
                    PowerDoor = table.Column<byte>(nullable: false),
                    PowerTime = table.Column<byte>(nullable: false),
                    PowerMagic = table.Column<byte>(nullable: false),
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
                    PowerAllocatedPoints = table.Column<int>(nullable: false),
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
                    ContactDragon = table.Column<int>(nullable: false),
                    ContactDragonWho = table.Column<string>(nullable: true),
                    ContactGrip = table.Column<int>(nullable: false),
                    ContactGripWho = table.Column<string>(nullable: true),
                    ContactDemon = table.Column<int>(nullable: false),
                    ContactDemonWho = table.Column<string>(nullable: true),
                    ContactAet = table.Column<int>(nullable: false),
                    ContactAetWho = table.Column<string>(nullable: true),
                    ContactSerdan = table.Column<int>(nullable: false),
                    ContactSerdanWho = table.Column<string>(nullable: true),
                    ContactEdlosi = table.Column<int>(nullable: false),
                    ContactEdlosiWho = table.Column<string>(nullable: true),
                    ContactWatchman = table.Column<int>(nullable: false),
                    ContactWatchmanWho = table.Column<string>(nullable: true),
                    ContactBlod = table.Column<int>(nullable: false),
                    ContactBlodValue = table.Column<string>(nullable: true),
                    AllocatedPointsTotalPoints = table.Column<int>(nullable: false),
                    AllocatedPointsHandedoutPoints = table.Column<int>(nullable: false),
                    AllocatedPointsSavedPoints = table.Column<int>(nullable: false),
                    PowerPoints = table.Column<int>(nullable: false),
                    BoundPowerPoints = table.Column<int>(nullable: false),
                    Relatives = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayingCharacter", x => x.PlayingCharacterId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_NpcAllies_NPCs_NpcId",
                table: "NpcAllies",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcEnemies_NPCs_NpcId",
                table: "NpcEnemies",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcFriends_NPCs_NpcId",
                table: "NpcFriends",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcRivals_NPCs_NpcId",
                table: "NpcRivals",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcsRegularChildren_NPCs_NpcId",
                table: "NpcsRegularChildren",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcsSerdanEdlosiChldren_NPCs_NpcId",
                table: "NpcsSerdanEdlosiChldren",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NpcAllies_NPCs_NpcId",
                table: "NpcAllies");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcEnemies_NPCs_NpcId",
                table: "NpcEnemies");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcFriends_NPCs_NpcId",
                table: "NpcFriends");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcRivals_NPCs_NpcId",
                table: "NpcRivals");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcsRegularChildren_NPCs_NpcId",
                table: "NpcsRegularChildren");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcsSerdanEdlosiChldren_NPCs_NpcId",
                table: "NpcsSerdanEdlosiChldren");

            migrationBuilder.DropTable(
                name: "PlayingCharacter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcsSerdanEdlosiChldren",
                table: "NpcsSerdanEdlosiChldren");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcsRegularChildren",
                table: "NpcsRegularChildren");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcRivals",
                table: "NpcRivals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcFriends",
                table: "NpcFriends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcEnemies",
                table: "NpcEnemies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NpcAllies",
                table: "NpcAllies");

            migrationBuilder.RenameTable(
                name: "NpcsSerdanEdlosiChldren",
                newName: "NpcsSerdanEdlosiChild");

            migrationBuilder.RenameTable(
                name: "NpcsRegularChildren",
                newName: "NpcsRegularChild");

            migrationBuilder.RenameTable(
                name: "NpcRivals",
                newName: "NpcRival");

            migrationBuilder.RenameTable(
                name: "NpcFriends",
                newName: "NpcFriend");

            migrationBuilder.RenameTable(
                name: "NpcEnemies",
                newName: "NpcEnemy");

            migrationBuilder.RenameTable(
                name: "NpcAllies",
                newName: "NpcAlly");

            migrationBuilder.RenameIndex(
                name: "IX_NpcsSerdanEdlosiChldren_NpcId",
                table: "NpcsSerdanEdlosiChild",
                newName: "IX_NpcsSerdanEdlosiChild_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcsRegularChildren_NpcId",
                table: "NpcsRegularChild",
                newName: "IX_NpcsRegularChild_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcRivals_NpcId",
                table: "NpcRival",
                newName: "IX_NpcRival_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcFriends_NpcId",
                table: "NpcFriend",
                newName: "IX_NpcFriend_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcEnemies_NpcId",
                table: "NpcEnemy",
                newName: "IX_NpcEnemy_NpcId");

            migrationBuilder.RenameIndex(
                name: "IX_NpcAllies_NpcId",
                table: "NpcAlly",
                newName: "IX_NpcAlly_NpcId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcsSerdanEdlosiChild",
                table: "NpcsSerdanEdlosiChild",
                column: "NpcsSerdanEdlosiChildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcsRegularChild",
                table: "NpcsRegularChild",
                column: "NpcsRegularChildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcRival",
                table: "NpcRival",
                column: "NpcRivalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcFriend",
                table: "NpcFriend",
                column: "NpcFriendId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcEnemy",
                table: "NpcEnemy",
                column: "NpcEnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NpcAlly",
                table: "NpcAlly",
                column: "NpcAllyId");

            migrationBuilder.AddForeignKey(
                name: "FK_NpcAlly_NPCs_NpcId",
                table: "NpcAlly",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcEnemy_NPCs_NpcId",
                table: "NpcEnemy",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcFriend_NPCs_NpcId",
                table: "NpcFriend",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcRival_NPCs_NpcId",
                table: "NpcRival",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcsRegularChild_NPCs_NpcId",
                table: "NpcsRegularChild",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcsSerdanEdlosiChild_NPCs_NpcId",
                table: "NpcsSerdanEdlosiChild",
                column: "NpcId",
                principalTable: "NPCs",
                principalColumn: "NpcId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
