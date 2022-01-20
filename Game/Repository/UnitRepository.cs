using Game.Entity;
using Game.Entity.Type;

namespace Game.Repository;

public class UnitRepository : IUnitRepository
{
    public Unit Get(Units type)
    {
        // В этом методе может происходить обращение к базе данных
        // или файлу конфигурации для получения информации о юнитах.

        var builder = new UnitBuilder();
        return (type switch
        {
            #region Human

            #region Units
            
            Units.Sorceress => builder
                .SetBaseData(type, Race.Human, 2, "Sorceress")
                .SetBuildData(Units.ArcaneSanctum, TimeSpan.FromSeconds(30), "S")
                .SetPrice(155, 20, 2)
                .SetHitPoints(325)
                .SetMana(200, 0.67, 75)
                .SetArmor(ArmorType.Unarmored)
                .AddBasicAbilities()
                .AddAbilities(Abilities.Slow)
                .AddAttack(10, 12, AttackType.Magic, WeaponType.Missile, 600, 1.75, new[]
                {
                    AttackTargetType.Ground,
                    AttackTargetType.Structure,
                    AttackTargetType.Derbis,
                    AttackTargetType.Air,
                    AttackTargetType.Item,
                    AttackTargetType.Ward
                }),

            Units.Knight => builder
                .SetBaseData(type, Race.Human, 4, "Knight")
                .SetBuildData(Units.BarracksHuman, TimeSpan.FromSeconds(40), "K", new[]
                {
                    Units.Castle,
                    Units.Blacksmith,
                    Units.LumberMill
                })
                .SetPrice(245, 60, 4)
                .SetHitPoints(885)
                .SetArmor(ArmorType.Heavy, 5)
                .AddAttack(30, 38, AttackType.Normal, WeaponType.Normal, 100, 1.4, new[]
                {
                    AttackTargetType.Ground,
                    AttackTargetType.Structure,
                    AttackTargetType.Derbis,
                    AttackTargetType.Item,
                    AttackTargetType.Ward
                }),

            Units.GryphonRider => builder
                .SetBaseData(type, Race.Human, 5, "Gryphon Rider")
                .SetBuildData(Units.GryphonAviary, TimeSpan.FromSeconds(45), "G", new[]
                {
                    Units.Castle
                })
                .SetPrice(280, 70, 4)
                .SetHitPoints(875)
                .SetArmor(ArmorType.Light)
                .AddAttack(45, 55, AttackType.Magic, WeaponType.MissileLine, 450, 2.2, new[]
                {
                    AttackTargetType.Ground,
                    AttackTargetType.Structure,
                    AttackTargetType.Derbis,
                    AttackTargetType.Item,
                    AttackTargetType.Ward
                })
                .AddAttack(45, 55, AttackType.Magic, WeaponType.Missile, 450, 2.4, new[]
                {
                    AttackTargetType.Air
                }),
            
            #endregion

            #region Buildings
            
            #endregion
            
            #endregion

            #region Orc

            #region Units

            #endregion

            #region Buildings
            
            #endregion

            #endregion

            #region Night Elf

            #region Units

            #endregion

            #region Buildings
            
            #endregion

            #endregion

            #region Undead

            #region Units

            #endregion

            #region Buildings
            
            #endregion

            #endregion
            
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        }).Build();
    }
}