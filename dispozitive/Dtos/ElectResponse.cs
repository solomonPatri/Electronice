﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Electronice.dispozitive.Dtos
{
    public class ElectResponse
    {
        public int Id { get; set; }

        public string Dispozitiv { get; set; }


        public string Model { get; set; }

        public int Memory { get; set; }

        public double Price { get; set; }




    }
}
