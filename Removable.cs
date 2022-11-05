using System.Numerics;

class Removable: Position {

    protected int pointValue = 0;
    
    public Removable() {

    }

    public void Advance() {
        Vector2 NewPosition = position;
        NewPosition.Y += Velocity.Y;
        position = NewPosition;
        rectangle.x = NewPosition.X;
        rectangle.y = NewPosition.Y;
    }

    public int GetPointValue() {
        return pointValue;
    }
}