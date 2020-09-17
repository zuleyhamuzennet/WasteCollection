/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje Ödevi
**				ÖĞRENCİ ADI............: ZÜLEYHA MÜZENNET
**				ÖĞRENCİ NUMARASI.......: G161210040
**              DERSİN ALINDIĞI GRUP...: 2B
****************************************************************************/


using System;
using WasteCollection.Infrastructure.Concrete;
using WasteCollection.Infrastructure.Enums;

namespace WasteCollection.Infrastructure.Interfaces
{
    public interface IWasteBin : IWasteProperties
    {
        WasteBinType WasteBinType { get; set; }
        int UnloadingScore { get; set; }
        
        TimeSpan UnloadingTime { get;  }
        // Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.

        int ClearVolume { get; }
        //Atığın kutuya eklenip eklenmediğini döndürür.
        bool Insert(Waste waste);

        // Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.
        bool Clear();
    }
}