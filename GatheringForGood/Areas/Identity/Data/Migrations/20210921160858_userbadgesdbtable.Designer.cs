﻿// <auto-generated />
using System;
using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GatheringForGood.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210921160858_userbadgesdbtable")]
    partial class userbadgesdbtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GatheringForGood.Areas.Identity.Data.CountryList", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number");

                    b.ToTable("CountryList");
                });

            modelBuilder.Entity("GatheringForGood.Areas.Identity.Data.InterestsList", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Interest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number");

                    b.ToTable("InterestsList");
                });

            modelBuilder.Entity("GatheringForGood.Areas.Identity.Data.SkillsList", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Skill")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number");

                    b.ToTable("SkillsList");
                });

            modelBuilder.Entity("GatheringForGood.Areas.Identity.Data.UserBadges", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingBackBetter")
                        .HasColumnType("int");

                    b.Property<int>("CommunicatingForDifference")
                        .HasColumnType("int");

                    b.Property<int>("ContributorForGood")
                        .HasColumnType("int");

                    b.Property<int>("DefeatAnimalExtinction")
                        .HasColumnType("int");

                    b.Property<int>("DefeatDeforestation")
                        .HasColumnType("int");

                    b.Property<int>("DefeatGlobalWarming")
                        .HasColumnType("int");

                    b.Property<int>("FirstStep")
                        .HasColumnType("int");

                    b.Property<int>("GathererForGood")
                        .HasColumnType("int");

                    b.Property<bool>("Helpful")
                        .HasColumnType("bit");

                    b.Property<int>("KeyDriverOfChange")
                        .HasColumnType("int");

                    b.Property<bool>("Leader")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PassionateStartCountDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("PlanetCare")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PlanetCareStartDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("Thankyou")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visionary")
                        .HasColumnType("bit");

                    b.HasKey("Number");

                    b.ToTable("UserBadges");
                });

            modelBuilder.Entity("GatheringForGood.Areas.Identity.Data.UserContact", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FeedbackDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TandC")
                        .HasColumnType("bit");

                    b.Property<string>("Thoughts")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Number");

                    b.ToTable("UserContact");
                });

            modelBuilder.Entity("GatheringForGood.Areas.Identity.Data.UserFeedback", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FeedbackDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number");

                    b.ToTable("UserFeedback");
                });

            modelBuilder.Entity("GatheringForGood.Areas.Identity.SiteEnvironmentalActionCounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SiteBuyLocal")
                        .HasColumnType("int");

                    b.Property<int>("SiteBuyRecycled")
                        .HasColumnType("int");

                    b.Property<int>("SiteCarpool")
                        .HasColumnType("int");

                    b.Property<int>("SiteCompostBin")
                        .HasColumnType("int");

                    b.Property<int>("SiteCycle")
                        .HasColumnType("int");

                    b.Property<long>("SiteDeforestationClicks")
                        .HasColumnType("bigint");

                    b.Property<long>("SiteDeforestationTotal")
                        .HasColumnType("bigint");

                    b.Property<int>("SiteDonate")
                        .HasColumnType("int");

                    b.Property<int>("SiteDriveElectric")
                        .HasColumnType("int");

                    b.Property<int>("SiteEatOrganic")
                        .HasColumnType("int");

                    b.Property<long>("SiteExtinctionClicks")
                        .HasColumnType("bigint");

                    b.Property<long>("SiteExtinctionTotal")
                        .HasColumnType("bigint");

                    b.Property<int>("SiteFamilySizes")
                        .HasColumnType("int");

                    b.Property<int>("SiteFluorescentBulbs")
                        .HasColumnType("int");

                    b.Property<int>("SiteFlyLess")
                        .HasColumnType("int");

                    b.Property<long>("SiteGlobalWarmingClicks")
                        .HasColumnType("bigint");

                    b.Property<long>("SiteGlobalWarmingTotal")
                        .HasColumnType("bigint");

                    b.Property<int>("SiteGoPaperless")
                        .HasColumnType("int");

                    b.Property<int>("SiteGoVegan")
                        .HasColumnType("int");

                    b.Property<int>("SiteGoVegetarian")
                        .HasColumnType("int");

                    b.Property<int>("SiteGreenRecovery")
                        .HasColumnType("int");

                    b.Property<int>("SiteGrowVeg")
                        .HasColumnType("int");

                    b.Property<int>("SiteHabitatRestoration")
                        .HasColumnType("int");

                    b.Property<int>("SiteHerbsAndPesticides")
                        .HasColumnType("int");

                    b.Property<int>("SiteHomeInsulation")
                        .HasColumnType("int");

                    b.Property<int>("SiteLiveCarFree")
                        .HasColumnType("int");

                    b.Property<int>("SiteMinimisePlastic")
                        .HasColumnType("int");

                    b.Property<int>("SitePlantNative")
                        .HasColumnType("int");

                    b.Property<int>("SitePlantTrees")
                        .HasColumnType("int");

                    b.Property<int>("SitePublicTransport")
                        .HasColumnType("int");

                    b.Property<int>("SiteRecyclingBin")
                        .HasColumnType("int");

                    b.Property<int>("SiteReduceMeat")
                        .HasColumnType("int");

                    b.Property<int>("SiteRenewableEnergy")
                        .HasColumnType("int");

                    b.Property<int>("SiteShorterShowers")
                        .HasColumnType("int");

                    b.Property<int>("SiteSignPetition")
                        .HasColumnType("int");

                    b.Property<int>("SiteSlowDown")
                        .HasColumnType("int");

                    b.Property<int>("SiteSocialMedia")
                        .HasColumnType("int");

                    b.Property<int>("SiteStandUp")
                        .HasColumnType("int");

                    b.Property<long>("SiteTotal")
                        .HasColumnType("bigint");

                    b.Property<int>("SiteTurnOffLights")
                        .HasColumnType("int");

                    b.Property<int>("SiteWildlifeRefuge")
                        .HasColumnType("int");

                    b.Property<int>("SiteZeroDeforestation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SiteEnvironmentalActionCounts");
                });

            modelBuilder.Entity("GatheringForGood.Areas.Identity.UserEnvironmentalActionCounts", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BuyLocal")
                        .HasColumnType("int");

                    b.Property<int>("BuyRecycled")
                        .HasColumnType("int");

                    b.Property<int>("Carpool")
                        .HasColumnType("int");

                    b.Property<int>("CompostBin")
                        .HasColumnType("int");

                    b.Property<int>("Cycle")
                        .HasColumnType("int");

                    b.Property<int>("Donate")
                        .HasColumnType("int");

                    b.Property<int>("DriveElectric")
                        .HasColumnType("int");

                    b.Property<int>("EatOrganic")
                        .HasColumnType("int");

                    b.Property<int>("FamilySizes")
                        .HasColumnType("int");

                    b.Property<int>("FluorescentBulbs")
                        .HasColumnType("int");

                    b.Property<int>("FlyLess")
                        .HasColumnType("int");

                    b.Property<int>("GoPaperless")
                        .HasColumnType("int");

                    b.Property<int>("GoVegan")
                        .HasColumnType("int");

                    b.Property<int>("GoVegetarian")
                        .HasColumnType("int");

                    b.Property<int>("GreenRecovery")
                        .HasColumnType("int");

                    b.Property<int>("GrowVeg")
                        .HasColumnType("int");

                    b.Property<int>("HabitatRestoration")
                        .HasColumnType("int");

                    b.Property<int>("HerbsAndPesticides")
                        .HasColumnType("int");

                    b.Property<int>("HomeInsulation")
                        .HasColumnType("int");

                    b.Property<int>("LiveCarFree")
                        .HasColumnType("int");

                    b.Property<int>("MinimisePlastic")
                        .HasColumnType("int");

                    b.Property<int>("PlantNative")
                        .HasColumnType("int");

                    b.Property<int>("PlantTrees")
                        .HasColumnType("int");

                    b.Property<int>("PublicTransport")
                        .HasColumnType("int");

                    b.Property<int>("RecyclingBin")
                        .HasColumnType("int");

                    b.Property<int>("ReduceMeat")
                        .HasColumnType("int");

                    b.Property<int>("RenewableEnergy")
                        .HasColumnType("int");

                    b.Property<int>("ShorterShowers")
                        .HasColumnType("int");

                    b.Property<int>("SignPetition")
                        .HasColumnType("int");

                    b.Property<int>("SlowDown")
                        .HasColumnType("int");

                    b.Property<int>("SocialMedia")
                        .HasColumnType("int");

                    b.Property<int>("StandUp")
                        .HasColumnType("int");

                    b.Property<int>("TurnOffLights")
                        .HasColumnType("int");

                    b.Property<double>("UserBuyLocalCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserBuyRecycledCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserCarpoolCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserCompostBinCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserCycleCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserDonateCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserDriveElectricCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserEatOrganicCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserFamilySizesCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserFluorescentBulbsCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserFlyLessCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserGoPaperlessCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserGoVeganCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserGoVegetarianCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserGreenRecoveryCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserGrowVegCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserHabitatRestorationCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserHerbsAndPesticidesCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserHomeInsulationCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserLiveCarFreeCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserMinimisePlasticCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserPlantNativeCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserPlantTreesCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserPublicTransportCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserRecyclingBinCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserReduceMeatCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserRenewableEnergyCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserShorterShowersCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserSignPetitionCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserSlowDownCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserSocialMediaCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserStandUpCO2Total")
                        .HasColumnType("float");

                    b.Property<int>("UserTotal")
                        .HasColumnType("int");

                    b.Property<double>("UserTurnOffLightsCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserWildlifeRefugeCO2Total")
                        .HasColumnType("float");

                    b.Property<double>("UserZeroDeforestationCO2Total")
                        .HasColumnType("float");

                    b.Property<int>("WildlifeRefuge")
                        .HasColumnType("int");

                    b.Property<int>("ZeroDeforestation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserEnvironmentalActionCounts");
                });

            modelBuilder.Entity("GatheringForGood.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AreaOfInterest")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("AreasYouCanHelp")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("FeatureUpdates")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("MarketingComms")
                        .HasColumnType("bit");

                    b.Property<bool>("NewBlogPosts")
                        .HasColumnType("bit");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("ProductNews")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SignedUp")
                        .HasColumnType("datetime");

                    b.Property<string>("Skill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TandC")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GatheringForGood.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GatheringForGood.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GatheringForGood.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GatheringForGood.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
