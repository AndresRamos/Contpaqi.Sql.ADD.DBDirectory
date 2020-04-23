using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class AddDbDirectoryDbContext : DbContext
    {
        protected AddDbDirectoryDbContext()
        {
        }

        protected AddDbDirectoryDbContext(DbCompiledModel model) : base(model)
        {
        }

        public AddDbDirectoryDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public AddDbDirectoryDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public AddDbDirectoryDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public AddDbDirectoryDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public AddDbDirectoryDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<Cat_Process> Cat_Process { get; set; }
        public virtual DbSet<DatabaseDirectory> DatabaseDirectory { get; set; }
        public virtual DbSet<Certificates> Certificates { get; set; }
        public virtual DbSet<EFOS> EFOS { get; set; }
        public virtual DbSet<EFOS_Version> EFOS_Version { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }
        public virtual DbSet<ProcessControl> ProcessControl { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Constraints> Schema_T_DB_Inventory_Constraints { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Constraints_Temp> Schema_T_DB_Inventory_Constraints_Temp { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Functions> Schema_T_DB_Inventory_Functions { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Functions_Temp> Schema_T_DB_Inventory_Functions_Temp { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_SP> Schema_T_DB_Inventory_SP { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_SP_Temp> Schema_T_DB_Inventory_SP_Temp { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Table_Detail> Schema_T_DB_Inventory_Table_Detail { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Table_Detail_Temp> Schema_T_DB_Inventory_Table_Detail_Temp { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Tables> Schema_T_DB_Inventory_Tables { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Tables_Temp> Schema_T_DB_Inventory_Tables_Temp { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Views> Schema_T_DB_Inventory_Views { get; set; }
        public virtual DbSet<Schema_T_DB_Inventory_Views_Temp> Schema_T_DB_Inventory_Views_Temp { get; set; }
        public virtual DbSet<Schema_T_DB_Templates> Schema_T_DB_Templates { get; set; }
        public virtual DbSet<Schema_T_DB_Types> Schema_T_DB_Types { get; set; }
        public virtual DbSet<Schema_T_DB_Versions> Schema_T_DB_Versions { get; set; }
        public virtual DbSet<Schema_T_Log> Schema_T_Log { get; set; }
        public virtual DbSet<TempDestinationDBDetail> TempDestinationDBDetail { get; set; }
        public virtual DbSet<TempSourceDBDetail> TempSourceDBDetail { get; set; }
        public virtual DbSet<Tunning_ErroLog> Tunning_ErroLog { get; set; }
        public virtual DbSet<Tunning_Process> Tunning_Process { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat_Process>()
                .Property(e => e.DescripcionProcces)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.NombreEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.DB_DocumentsMetadata)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.Ver_DocumentsMetadata)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.DB_DocumentsContent)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.Ver_DocumentsContent)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.DB_OthersMetadata)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.Ver_OthersMetadata)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.DB_OthersContent)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.Ver_OthersContent)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.Accesibility)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .Property(e => e.CompanyPath)
                .IsUnicode(false);

            modelBuilder.Entity<DatabaseDirectory>()
                .HasMany(e => e.Owners)
                .WithRequired(e => e.DatabaseDirectory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Certificates>()
                .Property(e => e.LlavePublica)
                .IsUnicode(false);

            modelBuilder.Entity<Certificates>()
                .Property(e => e.NumeroSerie)
                .IsUnicode(false);

            modelBuilder.Entity<Certificates>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<Certificates>()
                .Property(e => e.IssuerName)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.Situacion)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.NoPublica)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.NumGlobPres)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.NumGlobContDesv)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.PubDofDesvir)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS>()
                .Property(e => e.NumGlobDef)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS_Version>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<EFOS_Version>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .Property(e => e.ApplicationType)
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .Property(e => e.MemberType)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessControl>()
                .Property(e => e.ProcessDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessControl>()
                .Property(e => e.LogName)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessControl>()
                .Property(e => e.StatusProcess)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessControl>()
                .Property(e => e.JSONName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Constraints>()
                .Property(e => e.ConstraintName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Constraints>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Constraints_Temp>()
                .Property(e => e.ConstraintName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Constraints_Temp>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Functions>()
                .Property(e => e.FunctionName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Functions>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Functions_Temp>()
                .Property(e => e.FunctionName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Functions_Temp>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_SP>()
                .Property(e => e.SPName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_SP>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_SP_Temp>()
                .Property(e => e.SPName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_SP_Temp>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail>()
                .Property(e => e.Xtype)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail_Temp>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail_Temp>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail_Temp>()
                .Property(e => e.Xtype)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Tables>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Tables>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Tables_Temp>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Tables_Temp>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Views>()
                .Property(e => e.ViewName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Inventory_Views_Temp>()
                .Property(e => e.ViewName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Templates>()
                .Property(e => e.DataBaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Templates>()
                .Property(e => e.CurrentVersion)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Types>()
                .Property(e => e.Xtype)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Types>()
                .Property(e => e.IdSpec)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Versions>()
                .Property(e => e.DataBaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Versions>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_DB_Versions>()
                .Property(e => e.ErrorDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_Log>()
                .Property(e => e.DataBaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_Log>()
                .Property(e => e.ComponentName)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_Log>()
                .Property(e => e.IdObject)
                .IsUnicode(false);

            modelBuilder.Entity<Schema_T_Log>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<TempDestinationDBDetail>()
                .Property(e => e.TblName)
                .IsUnicode(false);

            modelBuilder.Entity<TempDestinationDBDetail>()
                .Property(e => e.ColName)
                .IsUnicode(false);

            modelBuilder.Entity<TempDestinationDBDetail>()
                .Property(e => e.ColType)
                .IsUnicode(false);

            modelBuilder.Entity<TempSourceDBDetail>()
                .Property(e => e.TblName)
                .IsUnicode(false);

            modelBuilder.Entity<TempSourceDBDetail>()
                .Property(e => e.ColName)
                .IsUnicode(false);

            modelBuilder.Entity<TempSourceDBDetail>()
                .Property(e => e.ColType)
                .IsUnicode(false);

            modelBuilder.Entity<Tunning_ErroLog>()
                .Property(e => e.DescriptionError)
                .IsUnicode(false);
        }
    }
}