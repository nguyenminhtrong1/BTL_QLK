﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_QLK.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; }

    }
}