using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdmin.Properties
{
    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string _id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string profilePhoto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nickName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userID { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestId { get; set; }
    }
}
