using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Snai3i_DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Configration
{
    public class WorkerEntityTypeConfiguration: IEntityTypeConfiguration<Worker>
    {

        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                   .IsRequired()
                   .HasMaxLength(14)
                   ;
            builder.Property(a => a.phone)
                  .HasMaxLength(11)
                   ;
            builder.Property(a => a.email)
                ;
            builder.Property(a => a.Isdeleted)
                .HasDefaultValue(false)
                ;

            builder.HasMany(a => a.users)
                   .WithMany(a => a.workers);

            //isdeleted filter 
            builder.HasQueryFilter(a => a.Isdeleted == false);

        }


    }
}
