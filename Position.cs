class Position {

    protected int x = 0;
    protected int y = 0;
    protected Vector2 Velocity = new Vector2(0,0);
    
    public Position() {

    }

    public int GetX() {
        return x;
    }

    public void SetX(int x_value) {
        x = x_value;
    }

    public int GetY() {
        return y;
    }

    public void SetY(int y_value) {
        y = y_value;
    }
}