using System;
using System.ComponentModel.DataAnnotations;

namespace PlatesMvc.Models
{
    //This is a Public Class named Plates
    public class Plates
    {

        //Declaring various fields with different data types into the system. 

        //This is a primary Key. 
        public int Id { get; set; }
        public string Material { get; set; }

        public int ManufacturedDate { get; set; }

        public string Design { get; set; }
        public string Size { get; set; }
        public string Shape { get; set; }
        public string Function { get; set; }




    }

}

//Session Ends here..