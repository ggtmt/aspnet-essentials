using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using AplicativoWeb.EntityConfigs;
//Trabalho para Amanhã: Instalar Dependências
public class AppDbContext:DbContext{   
      
      public DbSet<Curso> Cursos => Set<Curso>();
      
            //override (sobrescrever)
      //NaoTrair( ) - Contrato
      //CompartilharCarteira()
      //protected
      protected override void OnConfiguring(DbContextOptionsBuilder builder){
          builder.UseSqlServer("Server=LAB-F08-25;Database=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=True;");
      }
          protected override void OnModelCreating(ModelBuilder builder){
           builder.ApplyConfiguration(new CursoEntityConfig());
          }
      


}
     

     

