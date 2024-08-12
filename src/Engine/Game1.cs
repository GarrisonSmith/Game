﻿using Engine.Core.Initialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Engine
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		public Game1()
		{
			this._graphics = new GraphicsDeviceManager(this);
			this.Content.RootDirectory = "Content";
			this.IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			_ = ServiceInitializer.InitializeServices(this);

			base.Initialize();
		}

		protected override void LoadContent()
		{
			this._spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			{
				Exit();
			}

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			this.GraphicsDevice.Clear(Color.CornflowerBlue);

			// TODO: Add your drawing code here

			base.Draw(gameTime);
		}
	}
}
