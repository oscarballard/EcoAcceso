﻿using EcoAcceso.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Infrastruture.Persistence.Mapping
{
    public class ProtectedAreaMap : IEntityTypeConfiguration<ProtectedArea>
    {
        public void Configure(EntityTypeBuilder<ProtectedArea> builder)
        {
            builder.ToTable("ProtectedArea")
                .HasKey(p => p.Id);
        }
    }
}
