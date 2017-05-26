﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Helper
{
    class DataSource
    {
        List<string> strucneSpreme, pozicije, priznanja, popularnosti;

        public DataSource()
        {
            StrucneSpreme = new List<string>();
            Pozicije = new List<string>();
            Priznanja = new List<string>();
            Popularnosti = new List<string>();
            StrucneSpreme.Add("NSS");
            StrucneSpreme.Add("SSS");
            StrucneSpreme.Add("VSS");
            Pozicije.Add("Predsjednik");
            Pozicije.Add("Clan");
            Priznanja.Add("Najbolji politicar");
            Popularnosti.Add("Nepopularan");
            Popularnosti.Add("Popularan");
        }

        public List<string> Popularnosti
        {
            get
            {
                return popularnosti;
            }

            set
            {
                popularnosti = value;
            }
        }

        public List<string> Pozicije
        {
            get
            {
                return pozicije;
            }

            set
            {
                pozicije = value;
            }
        }

        public List<string> Priznanja
        {
            get
            {
                return priznanja;
            }

            set
            {
                priznanja = value;
            }
        }

        public List<string> StrucneSpreme
        {
            get
            {
                return strucneSpreme;
            }

            set
            {
                strucneSpreme = value;
            }
        }
    }
}