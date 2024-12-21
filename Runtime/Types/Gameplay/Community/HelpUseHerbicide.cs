using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class HelpUseHerbicideRequest : NeighborUserIdRequest
    {
        public string PlacedItemTileId { get; set; }
    }

    public class HelpUseHerbicideResponse
    {
    }
}
