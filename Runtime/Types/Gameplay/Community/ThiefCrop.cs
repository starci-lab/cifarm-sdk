using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class ThiefCropRequest : NeighborUserIdRequest
    {
        public string PlacedItemTileId { get; set; }
    }

    public class ThiefCropResponse
    {
        public int Quantity { get; set; }
    }
}
