﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain
{
   public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public  DateTime ? LastUpdatedDate { get; set; }
    }
}
