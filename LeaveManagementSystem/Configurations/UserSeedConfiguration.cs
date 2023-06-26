using LeaveManagementSystem.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Configurations
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "0277cf85-7f7e-4d55-8808-dbc456156581",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    FirstName = "admin",
                    LastName = "test",
                    PasswordHash = hasher.HashPassword(null, "K1g@mboni"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    FirstName = "user",
                    LastName = "test",
                    PasswordHash = hasher.HashPassword(null, "K1g@mboni"),
                    EmailConfirmed = true
                }
            );
        }
    }
}