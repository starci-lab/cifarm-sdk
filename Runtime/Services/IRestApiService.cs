using StarCi.CiFarmSDK.Types.Gameplay.Auth;
using StarCi.CiFarmSDK.Types.Gameplay.Claim;
using StarCi.CiFarmSDK.Types.Gameplay.Community;
using StarCi.CiFarmSDK.Types.Gameplay.Delivery;
using StarCi.CiFarmSDK.Types.Gameplay.Farming;
using StarCi.CiFarmSDK.Types.Gameplay.Placement;
using StarCi.CiFarmSDK.Types.Gameplay.Profile;
using StarCi.CiFarmSDK.Types.Gameplay.Shop;
using StarCi.CiFarmSDK.Types.Gameplay.Upgrade;
using System.Threading.Tasks;

namespace StarCi.CiFarmSDK.Services
{
    public interface IRestApiService
    {
        // Auth
        Task<MessageResponse> Message(MessageRequest request);
        Task<TestSignatureResponse> TestSignature(TestSignatureRequest request);
        Task<VerifySignatureResponse> VerifySignature(VerifySignatureRequest request);
        Task<RefreshResponse> Refresh(RefreshRequest request);

        // Claim
        Task<ClaimDailyRewardResponse> ClaimDailyReward(ClaimDailyRewardRequest request);
        Task<SpinResponse> Spin(SpinRequest request);

        // Community
        Task<FollowResponse> Follow(FollowRequest request);
        Task<UnfollowResponse> Unfollow(UnfollowRequest request);
        Task<VisitResponse> Visit(VisitRequest request);
        Task<HelpCureAnimalResponse> HelpCureAnimal(HelpCureAnimalRequest request);
        Task<HelpUseHerbicideResponse> HelpUseHerbicide(HelpUseHerbicideRequest request);
        Task<HelpUsePesticideResponse> HelpUsePesticide(HelpUsePesticideRequest request);
        Task<HelpWaterResponse> HelpWater(HelpWaterRequest request);
        Task<ReturnResponse> Return(ReturnRequest request);
        Task<ThiefAnimalProductResponse> ThiefAnimalProduct(ThiefAnimalProductRequest request);
        Task<ThiefCropResponse> ThiefCrop(ThiefCropRequest request);

        // Delivery
        Task<DeliverProductResponse> DeliverProduct(DeliverProductRequest request);
        Task<RetainProductResponse> RetainProduct(RetainProductRequest request);

        // Farming
        Task<CollectAnimalProductResponse> CollectAnimalProduct(CollectAnimalProductRequest request);
        Task<CureAnimalResponse> CureAnimal(CureAnimalRequest request);
        Task<FeedAnimalResponse> FeedAnimal(FeedAnimalRequest request);
        Task<HarvestCropResponse> HarvestCrop(HarvestCropRequest request);
        Task<PlantSeedResponse> PlantSeed(PlantSeedRequest request);
        Task<UseFertilizerResponse> UseFertilizer(UseFertilizerRequest request);
        Task<UseHerbicideResponse> UseHerbicide(UseHerbicideRequest request);
        Task<UsePesticideResponse> UsePesticide(UsePesticideRequest request);
        Task<WaterResponse> Water(WaterRequest request);

        // Shop
        Task<BuySeedsResponse> BuySeeds(BuySeedsRequest request);
        Task<BuyAnimalResponse> BuyAnimal(BuyAnimalRequest request);
        Task<BuySuppliesResponse> BuySupplies(BuySuppliesRequest request);
        Task<BuyTileResponse> BuyTile(BuyTileRequest request);
        Task<ConstructBuildingResponse> ConstructBuilding(ConstructBuildingRequest request);

        // Placement
        Task<MoveResponse> Move(MoveRequest request);
        Task<PlaceTileResponse> PlaceTile(PlaceTileRequest request);
        Task<RecoverTileResponse> RecoverTile(RecoverTileRequest request);

        // Profile
        Task<UpdateTutorialResponse> UpdateTutorial(UpdateTutorialRequest request);

        // Upgrade
        Task<UpgradeBuildingResponse> UpgradeBuilding(UpgradeBuildingRequest request);
    }
}
