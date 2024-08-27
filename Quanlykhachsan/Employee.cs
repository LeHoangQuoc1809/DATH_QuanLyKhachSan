using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class Employee
    {
        private string m_id;
        private string m_name;
        private DateTime m_birthday;
        private string m_username;
        private string m_typeEmployee;
        private bool m_sex;
        private string m_address;
        public string ID
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public DateTime BirthDay
        {
            get { return m_birthday; }
            set { m_birthday = value; }
        }
        public string UserName
        {
            get { return m_username; }
            set { m_username = value; }
        }
        public bool Sex
        {
            get { return m_sex; }
            set { m_sex = value; }
        }
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }
        public string TypeEmployee
        {
            get { return m_typeEmployee; }
            set { m_typeEmployee = value; }
        }
        public Employee()
        {
            m_username =string.Empty;
            m_typeEmployee = string.Empty;
            m_id =string.Empty;
            m_name =string.Empty;
            m_address=string.Empty;
            m_birthday=DateTime.Now;
            m_sex = false;//Nu
        }
        public Employee(string un, string name, string id, string address, DateTime bd, bool sex)
        {
            m_username =un;
            m_name =name;
            m_sex=sex;
            m_birthday =bd;
            m_address =address;
            m_id=id;
        }
        ~Employee()
        {

        }
    }
}
