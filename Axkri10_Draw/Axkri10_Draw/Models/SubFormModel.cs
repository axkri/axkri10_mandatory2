using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Axkri10_Draw.Models
{
   
    [Serializable]
    public class SubFormModel
    {
        [Required(ErrorMessage = " serial required")]
        public int SerialNo { get; set; }
        [Required(ErrorMessage = " firstname required")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = " surname required")]
        public String SurName { get; set; }
        [Required(ErrorMessage = " email required")]
        public String Email { get; set; }
        [Required(ErrorMessage = " phonenumber required")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = " birthdate required")]
        public int Birthday { get; set; }

        public override string ToString()
        {
            return String.Format("FirstName: " + FirstName + " SurName: " + SurName + " Email:" + Email +
                " PhoneNumber: " + PhoneNumber + " Birthday: " + Birthday + " SerialNo: " + SerialNo);

        }
    }
}