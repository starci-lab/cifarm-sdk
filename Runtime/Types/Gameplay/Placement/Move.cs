using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Placement
{
    public class MoveRequest
    {
        public string PlacedItemTileId { get; set; }
        public Position Position { get; set; }
    }

    public class MoveResponse
    {
    }
}
