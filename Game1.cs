using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace dotnetagain;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    List<Sprite> sprites;

    Texture2D texture;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();

    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        sprites = new();
        Texture2D playerTexture = Content.Load<Texture2D>("player_static");
        Texture2D enemyTexture = Content.Load<Texture2D>("enemy");

        sprites.Add(new Sprite(enemyTexture, new Vector2(100, 100)));
        sprites.Add(new Sprite(enemyTexture, new Vector2(400, 200)));
        sprites.Add(new Sprite(enemyTexture, new Vector2(700, 300)));
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Space)){
                Console.WriteLine("Space key Pressed!");
            }


        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.MonoGameOrange);

        // TODO: Add your drawing code here
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

        _spriteBatch.Draw(texture, new Rectangle(100,100,100,200), Color.Red);

        _spriteBatch.End();
        base.Draw(gameTime);
    }
}
