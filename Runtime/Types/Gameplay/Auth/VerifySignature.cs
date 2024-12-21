namespace StarCi.CiFarmSDK.Types.Gameplay.Auth
{
    public class VerifySignatureRequest
    {
        public string Signature { get; set; }
    }

    public class VerifySignatureResponse
    {
        public bool IsVerified { get; set; }
        public string UserId { get; set; }
    }
}
