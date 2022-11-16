using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AirportManagement.Domain
{
    public  class Plane
    {
        [Range(1, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 1")]

        public int Capacity { get; set; }
        public DateTime manufactureDate { get; set; }
        public int planeId { get; set; } 
        public string planeType { get; set; }

        //one to many relation : 

        public ICollection<Flight> planeflights { get; set; } = new List<Flight>();
        public Plane()
        {

        } 
        //constructor : 
        public Plane(PlaneType plane, int capacity, DateTime date)
        {
            if (plane == PlaneType.Airbus) { this.planeType = "Airbus"; } else { this.planeType = "Boing"; }
            this.Capacity = capacity; 
            this.manufactureDate = date;    

        }

        public override string ToString()
        {
            return "Plane : " + "\n" + Capacity + "\n" + manufactureDate + "  " + planeId + "  " + planeType + " ";
        }



    }
}
