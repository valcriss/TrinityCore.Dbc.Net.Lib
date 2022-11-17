using TrinityCore.Dbc.Net.Lib.Definitions;

namespace TrinityCore.Dbc.Net.Lib.Tests
{
    [TestClass]
    public class OpenFileTests
    {
        [TestMethod]
        public void OpenFile()
        {
            DbcDirectory.Initialize(@"C:\Users\silve\Documents\Unity\wowData\3.3.5\dbc", Enums.DbcLocale.frFR);
            List<NamesReserved> namesReserved = DbcDirectory.Open<NamesReserved>();
            List<AnimationData> animationDatas = DbcDirectory.Open<AnimationData>();
            List<Achievement> achievements = DbcDirectory.Open<Achievement>();
            List<AchievementCategory> achievementCategories = DbcDirectory.Open<AchievementCategory>();
            List<AchievementCriteria> achievementCriterias = DbcDirectory.Open<AchievementCriteria>();
            List<AreaGroup> areaGroups = DbcDirectory.Open<AreaGroup>();
            List<AreaTable> areaTables = DbcDirectory.Open<AreaTable>();
            List<AreaTrigger> areaTriggers = DbcDirectory.Open<AreaTrigger>();
            List<AreaPOI> areaPOIs = DbcDirectory.Open<AreaPOI>();
            List<AttackAnimKits> attackAnimKits = DbcDirectory.Open<AttackAnimKits>();
            List<AttackAnimTypes> attackAnimTypes = DbcDirectory.Open<AttackAnimTypes>();
            List<AuctionHouse> auctionHouses = DbcDirectory.Open<AuctionHouse>();
            List<BankBagSlotPrices> bankBagSlotPrices = DbcDirectory.Open<BankBagSlotPrices>();
            List<BannedAddOns> bannedAddOns = DbcDirectory.Open<BannedAddOns>();
            List<BarberShopStyle> barberShopStyles = DbcDirectory.Open<BarberShopStyle>(); 
            List<BattlemasterList> battlemasterLists = DbcDirectory.Open<BattlemasterList>();
            List<CameraShakes> cameraShakes = DbcDirectory.Open<CameraShakes>();
            List<CfgCategories> cfgCategories = DbcDirectory.Open<CfgCategories>();
            List<CfgConfigs> cfgConfigs = DbcDirectory.Open<CfgConfigs>();
            List<CharacterFacialHairStyles> characterFacialHairStyles = DbcDirectory.Open<CharacterFacialHairStyles>();
            List<CharBaseInfo> charBaseInfos = DbcDirectory.Open<CharBaseInfo>();
            List<CharHairGeosets> charHairGeosets = DbcDirectory.Open<CharHairGeosets>();
            List<CharHairTextures> charHairTextures = DbcDirectory.Open<CharHairTextures>();
            List<CharSections> charSections = DbcDirectory.Open<CharSections>();
            List<CharStartOutfit> charStartOutfits = DbcDirectory.Open<CharStartOutfit>();
            List<CharTitles> charTitles = DbcDirectory.Open<CharTitles>();
            // List<CharVariations> charVariations = DbcDirectory.Open<CharVariations>();
            List<ChatChannels> chatChannels = DbcDirectory.Open<ChatChannels>();
            List<ChatProfanity> chatProfanities = DbcDirectory.Open<ChatProfanity>();
            List<ChrClasses> chrClasses = DbcDirectory.Open<ChrClasses>();
            List<ChrRaces> chrRaces = DbcDirectory.Open<ChrRaces>();
            List<CinematicCamera> cinematicCameras = DbcDirectory.Open<CinematicCamera>();
            List<CinematicSequences> cinematicSequences = DbcDirectory.Open<CinematicSequences>();
            List<CreatureDisplayInfo> creatureDisplayInfos = DbcDirectory.Open<CreatureDisplayInfo>();
            List<CreatureDisplayInfoExtra> creatureDisplayInfoExtras = DbcDirectory.Open<CreatureDisplayInfoExtra>();
            List<CreatureFamily> creatureFamilies = DbcDirectory.Open<CreatureFamily>();
        }
    }
}