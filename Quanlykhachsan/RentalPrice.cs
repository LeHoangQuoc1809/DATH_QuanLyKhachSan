using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class RentalPrice//Giá cả cho thuê 
    {
        private string m_nameTypeRoom;
        private double m_firsthour;
        private double m_normalhour;
        private double m_day;
        private double m_overnight;
        public string NameTypeRoom
        {
            get { return m_nameTypeRoom; }
            set { m_nameTypeRoom = value; }
        }
        public double FirstHour
        { get { return m_firsthour; } set { m_firsthour = value; } }
        public double NormalHour
        { get { return m_normalhour; } set { m_normalhour = value; } }
        public double Day
        { get { return m_day; } set { m_day = value; } }
        public double OverNight
        { get { return m_overnight; } set { m_overnight = value; } }
        public RentalPrice()
        {
            m_nameTypeRoom=string.Empty;
            m_firsthour =0;
            m_normalhour =0;
            m_day =0;
            m_overnight =0;
        }
        public RentalPrice(string NameTypeRoom, int FirstHour,int NormalHour,int Day,int Overnight)
        {
            m_nameTypeRoom = NameTypeRoom;
            m_overnight =Overnight;
            m_firsthour = FirstHour;
            m_day = Day;
            m_normalhour=NormalHour;
        }
    }
}
