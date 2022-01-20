namespace Game.UI;

public sealed class Cursor
{
    public static readonly Cursor Current = new();
        
    public delegate void MouseDelegate(Cursor cursor);
    public event MouseDelegate MouseDown;
    public event MouseDelegate MouseMove;
    public event MouseDelegate MouseUp;
        
    /// <summary>
    /// Текущая позиция курсора.
    /// </summary>
    public readonly Point Point = new(0, 0);
        
    /// <summary>
    /// Активеность курсора.
    /// </summary>
    public readonly bool pressed = false;
        
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Point"/>.
    /// </summary>
    private Cursor() {}
}