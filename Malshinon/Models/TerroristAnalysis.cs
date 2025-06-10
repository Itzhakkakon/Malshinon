using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinonApp.Models
{
    public class TerroristAnalysis
    {
        public int Id { get; set; }
        public int TerroristId { get; set; }
        public int ReporterId { get; set; }
        public DateTime ReportTime { get; set; }
    }
}

