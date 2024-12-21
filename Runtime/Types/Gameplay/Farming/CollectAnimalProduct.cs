namespace StarCi.CiFarmSDK.Types.Gameplay.Farming
{
    public class CollectAnimalProductRequest
    {
        public string CropId { get; set; }
        public string UserId { get; set; }
    }

    public class CollectAnimalProductResponse
    {
        public string Status { get; set; }
        public int Yield { get; set; }
    }
}
