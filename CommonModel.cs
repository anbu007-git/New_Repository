using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceModel.CommonModel
{
    public class CommonModel
    {
        public string Postresponse { get; set; }
    }
    public class GetCommonModel
    {
        public string Getrequestresponse { get; set; }
    }

    public class LogTrack
    {
        public string LoginId { get; set; }
        public string UserName { get; set; }
        public string ModuleName { get; set; }
        public string PageName { get; set; }
        public string Action { get; set; }
        public string Ipaddress { get; set; }
        public string BrowserName { get; set; }
        public string XmlInput { get; set; }

    }
}
