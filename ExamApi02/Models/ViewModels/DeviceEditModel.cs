﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamApi02.Models.ViewModels
{
    public class DeviceEditModel
    {
        public int DeviceId { get; set; }
        [Required, StringLength(50)]
        public string DeviceName { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        [Required, Column(TypeName = "money")]

        public decimal Price { get; set; }
        public bool OnSale { get; set; }
        [Required, StringLength(200)]

        public string Picture { get; set; }
        public List<SpecInputModel> Specs { get; set; } = new List<SpecInputModel>();
    }

}