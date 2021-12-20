using _00_SuperCharacterFightArea.Mapping;
using _00_SuperCharacterFightArea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_SuperCharacterFightArea.Data
{
    public class SuperCharacterDbContext : DbContext
    {
        public SuperCharacterDbContext() : base("name=SuperCharacterDbContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperCharacter>()
                .HasKey(p => p.Id)
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<SuperCharacter>()
                .Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<SuperCharacter>()
                .Property(i => i.ImagePath)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<SuperCharacter>()
                .HasMany<Ability>(a => a.Abilities) //bire çok ilişki
                .WithRequired(x => x.SuperCharacter) //ability nin supercharacter
                .HasForeignKey(f => f.MySuperCharacterId) //buraya kadar ilişki kuruldu
                .WillCascadeOnDelete(); //super char sildiğimde yetenekler de silinir. fakat parametre olarak false verirsem silinmez.

            modelBuilder.Configurations.Add(new AbilityMapping());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<SuperCharacter> SuperCharacters { get; set; }
    }
}
