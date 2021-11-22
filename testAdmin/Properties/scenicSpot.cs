using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdmin.Properties
{
    public class scenicSpotDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string _id { get; set; }
        /// <summary>
        /// 测试
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userID { get; set; }
        /// <summary>
        /// 测试
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 测试
        /// </summary>
        public string introduction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string publishTime { get; set; }
        /// <summary>
        /// 测试
        /// </summary>
        public string subtitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string audit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string scenicSpotPhotoUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int voteNum { get; set; }
    }

    public class scenicSpot
    {
        /// <summary>
        /// 
        /// </summary>
        public List<scenicSpotDataItem> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestId { get; set; }
    }
}
