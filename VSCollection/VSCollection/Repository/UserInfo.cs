using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSCollection.AppData;
namespace VSCollection.Repository
{
    internal class UserInfo
    {
        DBCollectionEntities db;

        public UserInfo() { 
        
            db = new DBCollectionEntities();
        }
        public List<vw_PSITS> vw_PSITs()
        {
            using (db = new DBCollectionEntities())
            {
                return db.vw_PSITS.ToList();
            }
        }

        public List<YearReport1> vw_YearReport()
        {
            using (db = new DBCollectionEntities())
            {
                return db.YearReport1.ToList();
            }
        }

        public List<vw_Admin> vw_Admin()
        {
            using (db = new DBCollectionEntities())
            {
                return db.vw_Admin.ToList();
            }
        }
    }
}
