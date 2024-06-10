﻿using System;
using System.IO;

namespace EvlerLib
{
    public abstract class Homes
    {
        private int katno;
        private int odasayisi;
        private double alan;
        private string semt;
        protected StreamReader fp;

        public int Katno { get => katno; set => katno = value; }
        public int Odasayisi { get => odasayisi; set => odasayisi = value; }
        public double Alan { get => alan; set => alan = value; }
        public string Semt { get => semt; set => semt = value; }

        public virtual string EvBilgileriGetir()
        {
            return fp.ReadToEnd();
        }

        public virtual string EvBilgileri()
        {
            return $"Semt : {semt}\nOda Sayısı : {odasayisi}\nAlan : {alan}\nKat No : {katno} ";
        }



    }
}
