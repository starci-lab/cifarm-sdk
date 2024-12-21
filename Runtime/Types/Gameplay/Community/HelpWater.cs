using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class HelpWaterRequest : NeighborUserIdRequest
    {
        public string PlacedItemTileId { get; set; }
    }

    public class HelpWaterResponse
    {
    }
}
