using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double değişkenler
            //double number;

            //number = 3.75;

            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.75;
            //orangePrice = 27.99;
            //strawberryPrice = 45;
            //patatoPrice = 27.25;
            //tomatoPrice = 13.60;

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //Console.WriteLine("---- Elma birim fiyatı :" + applePrice + " TL");
            //Console.WriteLine("---- Portakal birim fiyatı :" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek birim fiyatı :" + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates birim fiyatı :" + patatoPrice + " TL");
            //Console.WriteLine("---- Domates birim fiyatı :" + tomatoPrice + " TL");
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            //double totalPrice;


            //appleGram = 1.234;
            //orangeGram = 2.420;
            //strawberryGram = 0.689;
            //patatoGram = 3.490;
            //tomatoGram = 2.103;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, patatoTotalPrice, tomatoTotalPrice;

            //appleTotalPrice = appleGram * applePrice;
            //orangeTotalPrice = orangeGram *orangePrice;
            //strawberryTotalPrice = strawberryGram * strawberryPrice;
            //patatoTotalPrice = patatoGram * patatoPrice;
            //tomatoTotalPrice = tomatoGram * tomatoPrice;

            //totalPrice = appleTotalPrice + orangeTotalPrice+ strawberryTotalPrice+ patatoTotalPrice+ tomatoTotalPrice;

            //Console.WriteLine("****** Alışveriş Fişi ******");
            //Console.WriteLine();

            //Console.WriteLine("Elmanın toplam fiyatı :"+appleTotalPrice+" TL");
            //Console.WriteLine("Portakalın toplam fiyatı :"+orangeTotalPrice+" TL");
            //Console.WriteLine("Çileğin toplam fiyatı :"+strawberryTotalPrice+" TL");
            //Console.WriteLine("Patatesin toplam fiyatı :"+patatoTotalPrice+" TL");
            //Console.WriteLine("Domatesin toplam fiyatı :"+tomatoTotalPrice+" TL");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("                              Toplam: "+totalPrice+" TL");
            #endregion

            #region Char değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden veri girişleri String değişkenler

            //Console.WriteLine("****** CSharp Hava Yollları Yolcu Bilgisi ******");
            //Console.WriteLine();

            //string passangerName,
            //    passangerSurname,
            //    passangerDistrict,
            //    passangerCity,
            //    passangerAge,
            //    passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyismi: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("Yolcu ilçe bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Yolcu şehir bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Adı: " + passangerName);
            //Console.WriteLine("Soyadı: " + passangerSurname);
            //Console.WriteLine("İlçe: " + passangerDistrict);
            //Console.WriteLine("Şehir: " + passangerCity);
            //Console.WriteLine("Yaşı: " + passangerAge);
            //Console.WriteLine("TC No: " + passangerIdentityNumber);
            //Console.WriteLine("--------------------------------");

            #endregion

            #region Klavyeden tam sayı girişleri ve dönüşümler

            //int shoesPrice,
            //    computerPrice,
            //    chairPrice,
            //    tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 7500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız koltuk sayısını giriniz: ");
            //chairCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televisyon sayısını giriniz: ");
            //tvCount = Convert.ToInt32(Console.ReadLine());

            //int totalPrice=shoesPrice*shoesCount+
            //    computerCount*computerPrice+
            //    chairCount*chairPrice+
            //    tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken değer : "+totalPrice);
            #endregion

            #region Klavyeden Ondalık Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = Convert.ToDouble(Console.ReadLine());

            //result = ((exam1 + exam2 + exam3)/3);

            //Console.WriteLine();
            //Console.Write("Sınav ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Cinsiyetinizi seçiniz: ");
            //gender = Convert.ToChar(Console.ReadLine());

            //Console.Write("Cinsiyetiniz :"+ gender);
            #endregion

            Console.Read();
        }
    }
}
