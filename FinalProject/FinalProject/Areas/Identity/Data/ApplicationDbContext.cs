using FinalProject.Areas.Identity.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Lecturer> Lecturers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderServices> OrderServices { get; set; }
    public DbSet<ServiceCategories> ServiceCategories { get; set; }
    public DbSet<Services> Services { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Data seeding for initial startup
        List<Category> mainCategories = new List<Category>()
        {
            new Category {Id = 1, Title = "Osnovna škola", Description = "Instrukcije iz predmeta za osnovnu školu.", Image=""},
            new Category {Id = 2, Title = "Srednja škola", Description = "Instrukcije iz predmeta za srednju školu", Image=""},
            new Category {Id = 3, Title = "Državna matura", Description = "Instrukcije iz predmeta državne mature.", Image=""},
            new Category {Id = 4, Title = "Ostalo", Description = "Glazba, programiranje, hobiji...", Image=""}
        };

        builder.Entity<Category>().HasData(mainCategories);

        List<Lecturer> lecturers = new List<Lecturer>()
        {
            new Lecturer {Id = 1, Title = "Mato Matematičar", Bio = "Mato je ovdje kako bi Vam pomogao naučiti matematiku! Ima 35 godina i u slobodno vrijeme programira i svira gitaru.", ContactEmail = "matomatematicar@gmail.com", Image = ""},
            new Lecturer {Id = 2, Title = "Hrvoje Hrvat", Bio = "Hrvoje je apsolvent jednopredmetnog studija Hrvatskog jezika i književnosti na Filozofskom fakultetu u Zagrebu. Slobodno ga kontaktirajte sa bilo kakvim pitanjem o hrvatskom jeziku!", ContactEmail = "hrvojehrvat@gmail.com", Image = ""},
            new Lecturer {Id = 3, Title = "Pero Programer", Bio = "Pero je nastavnik na privatnom učilištu Privatus Maximus u Zagrebu, a u slobodno vrijeme drži instrukcije iz programskih jezika C++, C# i JavaScript.", ContactEmail = "pero1337@gmail.com", Image = ""},
            new Lecturer {Id = 4, Title = "Siniša Sistemac", Bio = "Siniša je oduvijek gajio interes prema tehničkim predmetima, te je voljan svoje znanje podijeliti sa drugima.", ContactEmail = "siniša@gmail.com", Image = ""},
            new Lecturer {Id = 5, Title = "Dino Dizajnerić", Bio = "Dino je oduvijek volio dizajn, te je svoj hobi odlučio pretvoriti u posao. U slobodno vrijeme poučava sve od modeliranja do dizajna korisničkih sučelja.", ContactEmail = "dino23@gmail.com", Image = ""},
            new Lecturer {Id = 6, Title = "Hinko Humanist", Bio = "Hinko je završio Filozofski fakultet  i spreman je pomoći svima koji trebaju pomoć sa humanističkim znanostima! Doktorand moderne povijesti.", ContactEmail = "hinkovski@gmail.com", Image = ""},
            new Lecturer {Id = 7, Title = "Dražen Društvenjak", Bio = "Dražen je asistent na Pravnom fakultetu, a u slobodno vrijeme se bavi sa instrukcijama.", ContactEmail = "draz3993@gmail.com", Image = ""},
            new Lecturer {Id = 8, Title = "Jelena Jezičarka", Bio = "Jelena je pravi poliglot, te je sa svojih 25 godina naučila 5 jezika.", ContactEmail = "jeja111@gmail.com", Image = ""},
            new Lecturer {Id = 9, Title = "Timotej Tehničarovski", Bio = "Timotej je oduvijek bio zainteresiran za robotiku, a sada paralelno sa poslom drži instrukcije na ovoj maloj stranici.", ContactEmail = "timon@gmail.com", Image = ""}
        };
        builder.Entity<Lecturer>().HasData(lecturers);

        List<Services> services = new List<Services>()
        {
            new Services {Id = 1, Title = "Hrvatski jezik", Description = "Instrukcije iz hrvatskog jezika za osnovnu školu.", LecturerId = 2, Price = 10},
            new Services {Id = 2, Title = "Engleski jezik", Description = "Instrukcije iz engleskog jezika za srednju školu.", LecturerId = 8, Price = 13},
            new Services {Id = 3, Title = "Povijest", Description = "Instrukcije iz povijesti za osnovnu školu.", LecturerId = 6, Price = 10},
            new Services {Id = 4, Title = "Matematika", Description = "Instrukcije iz matematike za osnovnu školu.", LecturerId = 1, Price = 17},
            new Services {Id = 5, Title = "Njemački jezik", Description = "Instrukcije iz njemačkog jezika za srednju školu.", LecturerId = 8, Price = 13},
            new Services {Id = 6, Title = "Talijanski jezik", Description = "Instrukcije iz talijanskog jezika za srednju školu.", LecturerId = 8, Price = 10},
            new Services {Id = 7, Title = "Biologija", Description = "Instrukcije iz biologije za državnu maturu.", LecturerId = 7, Price = 9},
            new Services {Id = 8, Title = "Fizika", Description = "Instrukcije iz fizike za državnu maturu.", LecturerId = 9, Price = 16},
            new Services {Id = 9, Title = "Kemija", Description = "Instrukcije iz kemije za državnu maturu.", LecturerId = 7, Price = 20},
            new Services {Id = 10, Title = "Gitara", Description = "Instrukcije iz sviranja gitare za početnike.", LecturerId = 1, Price = 11},
            new Services {Id = 11, Title = "Bubnjevi", Description = "Instrukcije iz sviranja bubnjeva za početnike.", LecturerId = 1, Price = 13.55d},
            new Services {Id = 12, Title = "Back-end development", Description = "Instrukcije iz C# i Jave za početnike.", LecturerId = 3, Price = 12.33d},
            new Services {Id = 13, Title = "UX/UI dizajn", Description = "Instrukcije iz Figme i principa etičkog dizajna.", LecturerId = 5, Price = 20},
            new Services {Id = 14, Title = "Dizajn video-igara", Description = "Instrukcije iz dizajna video-igara i teorijska podloga.", LecturerId = 5, Price = 40},
            new Services {Id = 15, Title = "Elektrotehnika", Description = "Instrukcije iz elektrotehnike za srednju tehničku školu.", LecturerId = 1, Price = 20},
            new Services {Id = 16, Title = "Latinski jezik", Description = "Instrukcije iz latinskog jezika za srednju školu.", LecturerId = 1, Price = 13},
            new Services {Id = 17, Title = "3D dizajn", Description = "Instrukcije iz 3D dizajna u Blenderu", LecturerId = 5, Price = 40},
            new Services {Id = 18, Title = "Informatika", Description = "Instrukcije iz informatike za osnovnu školu.", LecturerId = 4, Price = 18.32},
            new Services {Id = 19, Title = "Tehnička kultura", Description = "Instrukcije iz tehničke kulture za osnovnu školu.", LecturerId = 9, Price = 9},
            new Services {Id = 20, Title = "Sistemska podrška", Description = "Instrukcije iz sistemske podrške za srednju strukovnu školu.", LecturerId = 4, Price = 30}
        };
        builder.Entity<Services>().HasData(services);

        List<ServiceCategories> categories = new List<ServiceCategories>()
        {
            new ServiceCategories {Id = 1, CategoryId = 1, ServiceId = 1},
            new ServiceCategories {Id = 2, CategoryId = 2, ServiceId = 2},
            new ServiceCategories {Id = 3, CategoryId = 1, ServiceId = 3},
            new ServiceCategories {Id = 4, CategoryId = 1, ServiceId = 4},
            new ServiceCategories {Id = 5, CategoryId = 2, ServiceId = 5},
            new ServiceCategories {Id = 6, CategoryId = 2, ServiceId = 6},
            new ServiceCategories {Id = 7, CategoryId = 3, ServiceId = 7},
            new ServiceCategories {Id = 8, CategoryId = 3, ServiceId = 8},
            new ServiceCategories {Id = 9, CategoryId = 3, ServiceId = 9},
            new ServiceCategories {Id = 10, CategoryId = 4, ServiceId = 10},
            new ServiceCategories {Id = 11, CategoryId = 4, ServiceId = 11},
            new ServiceCategories {Id = 12, CategoryId = 4, ServiceId = 12},
            new ServiceCategories {Id = 13, CategoryId = 4, ServiceId = 13},
            new ServiceCategories {Id = 14, CategoryId = 4, ServiceId = 14},
            new ServiceCategories {Id = 15, CategoryId = 2, ServiceId = 15},
            new ServiceCategories {Id = 16, CategoryId = 2, ServiceId = 16},
            new ServiceCategories {Id = 17, CategoryId = 4, ServiceId = 17},
            new ServiceCategories {Id = 18, CategoryId = 1, ServiceId = 18},
            new ServiceCategories {Id = 19, CategoryId = 1, ServiceId = 19},
            new ServiceCategories {Id = 20, CategoryId = 2, ServiceId = 20}
        };
        builder.Entity<ServiceCategories>().HasData(categories);
        #endregion

        #region Administrator role and Application user setup
        string adminRoleId = "8a446ec2-7be7-46fc-9294-21b9355631cf";
        string adminRoleTitle = "Admin";
        string lecturerRoleId = "4a2894e4-5dae-4590-b8e7-6b6c87237a97";
        string lecturerRoleTitle = "Lecturer";

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = adminRoleId, Name = adminRoleTitle, NormalizedName = adminRoleTitle.ToUpper()},
            new IdentityRole { Id = lecturerRoleId, Name = lecturerRoleTitle, NormalizedName = lecturerRoleTitle.ToUpper() }
            );

        string adminId = "e14c9f14-4e73-4703-80a8-c9d1c131a2d5";
        string admin = "siguran@mailfirme.com";
        string adminFirstName = "Siniša";
        string adminLastName = "Administratovski";
        string adminPassword = "T4jn0v1t470z1nk4!";
        string adminAddress = "Nigdjezemska 39";

        var hasher = new PasswordHasher<ApplicationUser>();

        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = adminId,
                UserName = admin,
                NormalizedUserName = admin.ToUpper(),
                Email = admin,
                NormalizedEmail = admin.ToUpper(),
                FirstName = adminFirstName,
                LastName = adminLastName,
                Address = adminAddress,
                PasswordHash = hasher.HashPassword(null, adminPassword)
            });

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                UserId = adminId,
                RoleId = adminRoleId,
            });
        #endregion
    }
}
