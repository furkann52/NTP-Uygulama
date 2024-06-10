﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EvlerLib
{
    public class RentalHomes : Homes
    {
        private double kira;
        private double depozito;

        public double Kira { get => kira; set => kira = value; }
        public double Depozito { get => depozito; set => depozito = value; }

        public override string EvBilgileriGetir()
        {
           StreamReader sr = File.OpenText("C:\\Users\\pamuk\\OneDrive\\Masaüstü\\EmlakciUygulamasi\\KiralikEvler.txt");
            return sr.ReadToEnd();

        }

        public void EvKayit(List<string> list)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\pamuk\\OneDrive\\Masaüstü\\EmlakciUygulamasi\\KiralikEvler.txt",true))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                    sw.WriteLine("----------------------------------");
                }
            }

        }

        public virtual string EvBilgileri()
        {
            return $"{base.EvBilgileri()} \nKira : {kira}\nDepozito : {depozito}";
        }

    }
}

