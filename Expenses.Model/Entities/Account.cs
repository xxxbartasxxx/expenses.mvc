﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.Model
{
    [Table("Accounts")]
    public class Account : PrimaryKeyEntity
    {
        public Decimal Balance { get; set; }
    }
}
