using _00_SuperCharacterFightArea.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_SuperCharacterFightArea.Mapping
{
    public class AbilityMapping : EntityTypeConfiguration<Ability>
    {
        public AbilityMapping()
        {
            HasKey(k => k.Id)
                .Property(k => k.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(k => k.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(k => k.AmountOfAbility)
                .HasPrecision(5, 2);


        }
    }
}
