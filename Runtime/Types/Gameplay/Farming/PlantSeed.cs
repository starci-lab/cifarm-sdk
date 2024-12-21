namespace StarCi.CiFarmSDK.Types.Gameplay.Farming
{
    public class PlantSeedRequest
    {
        public string SeedType { get; set; }
        public int TileId { get; set; }
        public string UserId { get; set; }
    }

    public class PlantSeedResponse
    {
        public string Status { get; set; }
    }
}
