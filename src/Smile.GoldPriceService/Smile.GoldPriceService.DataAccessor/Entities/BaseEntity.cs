﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile.GoldPriceService.DataAccessor.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime UpdatedDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid CreatorId { get; set; }

        public Guid UpdaterId { get; set; }
    }
}
