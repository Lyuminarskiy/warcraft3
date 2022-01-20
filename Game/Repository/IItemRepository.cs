using Game.Entity;
using Game.Entity.Type;

namespace Game.Repository;

public interface IItemRepository
{
    Item Get(Items type);
}