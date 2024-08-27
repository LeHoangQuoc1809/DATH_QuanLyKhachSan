using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]

    public class Account 
    {
        private string m_UserName;
        private string m_PassWord;
        private string m_Type;
        public string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }
        public string PassWord
        {
            get { return m_PassWord; }
            set { m_PassWord = value; }
        }
        public string TypeAccount
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        public Account()
        {
            m_UserName =string.Empty;
            m_PassWord =string.Empty;
            m_Type = string.Empty;
        }
        public Account(string UserName, string PassWord, string Type)
        {
            m_UserName = UserName;
            m_PassWord = PassWord;
            m_Type = Type;
        }
    }
}
