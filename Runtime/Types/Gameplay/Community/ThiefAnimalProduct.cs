using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class ThiefAnimalProductRequest : NeighborUserIdRequest
    {
        public string PlacedItemAnimalId { get; set; }
    }

    public class ThiefAnimalProductResponse
    {
        public int Quantity { get; set; }
    }
}
