using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Concrete
{
    public class EtgMonthlyListReportLineBOL : IEtgMonthlyListReportLineBOL
    {
        private IEtgMonthlyListReportLineDAL _reportLineDal;
        public EtgMonthlyListReportLineBOL(IEtgMonthlyListReportLineDAL reportLineDal)
        {
            _reportLineDal = reportLineDal;
        }

        public List<EtgMonthlyListReportLine> GetAll()
        {
            return _reportLineDal.GetList();
        }
    }
}
