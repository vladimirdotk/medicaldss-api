using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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

        public double tromb { get; set; }
        public double pti { get; set; }
        public double fibr { get; set; }
        public double achtv { get; set; }
        public double sag { get; set; }
        public double fv { get; set; }
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