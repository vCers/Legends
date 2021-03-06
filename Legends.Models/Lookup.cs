﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legends.Models
{
    public class Lookups
    {
        public IEnumerable<Tier> Tiers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Duration> Durations { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}
