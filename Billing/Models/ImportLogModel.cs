using LNF.Models.Billing;
using System;
using System.Collections.Generic;

namespace Billing.Models
{
    public class ImportLogModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<IRoomDataImportLog> Items { get; set; }
    }
}