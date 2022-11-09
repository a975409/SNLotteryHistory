using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SNLotteryHistory.Models
{
    /// <summary>
    /// 抽獎資訊
    /// </summary>
    public class LotteryInfo
    {
        public int Id { get; set; }

        [Display(Name ="獎項")]
        public string Awards { get; set; }

        [Display(Name = "中獎號碼")]
        public string Number { get; set; }

        [Display(Name ="領取狀態")]
        public bool IsReceive { get; set; }

        [Display(Name ="抽獎時間")]
        public DateTime insertDateTime { get; set; }
        
        [Display(Name ="領獎時間")]
        public DateTime ReceiveDateTime { get; set; }
    }
}
