using Raylib_cs;

class Game {

    private List<Removable> removables = new List<Removable>();
    private Player player = new Player();

    public Game() {

    }

    public void Play() {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
        }
    }
}