using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSCollection.AppData;
using VSCollection.Utils;
namespace VSCollection.Repository
{
    internal class UserInfo
    {
        DBCollectionEntities3 db;

        public UserInfo() { 
        
            db = new DBCollectionEntities3();
        }
        public Officer GetUserByUsername(String username)
        {
            using (db = new DBCollectionEntities3())
            {
                return db.Officer.Where(m => m.position == username).FirstOrDefault();
            }
        }
        public Admin GetUserByUsername1(String username)
        {
            using (db = new DBCollectionEntities3())
            {
                return db.Admin.Where(m => m.adminName == username).FirstOrDefault();
            }
        }
        public List<vw_PSITS> vw_PSITs()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.vw_PSITS.ToList();
            }
        }

        public List<YearReport1> vw_YearReport()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.YearReport1.ToList();
            }
        }

        public List<vw_Admin> vw_Admin()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.vw_Admin.ToList();
            }
        }
        public ErrorCode DeleteRoomUsingStoredProf(int? id, ref String szResponse)
        {
            using (db = new DBCollectionEntities3())
            {
                try
                {
                    db.sp_Delete(id);
                    szResponse = "Deleted";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
            public  Student GetStudentID(int id)
        {
            using (db = new DBCollectionEntities3())
            { 
                return db.Student.Where(s => s.id == id).FirstOrDefault();
            }
        }
      
        public ErrorCode UpdateRoomUsingStoredProf(int sId, int sIDN, String FN, String LN, String Course, ref String szResponse)
        {
            using (db = new DBCollectionEntities3())
            {
                try
                {
                    db.sp_Update(sId, sIDN, FN, LN, Course);
                    szResponse = "Updated";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public List<vw_INTRAMURALS> IntramsList()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.vw_INTRAMURALS.ToList();
            }
        }
        public List<vw_ACQUAINTANCE> ACQUAINTANCE()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.vw_ACQUAINTANCE.ToList();
            }
        }
        public List<vw_GO_DAY> DAY()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.vw_GO_DAY.ToList();
            }
        }
        public List<vw_CONGRESS> Congress()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.vw_CONGRESS.ToList();
            }
        }
        public List<vw_SEMINAR> seminar()
        {
            using (db = new DBCollectionEntities3())
            {
                return db.vw_SEMINAR.ToList();
            }
        }
    }
}
