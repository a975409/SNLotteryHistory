using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SNLotteryHistory.Models
{
    public class LotteryInfoRecord
    {
        [Display(Name = "獎項")]
        public string Awards { get; set; }

        [Display(Name = "中獎號碼")]
        public string Number { get; set; }

        [Display(Name = "異動項目")]
        public string ExecuteNote { get; set; }

        [Display(Name = "異動時間")]
        public DateTime ExecuteDateTime { get; set; }
    }
}
