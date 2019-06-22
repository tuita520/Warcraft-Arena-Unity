﻿namespace Core
{
    public enum EntityAttributes
    {
        Entry = BaseEntityAttributes.Entry,
        Scale = BaseEntityAttributes.Scale,
        DynamicFlags = BaseEntityAttributes.DynamicFlags,

        GameEntityCreatedBy = GameEntityAttributes.CreatedBy,
        GameEntityDisplayId = GameEntityAttributes.DisplayId,
        GameEntityFlags = GameEntityAttributes.GameEntityFlags,
        GameEntityFaction = GameEntityAttributes.Faction,
        GameEntityLevel = GameEntityAttributes.GameEntityLevel,
        GameEntityInfo = GameEntityAttributes.GameEntityInfo,
        SpellVisualID = GameEntityAttributes.SpellVisualId,
        StateSpellVisualID = GameEntityAttributes.StateSpellVisualId,
        StateAnimID = GameEntityAttributes.StateAnimId,
        StateAnimKitID = GameEntityAttributes.StateAnimKitId,
        StateWorldEffectID = GameEntityAttributes.StateWorldEffectId,

        DynamicCaster = DynamicEntityAttributes.DynamicCaster,
        DynamicEntityType = DynamicEntityAttributes.DynamicEntityType,
        DynamicSpellVisualID = DynamicEntityAttributes.DynamicSpellVisualID,
        DynamicSpellid = DynamicEntityAttributes.DynamicSpellid,
        DynamicRadius = DynamicEntityAttributes.DynamicRadius,
        DynamicCasttime = DynamicEntityAttributes.DynamicCastTime,

        UnitCharm = UnitAttributes.Charm,
        UnitSummon = UnitAttributes.Summon,
        UnitCharmedBy = UnitAttributes.CharmedBy,
        UnitSummonedBy = UnitAttributes.SummonedBy,
        UnitCreatedBy = UnitAttributes.CreatedBy,
        Target = UnitAttributes.Target,
        BattlePetCompanionGuid = UnitAttributes.BattlePetCompanionGuid,
        ChannelSpell = UnitAttributes.ChannelSpell,
        Info = UnitAttributes.Info,
        DisplayPower = UnitAttributes.DisplayPower,
        OverrideDisplayPowerId = UnitAttributes.OverrideDisplayPowerId,
        Health = UnitAttributes.Health,
        Power = UnitAttributes.Power,
        MaxHealth = UnitAttributes.MaxHealth,
        MaxPower = UnitAttributes.MaxPower,
        PowerRegenFlatModifier = UnitAttributes.PowerRegenFlatModifier,
        PowerRegenInterruptedFlatModifier = UnitAttributes.PowerRegenInterruptedFlatModifier,
        Level = UnitAttributes.Level,
        FactionTemplate = UnitAttributes.FactionId,
        UnitVirtualItemSlotId = UnitAttributes.UnitVirtualItemSlotId,
        UnitFlags = UnitAttributes.UnitFlags,
        AuraState = UnitAttributes.AuraState,
        BaseAttackTimeMain = UnitAttributes.BaseAttackTimeMain,
        BaseAttackTimeOffhand = UnitAttributes.BaseAttackTimeOffhand,
        BaseAttackTimeRanged = UnitAttributes.BaseAttackTimeRanged,
        BoundingRadius = UnitAttributes.BoundingRadius,
        CombatReach = UnitAttributes.CombatReach,
        DisplayId = UnitAttributes.DisplayId,
        NativeDisplayId = UnitAttributes.NativeDisplayId,
        MountDisplayId = UnitAttributes.MountDisplayId,
        MinDamage = UnitAttributes.MinDamage,
        MaxDamage = UnitAttributes.MaxDamage,
        MinOffhandDamage = UnitAttributes.MinOffhandDamage,
        MaxOffhandDamage = UnitAttributes.MaxOffhandDamage,
        PetNumber = UnitAttributes.PetNumber,
        PetNameTimestamp = UnitAttributes.PetNameTimestamp,
        PetExperience = UnitAttributes.PetExperience,
        PetNextLevelExp = UnitAttributes.PetNextLevelExp,
        UnitModCastSpeed = UnitAttributes.UnitModCastSpeed,
        ModSpellHaste = UnitAttributes.UnitModCastHaste,
        ModHaste = UnitAttributes.ModHaste,
        ModRangedHaste = UnitAttributes.ModRangedHaste,
        ModRegenHaste = UnitAttributes.ModHasteRegen,
        ModTimeRate = UnitAttributes.ModTimeRate,
        UnitCreatedBySpell = UnitAttributes.UnitCreatedBySpell,
        UnitNpcFlags = UnitAttributes.UnitNpcFlags,
        Stat = UnitAttributes.Stat,
        Stat1 = UnitAttributes.Stat1,
        Stat2 = UnitAttributes.Stat2,
        Stat3 = UnitAttributes.Stat3,
        PosStat = UnitAttributes.PosStat,
        PosStat1 = UnitAttributes.PosStat1,
        PosStat2 = UnitAttributes.PosStat2,
        PosStat3 = UnitAttributes.PosStat3,
        NegStat = UnitAttributes.NegStat,
        NegStat1 = UnitAttributes.NegStat1,
        NegStat2 = UnitAttributes.NegStat2,
        NegStat3 = UnitAttributes.NegStat3,
        Resistances = UnitAttributes.Resistance,
        ResistanceBuffModsPositive = UnitAttributes.ResistanceBuffModsPositive,
        ResistanceBuffModsNegative = UnitAttributes.ResistanceBuffModsNegative,
        BaseMana = UnitAttributes.BaseMana,
        BaseHealth = UnitAttributes.BaseHealth,
        BaseFlags = UnitAttributes.BaseFlags,
        AttackPower = UnitAttributes.AttackPower,
        AttackPowerModPos = UnitAttributes.AttackPowerModPos,
        AttackPowerModNeg = UnitAttributes.AttackPowerModNeg,
        AttackPowerMultiplier = UnitAttributes.AttackPowerMultiplier,
        RangedAttackPower = UnitAttributes.RangedAttackPower,
        RangedAttackPowerModPos = UnitAttributes.RangedAttackPowerModPositive,
        RangedAttackPowerModNeg = UnitAttributes.RangedAttackPowerModNegative,
        RangedAttackPowerMultiplier = UnitAttributes.RangedAttackPowerMultiplier,
        MinRangedDamage = UnitAttributes.MinRangedDamage,
        MaxRangedDamage = UnitAttributes.MaxRangedDamage,
        PowerCostModifier = UnitAttributes.PowerCostModifier,
        PowerCostMultiplier = UnitAttributes.PowerCostMultiplier,

        PlayerFlags = PlayerAttributes.PlayerFlags,
        ArenaTeam = PlayerAttributes.ArenaTeam,
        DuelTeam = PlayerAttributes.DuelTeam,
        ChosenTitle = PlayerAttributes.ChosenTitle,
        CurrentSpecId = PlayerAttributes.SpecId,
        Coinage = PlayerAttributes.Coinage,
        Xp = PlayerAttributes.Xp,
        PlayerCharacterPoints = PlayerAttributes.PlayerCharacterPoints,
        NextLevelXp = PlayerAttributes.NextLevelXp,
        BlockPercentage = PlayerAttributes.BlockPercentage,
        DodgePercentage = PlayerAttributes.DodgePercentage,
        DodgePercentageFromAttribute = PlayerAttributes.DodgePercentageFromAttribute,
        ParryPercentage = PlayerAttributes.ParryPercentage,
        ParryPercentageFromAttribute = PlayerAttributes.ParryPercentageFromAttribute,
        CritPercentage = PlayerAttributes.CritPercentage,
        RangedCritPercentage = PlayerAttributes.RangedCritPercentage,
        OffhandCritPercentage = PlayerAttributes.OffhandCritPercentage,
        SpellCritPercentage = PlayerAttributes.SpellCritPercentage,
        ShieldBlock = PlayerAttributes.ShieldBlock,
        ShieldBlockCritPercentage = PlayerAttributes.ShieldBlockCritPercentage,
        Mastery = PlayerAttributes.Mastery,
        ModDamageDonePos = PlayerAttributes.ModDamageDonePositive,
        ModDamageDoneNeg = PlayerAttributes.ModDamageDoneNegative,
        ModDamageDonePercent = PlayerAttributes.ModDamageDonePercent,
    }

    public enum BaseEntityAttributes
    {
        Entry = 1,
        Scale = 2,
        DynamicFlags = 3,
    }

    public enum GameEntityAttributes
    {
        CreatedBy = BaseEntityAttributes.DynamicFlags + 1,
        DisplayId,
        GameEntityFlags,
        Faction,
        GameEntityLevel,
        GameEntityInfo,
        SpellVisualId,
        StateSpellVisualId,
        StateAnimId,
        StateAnimKitId,
        StateWorldEffectId,
    }

    public enum DynamicEntityAttributes
    {
        DynamicCaster = GameEntityAttributes.StateWorldEffectId + 1,
        DynamicEntityType,
        DynamicSpellVisualID,
        DynamicSpellid,
        DynamicRadius,
        DynamicCastTime,
    }

    public enum UnitAttributes
    {
        Charm = DynamicEntityAttributes.DynamicCastTime + 1,
        Summon,
        CharmedBy,
        SummonedBy,
        CreatedBy,
        Target,
        BattlePetCompanionGuid,
        ChannelSpell,
        Info,
        DisplayPower,
        OverrideDisplayPowerId,
        Health,
        Power,
        MaxHealth,
        MaxPower,
        PowerRegenFlatModifier,
        PowerRegenInterruptedFlatModifier,
        Level,
        FactionId,
        UnitVirtualItemSlotId,
        UnitFlags,
        AuraState,
        BaseAttackTimeMain,
        BaseAttackTimeOffhand,
        BaseAttackTimeRanged,
        BoundingRadius,
        CombatReach,
        DisplayId,
        NativeDisplayId,
        MountDisplayId,
        MinDamage,
        MaxDamage,
        MinOffhandDamage,
        MaxOffhandDamage,
        PetNumber,
        PetNameTimestamp,
        PetExperience,
        PetNextLevelExp,
        UnitModCastSpeed,
        UnitModCastHaste,
        ModHaste,
        ModRangedHaste,
        ModHasteRegen,
        ModTimeRate,
        UnitCreatedBySpell,
        UnitNpcFlags,
        Stat,
        Stat1,
        Stat2,
        Stat3,
        PosStat,
        PosStat1,
        PosStat2,
        PosStat3,
        NegStat,
        NegStat1,
        NegStat2,
        NegStat3,
        Resistance,
        ResistanceBuffModsPositive,
        ResistanceBuffModsNegative,
        BaseMana,
        BaseHealth,
        BaseFlags,
        AttackPower,
        AttackPowerModPos,
        AttackPowerModNeg,
        AttackPowerMultiplier,
        RangedAttackPower,
        RangedAttackPowerModPositive,
        RangedAttackPowerModNegative,
        RangedAttackPowerMultiplier,
        MinRangedDamage,
        MaxRangedDamage,
        PowerCostModifier,
        PowerCostMultiplier,
    }

    public enum PlayerAttributes
    {
        PlayerFlags = UnitAttributes.PowerCostMultiplier + 1,
        ArenaTeam,
        DuelTeam,
        ChosenTitle,
        SpecId,
        Coinage,
        Xp,
        PlayerCharacterPoints,
        NextLevelXp,
        BlockPercentage,
        DodgePercentage,
        DodgePercentageFromAttribute,
        ParryPercentage,
        ParryPercentageFromAttribute,
        CritPercentage,
        RangedCritPercentage,
        OffhandCritPercentage,
        SpellCritPercentage,
        ShieldBlock,
        ShieldBlockCritPercentage,
        Mastery,
        ModDamageDonePositive,
        ModDamageDoneNegative,
        ModDamageDonePercent,
    }
}