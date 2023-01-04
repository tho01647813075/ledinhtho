using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDinhTho_02
{
    public class EmloyeeBAL
    {
      
         EmloyeeDAL dal = new EmloyeeDAL();
        public List<EmloyeeBEL> ReadEmloyee()
        {
            List<EmloyeeBEL> lstEml = dal.ReadEmloyee();
            return lstEml;
        }
        public void NewEmloyee(EmloyeeBEL eml)
        {
            dal.NewEmloyee(eml);

        }
        public void DeleteEmloyee(EmloyeeBEL eml)
        {
            dal.DeleteEmloyee(eml);

        }
        public void EditEmloyee(EmloyeeBEL eml)
        {
            dal.EditEmloyee(eml);
        }
    }
}
