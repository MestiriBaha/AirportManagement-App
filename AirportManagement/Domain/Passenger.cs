using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportManagement.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        [Display(Name = "Start Datetime")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid Datetime")]


        public DateTime birthDate { get; set;  }
        // make the passeportnumber a primary key !
        [Key]
        [StringLength(7)]

        public int passportNumber { get; set;  }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailAddress { get; set; }
        [MaxLength(50)]
        [MinLength(7)]
        [Required(ErrorMessage ="you should respect the length ")]
        public string firstName { get; set; }
        public string lastName { get; set; }
        [Range(0,9)]
        [DataType(DataType.PhoneNumber)]

        public int telNumber { get; set; }
        //many to many relation : 
        public ICollection<Flight>  passengerflights { get; set; }
        //override the passenger method : 
        public override string ToString()
        {
            return "all main informations " + birthDate + " " + passportNumber + " " + emailAddress + " " + firstName  + " " + lastName + " " + telNumber  +" \n" +  passengerflights ;
        }
        //firstName can never be a method parameter , it means a class with that name !!!!!!!! 
        public Boolean CheckProfile(string first , string last )
        {
            return (first==firstName && last==lastName);    
        }

        public Boolean CheckProfile(string first, string last,string mail)
        {
            return (first == firstName && last == lastName && mail==emailAddress);
        }
        public virtual void passengerType()
        {
            Console.WriteLine("I am a Passenger");
        }


    }
}
