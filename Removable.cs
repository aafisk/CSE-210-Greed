class Removable: Position {

    protected int pointValue = 0;
    protected int fallSpeed = 0;
    
    public Removable() {

    }

    public void Advance() {
        x += x_velocity;
        y += y_velocity;
    }
}