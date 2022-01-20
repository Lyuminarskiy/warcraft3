namespace Game.Entity.Type;

public enum Items
{
    #region Permanent

    // Level 1
    CloakOfShadows, GauntletsOfOgreStrength3, MantleOfIntelligence3, SlippersOfAgility3,
    // Level 2
    CircletOfNobility, ClawsOfAttack5, GlovesOfHaste, RingOfProtection3,
    // Level 3
    ClawsOfAttack9, CrystalBall, PendantOfEnergy, PeriaptOfVitality, RingOfProtection4,
    RingOfRegeneration, TalismanOfEvasion,
    // Level 4
    AlleriasFluteOfAccuracy, BeltOfGiantStrength6, BootsOfQuelThalas6, RobeOfTheMagi6,
    RunedBracers, ScourgeBoneChimes, SobiMask, TheLionHornOfStormwind,
    // Level 5
    AncientJanggoOfEndurance, ClawsOfAttack12, CloakOfFlames, HelmOfValor, HoodOfCunning,
    KhadgarsPipeOfInsight, LegionDoomHorn, MedallionOfCourage, WarsongBattleDrums,
    // Level 6
    AmuletOfSpellShield, KhadgarsGemOfHealth, OrbOfDarkness, PendantOfMana, RingOfProtection5, StaffOfSilence,

    #endregion

    #region Charged
    
    // Level 2
    ReplenishmentPotion, SentryWards, WandOfIllusion, WandOfLightningShield, 
    // Level 3
    PotionOfGreaterHealing, PotionOfGreaterMana, PotionOfInvulnerability, ScrollOfTheBeast, WandOfManaStealing,
    // Level 4
    AnkhOfReincarnation, BookOfTheDead, HealingWards, HealthStone, ManaStone, WandOfTheWind,
    // Level 5
    BlueDrakeEgg, IdolOfTheWild, PotionOfDivinity, PotionOfRestoration, ScrollOfRestoration, SpikedCollar, StoneToken,
    // Level 6
    AmuletOfTheWild, DemonicFigurine, EngravedScale, IceShard, ScepterOfAvarice, ScepterOfMastery,

    #endregion

    #region Power Up
    
    // Level 0
    RuneOfGreaterHealing, RuneOfHealing, RuneOfLesserHealing, RuneOfMana, RuneOfRebirth, RuneOfTheWatcher,
    // Level 1
    ManualOfHealth, TomeOfAgility, TomeOfIntelligence, TomeOfStrength,
    // Level 2
    TomeOfAgility2, TomeOfIntelligence2, TomeOfKnowledge, TomeOfStrength2,

    #endregion

    #region Artifact
    
    // Level 7
    ClawsOfAttack15, InfernoStone, KelensDaggerOfEscape, OrbOfFrost,
    // Level 8
    CrownOfKings5, MaskOfDeath, TomeOfPower,

    #endregion
    
    #region Purchasable
    
    // Merchant
    BootsOfSpeed, DustOfAppearance, PotionOfInvisibility, PotionOfLesserInvulnerability, ScrollOfHealing,
    ScrollOfProtection, ScrollOfTownPortal, StaffOfTeleportation, TomeOfRetraining,
    // Race Shops
    AntiMagicPotion, HealingSalve, IvoryTower, LesserClarityPotion, MechanicalCritter,
    Moonstone, OrbOfCorruption, OrbOfFire, OrbOfLightning, OrbOfVenom, PotionOfHealing,
    PotionOfMana, RitualDagger, RodOfNecromancy, SacrificialSkull, ScrollOfRegeneration,
    ScrollOfSpeed, StaffOfPreservation, StaffOfSanctuary, TinyGreatHall,

    #endregion

    #region Miscellaneous
    
    ClawsOfAttack6, GoblinLandMines, NecklaceOfSpellImmunity, RedDrakeEgg, RingOfProtection2, ScrollOfAnimateDead,
    ScrollOfResurrection, TalismanOfTheWild, TomeOfExperience, TomeOfGreaterExperience, WandOfNegation

    #endregion
}