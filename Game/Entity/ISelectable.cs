namespace Game.Entity;

public interface ISelectable
{
    /// <summary>
    /// Добавлен в текущую группу.
    /// </summary>
    bool Selected { get; set; }
}