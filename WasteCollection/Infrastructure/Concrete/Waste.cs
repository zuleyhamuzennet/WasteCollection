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

using WasteCollection.Infrastructure.Enums;
using WasteCollection.Infrastructure.Interfaces;

namespace WasteCollection.Infrastructure.Concrete
{
    public class Waste : IWaste
    {
        public WasteBinType WasteBinType { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public string ImagePath { get; set; }
    }
}