using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Abstract
{
    public interface INfcCompanyBOL
	{
        List<NfcCompany> GetAll();
    }
}
