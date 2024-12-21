using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Placement
{
    public class PlaceTileRequest
    {
        public string InventoryTileId { get; set; }
        public Position Position { get; set; }
    }


    public class PlaceTileResponse
    {
        public string PlacedItemTileId { get; set; }

    }
}
