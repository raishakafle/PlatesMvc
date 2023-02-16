using System;
using System.ComponentModel.DataAnnotations;

namespace PlatesMvc.Models
{
    public class Plates
    {
        public int Id { get; set; }
        public string Material { get; set; }

        public int ManufacturedDate { get; set; }

        public string Design { get; set; }
        public string Size { get; set; }
        public string Shape { get; set; }
        public string Function { get; set; }




    }

}