using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdmin.Properties
{
    public class paceNoteDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string _id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string audit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photo { get; set; }
        /// <summary>
        /// 平淡游记
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int voteNum { get; set; }
        /// <summary>
        /// 毫无波澜
        /// </summary>
        public string note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userID { get; set; }
        /// <summary>
        /// https://6865-hello-cloudbase-7gk3odah3c13f4d1-1306308742.tcb.qcloud.la/image/scenicSpotPhoto/IMG_1637234314434.png&&&毛毛妈你好: 万物起源&&&江苏省南京市江宁区化工厂太平小区37栋&&&三十七栋八楼活动室，一个肮脏的天堂，却?钊松裢?&&31.940786&&&118.803011###
        /// </summary>
        public string scenicSpotInfo { get; set; }
    }

    public class paceNote
    {
        /// <summary>
        /// 
        /// </summary>
        public List<paceNoteDataItem> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestId { get; set; }
    }
}
