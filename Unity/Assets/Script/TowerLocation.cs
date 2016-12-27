public class TowerLocation {
    public int X { get; private set; }
    public int Y { get; private set; }

    public Tower Tower { get; private set; }

    public void Install(Tower tower)
    {
        Tower = tower;
    }
}