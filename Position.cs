using Raylib_cs;
using System.Numerics;

class Position {

    protected Vector2 position { get; set; } = new Vector2(0, 0);
    protected Vector2 Velocity { get; set; } = new Vector2(0, 0);
    protected string aperance = "";
    public Rectangle rectangle;
    
    public Position() {

    }

    virtual public void Draw() {

    }

    public void SetPosition(Vector2 newPosition) {
        position = newPosition;
    }

    public void SetVelocity(Vector2 newVelocity) {
        Velocity = newVelocity;
    }

    public Vector2 GetPosition() {
        return position;
    }
}