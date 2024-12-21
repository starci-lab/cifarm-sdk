namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class HelpUseHerbicideRequest
    {
        public string UserId { get; set; }
        public string NeighborUserId { get; set; }
    }

    public class HelpUseHerbicideResponse
    {
        public string Status { get; set; }
    }
}
