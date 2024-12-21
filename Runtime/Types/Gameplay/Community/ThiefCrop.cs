namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class ThiefCropRequest
    {
        public string UserId { get; set; }
        public string NeighborUserId { get; set; }
    }

    public class ThiefCropResponse
    {
        public string Status { get; set; }
        public int StolenAmount { get; set; }
    }
}
