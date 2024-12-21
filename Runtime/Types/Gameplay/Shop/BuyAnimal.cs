using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Shop
{
    public class BuyAnimalRequest
    {
        public string AnimalId { get; set; }
        public string PlacedItemBuildingId { get; set; }
        public Position Position { get; set; }
    }

    public class BuyAnimalResponse
    {
    }
}
