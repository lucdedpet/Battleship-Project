
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;
using MyGame;
//using GameController;
//using UtilityFunctions;
//using GameResources;
//using DeploymentController;
//using DiscoveryController;
//using EndingGameController;
//using MenuController;
//using HighScoreController;

namespace MyGame
{
	public class GameMain
	{
		public static void Main(string[] args)
		{
			//Opens a new Graphics Window
			SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

			//Load Resources
			GameResources.LoadResources();

			SwinGame.PlayMusic(GameResources.GameMusic("Background"));

			//Game Loop
			do {
				GameController.HandleUserInput();
				GameController.DrawScreen();
			} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

			SwinGame.StopMusic();

			//Free Resources and Close Audio, to end the program.
			GameResources.FreeResources();
		}
	}
}