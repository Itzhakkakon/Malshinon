using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinonApp.Models
{
    public class ReportLog
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int AgentId { get; set; }
        public int TerroristId { get; set; }
        public string ReportText { get; set; } = string.Empty;
        public bool IsAnalyzed { get; set; } = false;
    }
}

