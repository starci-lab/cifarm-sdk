namespace StarCi.CiFarmSDK.Types.Gameplay.Farming
{
    public class HarvestCropRequest
    {
        public string CropId { get; set; }
        public string UserId { get; set; }
    }

    public class HarvestCropResponse
    {
        public string Status { get; set; }
        public int Yield { get; set; }
    }
}
