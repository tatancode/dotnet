using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public enum BlogStatus
    {
        Created,
        Reported,
        Accepted,
        Rejected,
    }
    public class Blog
    {
        // PK: BlogId
        public int BlogId { get; set; }
        
        // FK: Connected to Topics Table
        public int TopicId { get; set; }

        // FK: Connected to User Identity (part of Identity Framework), not an actual foreign key in database.
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [EnumDataType(typeof(BlogStatus))]
        public BlogStatus Status { get; set; }

        // Create navigation properties
        public Topic Topic { get; set;  } // the one topic this class is associated with
        public IEnumerable<ChangeLog> ChangeLogs { get; set; } // the many changelogs associatted with this blog
    }
}
