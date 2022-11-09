using SNLotteryHistory.Models;
using SNLotteryHistory.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SNLotteryHistory.Respositories
{
    public class Respository : IRespository
    {
        string xmlSource = Path.Combine(System.Windows.Forms.Application.StartupPath, "dataSource.xml");

        public Respository()
        {
            DataSet ds;

            //當XML檔案來源不存在時，就建立XML結構的檔案
            if (!File.Exists(xmlSource))
            {
                DataTable LotteryInfoDt = new DataTable("LotteryInfoDt");
                LotteryInfoDt.TableName = "LotteryInfoDt";
                LotteryInfoDt.Columns.Add("Id", typeof(int));
                LotteryInfoDt.Columns.Add("Awards", typeof(string));
                LotteryInfoDt.Columns.Add("Number", typeof(string));
                LotteryInfoDt.Columns.Add("IsReceive", typeof(bool));
                LotteryInfoDt.Columns.Add("insertDateTime", typeof(DateTime));
                LotteryInfoDt.Columns.Add("ReceiveDateTime", typeof(DateTime));

                DataTable LotteryInfoRecordDt = new DataTable("LotteryInfoRecordDt");
                LotteryInfoRecordDt.Columns.Add("Awards", typeof(string));
                LotteryInfoRecordDt.Columns.Add("Number", typeof(string));
                LotteryInfoRecordDt.Columns.Add("ExecuteNote", typeof(string));
                LotteryInfoRecordDt.Columns.Add("ExecuteDateTime", typeof(DateTime));
                
                ds = new DataSet("LotteryDs");
                ds.Tables.Add(LotteryInfoDt);
                ds.Tables.Add(LotteryInfoRecordDt);

                using (StreamWriter sw = new StreamWriter(xmlSource, false, Encoding.UTF8))
                {
                    ds.WriteXmlSchema(sw);
                }
            }
            else//讀取現有xml檔裡面的資料
            {
                using (StreamReader sr = new StreamReader(xmlSource, Encoding.UTF8))
                {
                    ds = new DataSet();
                    ds.ReadXml(sr, XmlReadMode.ReadSchema);
                }
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public LotteryInfo GetLotteryInfo(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LotteryInfo lotteryInfo)
        {
            throw new NotImplementedException();
        }

        public bool Update(LotteryInfo lotteryInfo)
        {
            throw new NotImplementedException();
        }
    }
}
