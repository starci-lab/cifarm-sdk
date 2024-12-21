namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class HelpWaterRequest
    {
        public string UserId { get; set; }
        public string NeighborUserId { get; set; }
    }

    public class HelpWaterResponse
    {
        public string Status { get; set; }
    }
}
