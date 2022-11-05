using Raylib_cs;
using System.Numerics;

class Game {

    private int ScreenHeight = 600;
    private int ScreenWidth = 400;
    private List<Removable> removables = new List<Removable>();
    private Player player;
    private Score score = new Score();
    private Random random = new Random();

    public Game() {
        player = new Player(new Vector2(ScreenWidth / 2, ScreenHeight - 20));
    }

    public void Play() {

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            int createObject = random.Next(20);

            if (createObject == 1) {
                // Choose which type of removable object will be created.
                int whichType = random.Next(100);

                // Choose where the object will be created and how fast it will go.
                int randomX = random.Next(5, ScreenWidth - 5);
                int randomSpeed = random.Next(3, 5);

                var position = new Vector2(randomX, -1);
                var velocity = new Vector2(0, randomSpeed);

                switch (whichType) {
                    case int n when n > 60:
                        Gem gem = new Gem();
                        gem.SetPosition(position);
                        gem.SetVelocity(velocity);
                        removables.Add(gem);
                        break;

                    case int n when n > 20:
                        Rock rock = new Rock();
                        rock.SetPosition(position);
                        rock.SetVelocity(velocity);
                        removables.Add(rock);
                        break;

                    case int n when n > 10:
                        BigRock bigRock= new BigRock();
                        bigRock.SetPosition(position);
                        bigRock.SetVelocity(velocity);
                        removables.Add(bigRock);
                        break;

                    case int n when n > 0:
                        BigGem bigGem = new BigGem();
                        bigGem.SetPosition(position);
                        bigGem.SetVelocity(velocity);
                        removables.Add(bigGem);
                        break;
                    
                    default:
                        break;
                }
            }

            // Check for collisions
            int iRemovable = 0;
            bool remove = false;
            foreach (var removable in removables) {
                
                if (Raylib.CheckCollisionRecs(removable.rectangle, player.rectangle)) {
                    score.updateScore(removable.GetPointValue());
                    iRemovable = removables.IndexOf(removable);
                    remove = true;
                }
            }

            if (remove) {
                removables.RemoveAt(iRemovable);
            }

            // Draw all removable objects and the player to the screen.
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            player.Draw();
            foreach (var removable in removables) {
                removable.Draw();
            }
            score.Draw();
            Raylib.EndDrawing();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) || Raylib.IsKeyDown(KeyboardKey.KEY_D)) {
                player.Move(3);
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(KeyboardKey.KEY_A)) {
                player.Move(-3);
            }

            foreach (var removable in removables) {
                removable.Advance();
            }
        }

        Raylib.CloseWindow();
    }
}