using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Axkri10_Draw.Models
{
    [Serializable]
    public class SubFormModel
    {
        private SubFormModel person;

        public String FirstName { get; set; }
        public String SurName { get; set; }
        public String Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Birthday { get; set; }
        public int SerialNo { get; set; }

        public SubFormModel() { }

        public SubFormModel(String firstName, String surName, String email, int phoneNumber, int birthday, int serialNo)
        {
            FirstName = firstName;
            SurName = surName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            SerialNo = serialNo;
        }

        public SubFormModel(SubFormModel person)
        {
            this.person = person;
        }

        public override string ToString()
        {

            return String.Format("FirstName: " + FirstName + " SurName: " + SurName + " Email:" + Email +
                " PhoneNumber: " + PhoneNumber + " Birthday: " + Birthday + " SerialNo: " + SerialNo);

        }

    }
}