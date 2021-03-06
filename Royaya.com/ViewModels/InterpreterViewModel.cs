﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Royaya.com.ViewModels
{
    public class InterpreterViewModel
    {
        public string id { get; set; }
        public string Email { get; set; }

        public int numberOfDreamsByDay { get; set; }

        public string pictureId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public String Status { get; set; }

        public String JobDescription { get; set; }


        public String sex { get; set; }

        public int Age { get; set; }

        public String country { get; set; }
        public string MartialStatus { get; set; }

        public double Rating { get; set; }

        public int numberOfActiveDreams { get; set; }

        public int numberOfDoneDreams { get; set; }

        public int numberOfAllDreams { get; set; }

        public double speed { get; set; }

        public string personalDescription { get; set; }

        public string fireBaseId { get; set; }

        public bool HasRegistered { get; set; }

        

    }
}