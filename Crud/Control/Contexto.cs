using Crud.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Control
{
   public class Contexto : DbContext
    {
        private static string StringConexao = "Data Source=" + "127.0.0.1" +
               ";Network Library=DBMSSOCN;Initial Catalog =" + "Crud" + "; User ID =" +
               "Sa" + "; Password=" + "123456" + ";MultipleActiveResultSets=True;";
        public Contexto() : base(GetConnection(), true)
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

        }


        private static DbConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            var connection = factory.CreateConnection();
            connection.ConnectionString = StringConexao;
            return connection;
        }
        public DbSet<Funcionario> funcionario { get; set; }

    }
}





