using Microsoft.EntityFrameworkCore;
using BD.Tms.Domain;

namespace BD.Tms.Respository
{
    public class TmsDbContext:DbContext
    {
        public TmsDbContext( DbContextOptions<TmsDbContext> options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> User_Roles { get; set; }

        /// <summary>
        /// 0、protected 受保护--只有派生类可以访问
        /// 1、重写方法--重写父类的方法--业务逻辑
        /// 2、配置映射关系
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            //modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.UserName).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Phone).HasMaxLength(11);
            modelBuilder.Entity<User>().Property(u => u.Password).HasMaxLength(100);

            modelBuilder.Entity<Role>().ToTable("Role");
            //modelBuilder.Entity<Role>().HasKey(u => u.Id);
            modelBuilder.Entity<Role>().Property(u => u.Name).HasMaxLength(100);
            modelBuilder.Entity<Role>().Property(u => u.Description).HasMaxLength(100);

            modelBuilder.Entity<User_Role>().ToTable("User_Role");
            modelBuilder.Entity<User_Role>().HasKey(u => u.Id);
            modelBuilder.Entity<User_Role>().Property(u => u.UserId).HasMaxLength(100);
            modelBuilder.Entity<User_Role>().Property(u => u.RoleId).HasMaxLength(100);


            base.OnModelCreating(modelBuilder);
        }

    }


   

    //public class B:A
    //{
    //    public B(string s):base(s)
    //    {
            
    //    }
    //}
}
