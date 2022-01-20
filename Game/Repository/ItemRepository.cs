using Game.Entity;
using Game.Entity.Type;

namespace Game.Repository;

public class ItemRepository : IItemRepository
{
    public Item Get(Items type)
    {
        // В этом методе может происходить обращение к базе данных
        // или файлу конфигурации для получения информации о предметах.

        return type switch
        {
            #region Permanent
            
            Items.CircletOfNobility => new Item
            {
                Name = "Circlet of Nobility",
                Type = type,
                Class = ItemClass.Permanent,
                Level = 3,
                Cost = 175,
                SellValue = 105
            },

            #endregion

            #region Charged

            #endregion

            #region Power Up

            #endregion

            #region Artifact

            #endregion

            #region Purchasable

            #endregion

            #region Miscellaneous

            #endregion

            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}