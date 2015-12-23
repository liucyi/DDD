

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "DDD.Domain\App.config"
//     Connection String Name: "MyDbContext"
//     Connection String:      "Data Source=192.168.16.216;Initial Catalog=ddd;Persist Security Info=True;User ID=sa;pwd=S123123a"

// Database Edition: Enterprise Edition
// Database Engine Edition: Enterprise

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace DDD.Domain
{
    // ************************************************************************
    // Unit of work
    public interface IMyDbContext : IDisposable
    {
        IDbSet<TbDepartment> TbDepartments { get; set; } // tbDepartment
        IDbSet<TbMenu> TbMenus { get; set; } // tbMenu
        IDbSet<TbMenuRole> TbMenuRoles { get; set; } // tbMenuRole
        IDbSet<TbRole> TbRoles { get; set; } // tbRole
        IDbSet<TbUser> TbUsers { get; set; } // tbUser
        IDbSet<TbUserMenu> TbUserMenus { get; set; } // tbUserMenu
        IDbSet<TbUserRole> TbUserRoles { get; set; } // tbUserRole

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

    // ************************************************************************
    // Database context
    public class MyDbContext : DbContext, IMyDbContext
    {
        public IDbSet<TbDepartment> TbDepartments { get; set; } // tbDepartment
        public IDbSet<TbMenu> TbMenus { get; set; } // tbMenu
        public IDbSet<TbMenuRole> TbMenuRoles { get; set; } // tbMenuRole
        public IDbSet<TbRole> TbRoles { get; set; } // tbRole
        public IDbSet<TbUser> TbUsers { get; set; } // tbUser
        public IDbSet<TbUserMenu> TbUserMenus { get; set; } // tbUserMenu
        public IDbSet<TbUserRole> TbUserRoles { get; set; } // tbUserRole
        
        static MyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=MyDbContext")
        {
        }

        public MyDbContext(string connectionString) : base(connectionString)
        {
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new TbDepartmentConfiguration());
            modelBuilder.Configurations.Add(new TbMenuConfiguration());
            modelBuilder.Configurations.Add(new TbMenuRoleConfiguration());
            modelBuilder.Configurations.Add(new TbRoleConfiguration());
            modelBuilder.Configurations.Add(new TbUserConfiguration());
            modelBuilder.Configurations.Add(new TbUserMenuConfiguration());
            modelBuilder.Configurations.Add(new TbUserRoleConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new TbDepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new TbMenuConfiguration(schema));
            modelBuilder.Configurations.Add(new TbMenuRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new TbRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new TbUserConfiguration(schema));
            modelBuilder.Configurations.Add(new TbUserMenuConfiguration(schema));
            modelBuilder.Configurations.Add(new TbUserRoleConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class FakeMyDbContext : IMyDbContext
    {
        public IDbSet<TbDepartment> TbDepartments { get; set; }
        public IDbSet<TbMenu> TbMenus { get; set; }
        public IDbSet<TbMenuRole> TbMenuRoles { get; set; }
        public IDbSet<TbRole> TbRoles { get; set; }
        public IDbSet<TbUser> TbUsers { get; set; }
        public IDbSet<TbUserMenu> TbUserMenus { get; set; }
        public IDbSet<TbUserRole> TbUserRoles { get; set; }

        public FakeMyDbContext()
        {
            TbDepartments = new FakeDbSet<TbDepartment>();
            TbMenus = new FakeDbSet<TbMenu>();
            TbMenuRoles = new FakeDbSet<TbMenuRole>();
            TbRoles = new FakeDbSet<TbRole>();
            TbUsers = new FakeDbSet<TbUser>();
            TbUserMenus = new FakeDbSet<TbUserMenu>();
            TbUserRoles = new FakeDbSet<TbUserRole>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake DbSet
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }

    // ************************************************************************
    // POCO classes

    // tbDepartment
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class TbDepartment
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public int? ParentId { get; set; } // ParentId
        public int? Sort { get; set; } // Sort
        public bool? State { get; set; } // State

        // Reverse navigation
        public virtual ICollection<TbUser> TbUsers { get; set; } // tbUser.FK_TBUSER_REFERENCE_TBDEPART
        
        public TbDepartment()
        {
            TbUsers = new List<TbUser>();
        }
    }

    // tbMenu
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class TbMenu
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public int? ParentId { get; set; } // ParentId
        public string Url { get; set; } // Url
        public string Iconic { get; set; } // Iconic
        public int? Sort { get; set; } // Sort
        public string State { get; set; } // State
        public bool? IsLeaf { get; set; } // IsLeaf

        // Reverse navigation
        public virtual ICollection<TbMenuRole> TbMenuRoles { get; set; } // tbMenuRole.FK_TBMENURO_REFERENCE_TBMENU
        public virtual ICollection<TbUserMenu> TbUserMenus { get; set; } // tbUserMenu.FK_TBUSERME_REFERENCE_TBMENU
        
        public TbMenu()
        {
            TbMenuRoles = new List<TbMenuRole>();
            TbUserMenus = new List<TbUserMenu>();
        }
    }

    // tbMenuRole
    public class TbMenuRole
    {
        public int Id { get; set; } // Id (Primary key)
        public int? RoleId { get; set; } // RoleId
        public int? MenuId { get; set; } // MenuId

        // Foreign keys
        public virtual TbMenu TbMenu { get; set; } // FK_TBMENURO_REFERENCE_TBMENU
        public virtual TbRole TbRole { get; set; } // FK_TBMENURO_REFERENCE_TBROLE
    }

    // tbRole
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class TbRole
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public string Type { get; set; } // Type
        public string State { get; set; } // State
        public string Description { get; set; } // Description
        public DateTime? CreateTime { get; set; } // CreateTime
        public DateTime? UpdateTime { get; set; } // UpdateTime

        // Reverse navigation
        public virtual ICollection<TbMenuRole> TbMenuRoles { get; set; } // tbMenuRole.FK_TBMENURO_REFERENCE_TBROLE
        public virtual ICollection<TbUserRole> TbUserRoles { get; set; } // tbUserRole.FK_TBUSERRO_REFERENCE_TBROLE
        
        public TbRole()
        {
            TbMenuRoles = new List<TbMenuRole>();
            TbUserRoles = new List<TbUserRole>();
        }
    }

    // tbUser
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class TbUser
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public string Password { get; set; } // Password
        public string Sex { get; set; } // Sex
        public string Tel { get; set; } // Tel
        public string Address { get; set; } // Address
        public string State { get; set; } // State
        public string Type { get; set; } // Type
        public DateTime? CreateTime { get; set; } // CreateTime
        public DateTime? UpdateTime { get; set; } // UpdateTime
        public int? DepartmentId { get; set; } // DepartmentId

        // Reverse navigation
        public virtual ICollection<TbUserMenu> TbUserMenus { get; set; } // tbUserMenu.FK_TBUSERME_REFERENCE_TBUSER
        public virtual ICollection<TbUserRole> TbUserRoles { get; set; } // tbUserRole.FK_TBUSERRO_REFERENCE_TBUSER

        // Foreign keys
        public virtual TbDepartment TbDepartment { get; set; } // FK_TBUSER_REFERENCE_TBDEPART
        
        public TbUser()
        {
            TbUserMenus = new List<TbUserMenu>();
            TbUserRoles = new List<TbUserRole>();
        }
    }

    // tbUserMenu
    public class TbUserMenu
    {
        public int Id { get; set; } // Id (Primary key)
        public int? UserId { get; set; } // UserId
        public int? MenuId { get; set; } // MenuId

        // Foreign keys
        public virtual TbMenu TbMenu { get; set; } // FK_TBUSERME_REFERENCE_TBMENU
        public virtual TbUser TbUser { get; set; } // FK_TBUSERME_REFERENCE_TBUSER
    }

    // tbUserRole
    public class TbUserRole
    {
        public int Id { get; set; } // Id (Primary key)
        public int? UserId { get; set; } // UserId
        public int? RoleId { get; set; } // RoleId

        // Foreign keys
        public virtual TbRole TbRole { get; set; } // FK_TBUSERRO_REFERENCE_TBROLE
        public virtual TbUser TbUser { get; set; } // FK_TBUSERRO_REFERENCE_TBUSER
    }


    // ************************************************************************
    // POCO Configuration

    // tbDepartment
    internal class TbDepartmentConfiguration : EntityTypeConfiguration<TbDepartment>
    {
        public TbDepartmentConfiguration()
            : this("dbo")
        {
        }
 
        public TbDepartmentConfiguration(string schema)
        {
            ToTable(schema + ".tbDepartment");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName("Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ParentId).HasColumnName("ParentId").IsOptional().HasColumnType("int");
            Property(x => x.Sort).HasColumnName("Sort").IsOptional().HasColumnType("int");
            Property(x => x.State).HasColumnName("State").IsOptional().HasColumnType("bit");
        }
    }

    // tbMenu
    internal class TbMenuConfiguration : EntityTypeConfiguration<TbMenu>
    {
        public TbMenuConfiguration()
            : this("dbo")
        {
        }
 
        public TbMenuConfiguration(string schema)
        {
            ToTable(schema + ".tbMenu");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName("Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ParentId).HasColumnName("ParentId").IsOptional().HasColumnType("int");
            Property(x => x.Url).HasColumnName("Url").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Iconic).HasColumnName("Iconic").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Sort).HasColumnName("Sort").IsOptional().HasColumnType("int");
            Property(x => x.State).HasColumnName("State").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.IsLeaf).HasColumnName("IsLeaf").IsOptional().HasColumnType("bit");
        }
    }

    // tbMenuRole
    internal class TbMenuRoleConfiguration : EntityTypeConfiguration<TbMenuRole>
    {
        public TbMenuRoleConfiguration()
            : this("dbo")
        {
        }
 
        public TbMenuRoleConfiguration(string schema)
        {
            ToTable(schema + ".tbMenuRole");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RoleId).HasColumnName("RoleId").IsOptional().HasColumnType("int");
            Property(x => x.MenuId).HasColumnName("MenuId").IsOptional().HasColumnType("int");

            // Foreign keys
            HasOptional(a => a.TbMenu).WithMany(b => b.TbMenuRoles).HasForeignKey(c => c.MenuId); // FK_TBMENURO_REFERENCE_TBMENU
            HasOptional(a => a.TbRole).WithMany(b => b.TbMenuRoles).HasForeignKey(c => c.RoleId); // FK_TBMENURO_REFERENCE_TBROLE
        }
    }

    // tbRole
    internal class TbRoleConfiguration : EntityTypeConfiguration<TbRole>
    {
        public TbRoleConfiguration()
            : this("dbo")
        {
        }
 
        public TbRoleConfiguration(string schema)
        {
            ToTable(schema + ".tbRole");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName("Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Type).HasColumnName("Type").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.State).HasColumnName("State").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsOptional().HasColumnType("date");
            Property(x => x.UpdateTime).HasColumnName("UpdateTime").IsOptional().HasColumnType("date");
        }
    }

    // tbUser
    internal class TbUserConfiguration : EntityTypeConfiguration<TbUser>
    {
        public TbUserConfiguration()
            : this("dbo")
        {
        }
 
        public TbUserConfiguration(string schema)
        {
            ToTable(schema + ".tbUser");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName("Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Password).HasColumnName("Password").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.Sex).HasColumnName("Sex").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Tel).HasColumnName("Tel").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.State).HasColumnName("State").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Type).HasColumnName("Type").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsOptional().HasColumnType("date");
            Property(x => x.UpdateTime).HasColumnName("UpdateTime").IsOptional().HasColumnType("date");
            Property(x => x.DepartmentId).HasColumnName("DepartmentId").IsOptional().HasColumnType("int");

            // Foreign keys
            HasOptional(a => a.TbDepartment).WithMany(b => b.TbUsers).HasForeignKey(c => c.DepartmentId); // FK_TBUSER_REFERENCE_TBDEPART
        }
    }

    // tbUserMenu
    internal class TbUserMenuConfiguration : EntityTypeConfiguration<TbUserMenu>
    {
        public TbUserMenuConfiguration()
            : this("dbo")
        {
        }
 
        public TbUserMenuConfiguration(string schema)
        {
            ToTable(schema + ".tbUserMenu");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName("UserId").IsOptional().HasColumnType("int");
            Property(x => x.MenuId).HasColumnName("MenuId").IsOptional().HasColumnType("int");

            // Foreign keys
            HasOptional(a => a.TbMenu).WithMany(b => b.TbUserMenus).HasForeignKey(c => c.MenuId); // FK_TBUSERME_REFERENCE_TBMENU
            HasOptional(a => a.TbUser).WithMany(b => b.TbUserMenus).HasForeignKey(c => c.UserId); // FK_TBUSERME_REFERENCE_TBUSER
        }
    }

    // tbUserRole
    internal class TbUserRoleConfiguration : EntityTypeConfiguration<TbUserRole>
    {
        public TbUserRoleConfiguration()
            : this("dbo")
        {
        }
 
        public TbUserRoleConfiguration(string schema)
        {
            ToTable(schema + ".tbUserRole");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName("UserId").IsOptional().HasColumnType("int");
            Property(x => x.RoleId).HasColumnName("RoleId").IsOptional().HasColumnType("int");

            // Foreign keys
            HasOptional(a => a.TbRole).WithMany(b => b.TbUserRoles).HasForeignKey(c => c.RoleId); // FK_TBUSERRO_REFERENCE_TBROLE
            HasOptional(a => a.TbUser).WithMany(b => b.TbUserRoles).HasForeignKey(c => c.UserId); // FK_TBUSERRO_REFERENCE_TBUSER
        }
    }


    // ************************************************************************
    // Stored procedure return models

}

