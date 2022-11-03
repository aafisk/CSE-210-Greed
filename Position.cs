class Position {

    protected int x = 0;
    protected int y = 0;
    protected int x_velocity = 0;
    protected int y_velocity = 0;
    
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