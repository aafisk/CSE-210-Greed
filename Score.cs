using Raylib_cs;
using System.Numerics;

class Score: Position {

    private int ScoreTotal = 0;
    
    public Score() {
        position = new Vector2(5, 5);
    }

    public override void Draw() {
        Raylib.DrawText("Score: " + ScoreTotal.ToString(), (int)position.X, (int)position.Y, 20, Color.WHITE);
    }

    public int getScore() {
        return ScoreTotal;
    }

    public void updateScore(int points) {
        ScoreTotal += points;
    }
}