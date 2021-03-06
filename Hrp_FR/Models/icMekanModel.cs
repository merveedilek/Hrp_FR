﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrp_FR.Models
{
    public class icMekanModel
    {
        public icMekanModel()
        {
            Images = new List<Images>();
        }
        public int icMekanId { get; set; }
        public string UrunAdi { get; set; }
        public string En { get; set; }
        public string Boy { get; set; }
        public string Yukseklik { get; set; }
        public string Malzeme { get; set; }
        public string Renk { get; set; }
        public string YuzeyTipi { get; set; }
        public string TemizlikveBakim { get; set; }
        public string AhsapKaplama { get; set; }
        public string KumasDoseme { get; set; }
        public string DeriDoseme { get; set; }
        public List<Images> Images { get; set; }
    }
}