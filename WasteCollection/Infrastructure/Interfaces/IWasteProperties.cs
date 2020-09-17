namespace WasteCollection.Infrastructure.Interfaces
{
    public interface IWasteProperties 
    { 
        int Capacity { get; set; } 
        int FullVolume { get; set; } 
        int FullRate { get; }
    }
}
