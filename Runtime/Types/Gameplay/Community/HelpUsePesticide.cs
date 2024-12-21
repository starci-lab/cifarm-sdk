namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class HelpUsePesticideRequest
    {
        public string UserId { get; set; }
        public string NeighborUserId { get; set; }
    }

    public class HelpUsePesticideResponse
    {
        public string Status { get; set; }
    }
}
