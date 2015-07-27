#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

#endregion

namespace AgentWindy
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		Texture2D agentTex,DragonTex,helthMushroomTex, poisonMushroomTex, fireballTex, bulletTex, backgroundTex;
		SpriteFont life, timeLeft, counDown;

		Texture2D startScreen, gameOverScreen, youWonScreen;


		public Game1 ()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";			
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize ()
		{
			// TODO: Add your initialization logic here
			base.Initialize ();
				
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch (GraphicsDevice);

			life = Content.Load<SpriteFont> ("Fonts\\ControlFont");
			counDown = Content.Load<SpriteFont> ("Fonts\\BigControlFont");
		


			agentTex = Content.Load<Texture2D>("Textures\\windy");
			DragonTex = Content.Load<Texture2D>("Textures\\dragon");
			helthMushroomTex = Content.Load<Texture2D>("Textures\\healthy_mushroom");
			poisonMushroomTex = Content.Load<Texture2D>("Textures\\poisonus_mushroom");
			fireballTex = Content.Load<Texture2D>("Textures\\fireball");
			bulletTex = Content.Load<Texture2D>("Textures\\bullet");
			backgroundTex = Content.Load<Texture2D>("Textures\\background");

			startScreen = Content.Load<Texture2D>("Screens\\start");
			gameOverScreen = Content.Load<Texture2D>("Screens\\go");
			youWonScreen = Content.Load<Texture2D>("Screens\\won");

		}

		protected override void Update (GameTime gameTime)
		{
			// For Mobile devices, this logic will close the Game when the Back button is pressed
			// Exit() is obsolete on iOS
			#if !__IOS__
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
			    Keyboard.GetState ().IsKeyDown (Keys.Escape)) {
				Exit ();
			}
			#endif
			// TODO: Add your update logic here			
			base.Update (gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.CornflowerBlue);
		
			//TODO: Add your drawing code here
            
			base.Draw (gameTime);
		}
	}
}

