using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quanlykhachsan
{
    internal class ProcessingAccounts
    {
        private static Dictionary<string, Account> m_DicAccount = new Dictionary<string, Account>();
        private static List<string> m_ListType = new List<string>();
        private static Account m_accCurrently = new Account();
        private static Dictionary<string, Account> m_DicAccountLock = new Dictionary<string, Account>();
        public static Dictionary<string, Account> DicAccountLock
        {
            get { return m_DicAccountLock; }
            set { m_DicAccountLock = value; }
        }
        public static List<string> ListType
        {
            get { return m_ListType; }
            set { m_ListType = value; }
        }
        public static Account Currently
        {
            get { return m_accCurrently; }
            set { m_accCurrently = value;}
        }

        public static Dictionary<string, Account> DicAccount
        {
            get { return m_DicAccount; }
            set { m_DicAccount = value; }
        }
      
        public static bool writeFileAccount()
        {
            FileStream fs = new FileStream("Account.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_DicAccount);
            fs.Close();
            return true;
        }
        public static bool readFileAccount()
        {
            try
            {
                //
                FileStream fs = new FileStream("Account.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_DicAccount=bf.Deserialize(fs) as Dictionary<string, Account>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool writeFileAccountLock()
        {
            FileStream fs = new FileStream("AccountLock.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, DicAccountLock);
            fs.Close();
            return true;
        }
        public static bool readFileAccountLock()
        {
            try
            {
                //
                FileStream fs = new FileStream("AccountLock.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DicAccountLock=bf.Deserialize(fs) as Dictionary<string, Account>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static Account search(string UserName)
        {
            try
            {
                return m_DicAccount[UserName];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool writeFileTypeAccount()
        {
            FileStream fs = new FileStream("ListTypeAccount.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_ListType);
            fs.Close();
            return true;
        }
        public static bool readFileTypeAccount()
        {
            try
            {
                //
                FileStream fs = new FileStream("ListTypeAccount.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_ListType=bf.Deserialize(fs) as List<string>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }


}
