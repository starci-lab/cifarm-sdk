namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class UnfollowRequest
    {
        public string UserId { get; set; }
        public string UnfollowedUserId { get; set; }
    }

    public class UnfollowResponse
    {
        public string Status { get; set; }
    }
}
