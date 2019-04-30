﻿using CozySmart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CozySmart.ViewModels
{
    public class AccommodationFormViewModel
    {
        public Accommodation Accommodation { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Amenity> Amenities { get; set; }
    }
}