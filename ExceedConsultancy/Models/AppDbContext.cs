using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExceedConsultancy.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasKey(r => r.Id);
            modelBuilder.Entity<UserClaim>().HasKey(r => new { r.Id, r.UserId });
            modelBuilder.Entity<UserClaim>().Property(r => r.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<UserRole>().HasKey(r => new { r.RoleId, r.UserId });
            modelBuilder.Entity<UserLogin>().HasKey(r => r.UserId);
            modelBuilder.Entity<UserToken>().HasKey(r => r.UserId);
            modelBuilder.Entity<RoleClaim>().HasKey(r => new { r.Id, r.RoleId });
            modelBuilder.Entity<RoleClaim>().Property(r => r.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Role>().HasMany<UserRole>(r => r.UserRoles).WithOne(r => r.Role).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.RoleId);

            modelBuilder.Entity<Role>().HasMany<RoleClaim>(r => r.RoleClaims).WithOne(r => r.Role).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.RoleId);

            modelBuilder.Entity<UserRole>().HasOne<Role>(r => r.Role).WithMany(r => r.UserRoles).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.RoleId);

            modelBuilder.Entity<UserRole>().HasOne<ApplicationUser>(r => r.User).WithMany(r => r.UserRoles).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<ApplicationUser>().HasMany<UserRole>(r => r.UserRoles).WithOne(r => r.User).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<ApplicationUser>().HasMany<UserToken>(r => r.UserTokens).WithOne(r => r.User).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<ApplicationUser>().HasMany<UserLogin>(r => r.UserLogins).WithOne(r => r.User).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<ApplicationUser>().HasMany<UserClaim>(r => r.UserClaims).WithOne(r => r.User).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<UserToken>().HasOne<ApplicationUser>(r => r.User).WithMany(r => r.UserTokens).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<UserLogin>().HasOne<ApplicationUser>(r => r.User).WithMany(r => r.UserLogins).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<UserClaim>().HasOne<ApplicationUser>(r => r.User).WithMany(r => r.UserClaims).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<UserRole>().HasOne<ApplicationUser>(r => r.User).WithMany(r => r.UserRoles).HasPrincipalKey(r => r.Id).HasForeignKey(r => r.UserId);

            modelBuilder.Entity<ApplicationUser>().HasMany(r => r.UserClaims);
            modelBuilder.Entity<ApplicationUser>().HasMany(r => r.UserLogins);
            modelBuilder.Entity<ApplicationUser>().HasMany(r => r.UserTokens);
            modelBuilder.Entity<ApplicationUser>().HasMany(r => r.UserRoles);


            UpperInvariantLookupNormalizer upperInvariantLookupNormalizer = new UpperInvariantLookupNormalizer();
            var role = new Role("Admin") { NormalizedName = upperInvariantLookupNormalizer.NormalizeName("Admin") };
            modelBuilder.Entity<Role>().HasData(role);
            modelBuilder.Entity<RoleClaim>().HasData(new RoleClaim() { Id = 1, RoleId = role.Id, ClaimType = "CanEdit", ClaimValue = "CanEdit" });
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<RoleClaim> RoleClaims { get; set; }


        public DbSet<HomeSliderViewModel> Sliders { get; set; }
        public DbSet<IndustriesViewModel> Industries { get; set; }
        public DbSet<CapabilitiesViewModel> Capabilities { get; set; }

        public DbSet<AboutUsViewModel> AboutUs { get; set; }

        public DbSet<WhyUsViewModel> WhyUs { get; set; }

        public DbSet<WhyUsAccordionViewModel> WhyUsAccordion { get; set; }

        public DbSet<AboutCompanyModel> AboutCompany { get; set; }

        public DbSet<WhyUsHomeModel> WhyUsHome { get; set; }


        public DbSet<HowWork> HowWork { get; set; }
        public DbSet<Commitment> Commitment { get; set; }
        public DbSet<Aspiration> Aspiration { get; set; }
        public DbSet<Purpose> Purpose { get; set; }



        public DbSet<AccordionHowWork> AccordionTwo{ get; set; }
        public DbSet<AccordionCommitment> AccordionThree { get; set; }
        public DbSet<AccordionAspiration> AccordionFour { get; set; }
        public DbSet<AccordionPurpose> AccordionFive { get; set; }





        public DbSet<Leadership> Leadership { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<AddressInfo> AddressInfo { get; set; }
        public DbSet<Footer> Footer { get; set; }


    }
}
