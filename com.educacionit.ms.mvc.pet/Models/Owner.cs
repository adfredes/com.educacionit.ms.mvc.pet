﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class Owner : Person
    {
        public List<Pet> Pets { get; set; }
    }
}