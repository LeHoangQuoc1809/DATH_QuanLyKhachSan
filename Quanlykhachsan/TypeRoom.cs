using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class TypeRoom
    {
     
        private int m_Size;
        private string m_Rank;
        private string m_Name;//key
        public string Name
        {
            get { return m_Size.ToString()+"-"+m_Rank; }
            set { m_Name = value; }
        }
        public int Size
        {
            get { return m_Size; }
            set { m_Size = value; }
        }
        public string Rank
        {
            get { return m_Rank; }
            set { m_Rank = value; }
        }
        public TypeRoom()
        {
            m_Size =0;
            m_Rank =string.Empty;
        }
        public TypeRoom(int Size, string Rank)
        {
            m_Size=Size;
            m_Rank =Rank;
        }
    }
}
