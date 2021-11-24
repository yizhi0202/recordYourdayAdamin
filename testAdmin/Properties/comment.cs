using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdmin.Properties
{
    public class commentDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string _id { get; set; }
        /// <summary>
        /// 很不错
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string objectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userID { get; set; }
    }

    public class comment
    {
        /// <summary>
        /// 
        /// </summary>
        public List<commentDataItem> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestId { get; set; }
    }
}
