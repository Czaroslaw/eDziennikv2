using eDziennikv2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eDziennikv2.Data;

namespace eDziennikv2.Data
{
    public class ExampleUser
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Groups> Groups { get; set; }
        public DbSet<UserGroups> UserGroups { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            SeedUsers(builder);
            SeedGroups(builder);
            SeedUserGroups(builder);
            SeedUserRoles(builder);
            SeedSubjects(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
    }


        private void SeedUsers(ModelBuilder builder)
        {
            ApplicationUser adminUser = new ApplicationUser()
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                FirstName = "Admin",
                LastName = "Administracyjny",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                PhoneNumber = null,
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumberConfirmed = false,
                LockoutEnd = null,
                LockoutEnabled = false,
                AccessFailedCount = 0,
            };

            builder.Entity<ApplicationUser>().HasData(adminUser);

            foreach (ExampleUser exampleU in exampleUsers)
            {
                var username = $"{exampleU.FirstName.ToLower()}.{exampleU.LastName.ToLower()}";
                var email = $"{username}@testowy.mail";
                ApplicationUser user = new ApplicationUser()
                {
                    Id = exampleU.Id,
                    FirstName = exampleU.FirstName,
                    LastName = exampleU.LastName,
                    UserName = username,
                    NormalizedUserName = username.ToUpper(),
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                    SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                    ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                    PhoneNumber = null,
                    TwoFactorEnabled = false,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                };

                builder.Entity<ApplicationUser>().HasData(user);
            }
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Administrator", ConcurrencyStamp = "1", NormalizedName = "Administrator" },
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895712", Name = "Nauczyciel", ConcurrencyStamp = "2", NormalizedName = "Teacher" },
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895713", Name = "Uczeń", ConcurrencyStamp = "2", NormalizedName = "Student" },
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895714", Name = "Rodzic", ConcurrencyStamp = "2", NormalizedName = "Parent" }
                );
        }


        public void SeedGroups(ModelBuilder builder)
        {
            builder.Entity<Groups>().HasData(
                new Groups() { Id = "50da648c-000c-4ebf-88e1-ae1688dfc57f", Name = "Klasa 1A" },
                new Groups() { Id = "50da648c-000c-4ebf-88e1-ae1688dfc57g", Name = "Klasa 2B" },
                new Groups() { Id = "50da648c-000c-4ebf-88e1-ae1688dfc57h", Name = "Klasa 3C" }
            );
        }

        public void SeedUserGroups(ModelBuilder builder)
        {
            builder.Entity<UserGroups>().HasData(
                new UserGroups() { UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11", GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f", Id = Guid.NewGuid().ToString()},
                new UserGroups() { UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15", GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f", Id = Guid.NewGuid().ToString() },
                new UserGroups() { UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10", GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f", Id = Guid.NewGuid().ToString() },
                new UserGroups() { UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17", GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f", Id = Guid.NewGuid().ToString() },
                new UserGroups() { UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18", GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f", Id = Guid.NewGuid().ToString() },
                new UserGroups() { UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19", GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f", Id = Guid.NewGuid().ToString() }
            );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895712", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895713", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895712", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895714", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895714", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895713", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895714", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895713", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895713", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895713", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895712", UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20" }
                );
        }
        private void SeedSubjects(ModelBuilder builder)
        {
            builder.Entity<Subjects>().HasData(
                new Subjects() { Name = "Matematyka"},
                new Subjects() { Name = "Biologia"},
                new Subjects() { Name = "Geografia"},
                new Subjects() { Name = "Informatyka"},
                new Subjects() { Name = "Historia"},
                new Subjects() { Name = "Angielski"},
                new Subjects() { Name = "Polski"}
                );
        }

        private List<ExampleUser> exampleUsers = new List<ExampleUser> {
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10",
                FirstName = "Celina",
                LastName = "Piotrowska",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11",
                FirstName = "Sulisław",
                LastName = "Dudek",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12",
                FirstName = "Maksym",
                LastName = "Dudek",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13",
                FirstName = "Mirosława",
                LastName = "Rutkowska",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14",
                FirstName = "Henryka",
                LastName = "Jasińska",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15",
                FirstName = "Kazia",
                LastName = "Sawicka",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16",
                FirstName = "Jadwiga",
                LastName = "Piotrowska",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17",
                FirstName = "Wielisław",
                LastName = "Czerwinski",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18",
                FirstName = "Antoni",
                LastName = "Kalinowski",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19",
                FirstName = "Dawid",
                LastName = "Kucharski",
            },
            new ExampleUser
            {
                Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20",
                FirstName = "Adrianna",
                LastName = "Zawadzka",
            },

        };

        public DbSet<eDziennikv2.Data.ExampleUser>? ExampleUser { get; set; }

        public DbSet<eDziennikv2.Models.Grades>? Grades { get; set; }
    }
}