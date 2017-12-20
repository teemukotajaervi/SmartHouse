using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouse.Models
{
    public class SaunaModel
    {
        public string Koodi { get; set; }
        public string Tyyppi { get; set; }
        public bool Tila { get; set; }
        public decimal Lampotila { get; set; }
        public void Päälle()
        {
            Tila = true;
        }

        public void SaunaOnOff(int tila)
        {
            if (tila == 0m)
            {
                Tila = false;
                Lampotila = 20.01m;
            }
            else
            {
                Tila = true;
            }
        }
    }
}