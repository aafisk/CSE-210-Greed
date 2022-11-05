using Raylib_cs;
using System.Numerics;

class Player: Position {
    
    public Player(Vector2 startingPosition) {
        position = startingPosition;
        aperance = "\\_/";
        rectangle = new Rectangle(position.X, position.Y + 10, 38, 30);
    }

    public void Move(int direction) {
        Velocity = new Vector2 (direction, 0);
        Vector2 NewPosition = position;
        NewPosition.X += Velocity.X;
        position = NewPosition;
        rectangle.x = NewPosition.X;
        rectangle.y = NewPosition.Y + 10;
    }

    public override void Draw() {
        Raylib.DrawText(aperance, (int)position.X, (int)position.Y, 15, Color.BLUE);
    }
}