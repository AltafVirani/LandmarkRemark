using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landmark_Remark.ViewModels
{
    public class LocationMarkerUser
    {
        public int LocationMarkerID { get; set; }
        public string Title { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
        public string Comment { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
