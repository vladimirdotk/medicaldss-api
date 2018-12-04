using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace medicaldss_api.Models.Leptospirosis
 {
     public class LaboratoryData
     {
        public const int trombCoeff = 300;
        public const int ptiCoeff = 110;
        public const int fibrCoeff = 3;
        public const int achtvCoeff = 35;
        public const double sagCoeff = 18.1;
        public const int fvCoeff = 100;
        public const double rkfmCoeff = 3.4;

        [JsonRequired]
        public double tromb { get; set; }
        [JsonRequired]
        public double pti { get; set; }
        [JsonRequired]
        public double fibr { get; set; }
        [JsonRequired]
        public double achtv { get; set; }
        [JsonRequired]
        public double sag { get; set; }
        [JsonRequired]
        public double fv { get; set; }
        [JsonRequired]
        public double rkfm { get; set; }

        public double [] getMarks()
        {
            return new double[] {
                tromb / trombCoeff,
                pti / ptiCoeff,
                fibr / fibrCoeff,
                achtv / achtvCoeff,
                sag / sagCoeff,
                fv / fvCoeff,
                rkfm / rkfmCoeff
            };
        }
     }
 }