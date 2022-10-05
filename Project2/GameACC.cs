using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace ACC
{
    public class GameACC : Game
    {
        Texture2D ballTexture;
        Vector2 ballPosition;
        Circle circle = new Circle();
        Helpers helpers = new Helpers();
       

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont font;
        
        public GameACC()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

      

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Random rnd = new Random();
            Circle circle = new Circle(rnd.Next(0, _graphics.PreferredBackBufferWidth), rnd.Next(0, _graphics.PreferredBackBufferHeight),ballTexture);
            //ballPosition = new Vector2(rnd.Next(0, _graphics.PreferredBackBufferWidth), rnd.Next(0, _graphics.PreferredBackBufferHeight));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ballTexture = Content.Load<Texture2D>("ball");
            font = Content.Load<SpriteFont>("File");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            var kstate = Keyboard.GetState();
            var mousestate = Mouse.GetState();
            Random rnd = new Random();
            Boolean flag;

            if (kstate.IsKeyDown(Keys.X) || kstate.IsKeyDown(Keys.Z))
               // take ball width / 2 and add it to the point
            {
                // sqrt((x_2 - x_1)^2 + (y_2 - y_1)^2)
                Vector2 v1 = new Vector2(mousestate.X, mousestate.Y);
                Debug.WriteLine(mousestate.X + mousestate.Y);
                if (helpers.distance(v1,circle.GetPos()) < ballTexture.Width/2)
                {
                    Debug.WriteLine("Collision Detected");
                   // circle.circlePosition = new Vector2(rnd.Next(0, _graphics.PreferredBackBufferWidth), rnd.Next(0, _graphics.PreferredBackBufferHeight));
                   circle.SetPos(rnd.Next(0, _graphics.PreferredBackBufferWidth), rnd.Next(0, _graphics.PreferredBackBufferHeight));
                }

            }

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(
                    ballTexture,
                    circle.GetPos(),
                    null,
                    Color.White,
                    0f,
                    new Vector2(ballTexture.Width / 2, ballTexture.Height / 2),
                    Vector2.One,
                    SpriteEffects.None,
                    0f
                    );

            _spriteBatch.End();
            base.Draw(gameTime);
        }
 
    }
}