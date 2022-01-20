namespace Game.UI;

public class Screen
{
    public Area Area;

    public delegate void AreaDelegate(Area area);
    public event AreaDelegate AreaSelected;
        
    private bool _areaStarted;

    public Screen()
    {
        Cursor.Current.MouseDown += cursor => Area.Start = cursor.Point;
        Cursor.Current.MouseMove += _ => _areaStarted = true;
        Cursor.Current.MouseUp += cursor =>
        {
            if (_areaStarted)
            {
                Area.End = cursor.Point;
                _areaStarted = false;
                    
                AreaSelected?.Invoke(Area);
            }
        };
    }
}