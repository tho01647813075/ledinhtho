using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDinhTho_02
{
    public class EmloyeeBEL
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public AreaBEL area { get; set; }
        public string AreaName { get; set; }
        public string IdEmployee { get; set; }
    }
    public class AreaBEL
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdEmployee { get; set; }
        public List<EmloyeeBEL> Emloyees { get; set; }
    }
}
