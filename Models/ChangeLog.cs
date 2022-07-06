using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public enum ChangeType 
    {
        Created,
        Reported,
        accepted,
        Rejected,
        Updated,
        Deleted,
        Viewed,
    }
    public class ChangeLog 
    {
        // PK: ChangeLogId is the key name by convention
        public int ChangeLogId { get; set; }

        // FK: BlogId is the Foreign Key by convention
        //      the relationship is one blog to many changelogs
        public int BlogId { get; set; }

        // FK: Connected to User Identity (part of Identity Framework), not an actual foreign key in database.
        public int UserId { get; set; }

        [EnumDataType(typeof(ChangeType))]
        public ChangeType ChangeLogType { get; set; }

        public string Description { get; set; }
        public string Comment { get; set; }

        //[DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }


        // Navigation Properties
        public Blog Blog { get; set;  } // a changelog only has one blog associated with it.
                                        // a blog has many changelogs
    }
}
