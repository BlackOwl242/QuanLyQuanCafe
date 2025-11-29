using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class Client
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private int bonusPoint;

        public int BonusPoint
        {
            get { return bonusPoint; }
            set { bonusPoint = value; }
        }

        private DateTime createdDay;

        public DateTime CreatedDay
        {
            get { return createdDay; }
            set { createdDay = value; }
        }
        public Client(int id, string name, string email, string phoneNumber, int bonusPoint, DateTime createdDay)
        {
            this.bonusPoint = bonusPoint;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.name = name;
            this.iD = id;
            this.name = name;
            this.createdDay = createdDay;
        }

        public Client(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["ClientName"].ToString();
            this.email = row["ClientEmail"].ToString();
            this.phoneNumber = row["ClientNumber"].ToString();
            this.bonusPoint = (int)row["BonusPoint"];
            this.createdDay = (DateTime)row["CreatedDay"];
        }
    }
}
