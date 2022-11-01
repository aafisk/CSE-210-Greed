using Raylib_cs;

class Game {

    public Game() {
        private List<Removable> rocks = new List<Removable>();
    }

    public void Play() {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
        }
    }
}