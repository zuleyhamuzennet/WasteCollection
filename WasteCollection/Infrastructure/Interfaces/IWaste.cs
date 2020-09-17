using WasteCollection.Infrastructure.Enums;

namespace WasteCollection.Infrastructure.Interfaces
{
    public interface IWaste
    {
        WasteBinType WasteBinType { get; set; }
        string Name { get; set; }
        int Volume { get; set; }
        string ImagePath { get; set; }
    }
}
