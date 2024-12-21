namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class VisitRequest
    {
        public string UserId { get; set; }
        public string VisitedUserId { get; set; }
    }

    public class VisitResponse
    {
        public string Status { get; set; }
    }
}
