namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class ThiefAnimalProductRequest
    {
        public string UserId { get; set; }
        public string NeighborUserId { get; set; }
    }

    public class ThiefAnimalProductResponse
    {
        public string Status { get; set; }
        public int StolenAmount { get; set; }
    }
}
