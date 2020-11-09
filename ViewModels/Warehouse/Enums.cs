using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.ViewModels.Warehouse
{
    public class Enums
    {
        public enum District
        {
            Blagoevgrad,
            Burgas,
            Gabrovo,
            Haskovo,
            Kardzhali,
            Kyustendil,
            Lovech,
            Montana,
            Pazardzhik,
            Pernik,
            Pleven,
            Plovdiv,
            Razgrad,
            Ruse,
            Shumen,
            Silistra,
            Sliven,
            Smolyan,
            [Display(Name = "Sofia City")]
            SofiaCity,
            [Display(Name = "Sofia Province")]
            SofiaProvince,
            [Display(Name = "Stara Zagora")]
            StaraZagora,
            Targovishte,
            Varna,
            [Display(Name = "Veliko Tarnovo")]
            VelikoTarnovo,
            Vidin,
            Vratsa,
            Yambol
         }
    }
}
