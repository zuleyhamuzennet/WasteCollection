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
using WasteCollection.Infrastructure.Enums;
using WasteCollection.Infrastructure.Interfaces;

namespace WasteCollection.Infrastructure.Concrete
{
    public class WasteBin : IWasteBin
    {
        #region Properties

        public int UnloadingScore { get; set; }
        public int Capacity { get; set; }
        public int FullVolume { get; set; }
        public int FullRate => (Capacity - (Capacity - FullVolume)) * 100 / Capacity;
        
        public TimeSpan UnloadingTime => TimeSpan.FromSeconds(4);
        public int ClearVolume => Capacity * 75 / 100;

        public WasteBinType WasteBinType { get; set; }

        #endregion

        public bool Clear()
        {
            if (FullVolume >= ClearVolume)
            {
                FullVolume = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert(Waste waste)
        {
            if (FullVolume > ClearVolume)
            {
                return false;
            }
            else
            {
                FullVolume += waste.Volume;
            }

            return (Capacity > FullVolume);
        }
    }
}