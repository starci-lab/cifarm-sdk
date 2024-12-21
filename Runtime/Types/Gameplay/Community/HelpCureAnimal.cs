using StarCi.CiFarmSDK.Types.Base;

namespace StarCi.CiFarmSDK.Types.Gameplay.Community
{
    public class HelpCureAnimalRequest : NeighborUserIdRequest
    {
        public string PlacedItemAnimalId { get; set; }
    }

    public class HelpCureAnimalResponse
    {
    }
}
