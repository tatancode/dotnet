using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public class Topic
    {
        // PK: TopicId is the primary key by convention: TablenameId is the conventino for primary key
        public int TopicId { get; set; }
        public string TopicName { get; set; }

        // Navigation Properties
        
        // this is the one side of the one to many relationship of Topic to Blog
        //                                          there are many Blogs to one Topic
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
