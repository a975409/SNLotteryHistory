using SNLotteryHistory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNLotteryHistory.Respositories
{
    public interface IRespository
    {
        bool Insert(LotteryInfo lotteryInfo);
        bool Update(LotteryInfo lotteryInfo);
        bool Delete(int id);
        LotteryInfo GetLotteryInfo(int id);
    }
}
