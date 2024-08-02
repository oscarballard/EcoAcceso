﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Domain.Entities
{
    public class ProtectedArea
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public int Ability { get; set; }
    }
}
