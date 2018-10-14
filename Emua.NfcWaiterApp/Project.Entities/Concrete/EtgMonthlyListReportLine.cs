using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
    public class EtgMonthlyListReportLine : IEntity
    {
        public int MONTLYLISTREPORTINGGROUP { get; set; }
        public decimal LINENUM { get; set; }
        public string PUBLISHERID { get; set; }
        public string NAME { get; set; }
        public int PUBLISHCONTENT { get; set; }
        public int PUBLISHTIME { get; set; }
        public int PAGEQTY { get; set; }
        public decimal AREAPUBLISHDECLARATED { get; set; }
        public decimal PRESSTOTALQTY { get; set; }
        public decimal SALESAVGDAILYQTY { get; set; }
        public decimal PUBLISHYEAR { get; set; }
        public string PUBLISHERPERIOD { get; set; }
        public string BRANCHID { get; set; }
        public string ADVERTQUOTAGROUPID { get; set; }
        public string STATEID { get; set; }
        public string COUNTYID { get; set; }
        public int INOUT { get; set; }
        public long MONTLYLISTTABLEREFRECID { get; set; }
        public string COUNTYNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime MODIFIEDDATETIME { get; set; }
        public string MODIFIEDBY { get; set; }
        public DateTime CREATEDDATETIME { get; set; }
        public string CREATEDBY { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long PARTITION { get; set; }
        public long RECID { get; set; }
        public int MANUALLYCREATED { get; set; }
    }
}
