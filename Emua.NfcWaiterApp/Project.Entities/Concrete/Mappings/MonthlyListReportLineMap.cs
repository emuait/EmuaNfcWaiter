using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete.Mappings
{
    public class MonthlyListReportLineMap : EntityTypeConfiguration<EtgMonthlyListReportLine>
    {
        public MonthlyListReportLineMap()
        {
            ToTable(@"ETGMONTHLYLISTREPORTLINES", @"dbo");
            HasKey(x => x.RECID);

        }
    }
}
