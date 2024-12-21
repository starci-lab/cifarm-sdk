namespace StarCi.CiFarmSDK.Types.Gameplay.Shop
{
    public class BuyAnimalRequest
    {
        public string AnimalType { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
    }

    public class BuyAnimalResponse
    {
        public string Status { get; set; }
        public int TotalCost { get; set; }
    }
}
