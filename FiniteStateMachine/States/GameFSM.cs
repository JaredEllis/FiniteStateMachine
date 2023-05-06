using UnityEngine;

namespace FiniteStateMachine.States
{
	[RequireComponent(typeof(GameController))]
	public class GameFSM : StateMachineMB
	{
		private GameController _controller;
		public GameSetupState SetupState { get; private set; }
		public GamePlayState PlayState { get; private set; }
		public GameWinState WinState { get; private set; }
		public GameLoseState LoseState { get; private set; }
    
		// Start is called before the first frame update
		void Awake()
		{
			_controller = GetComponent<GameController>();
			SetupState = new GameSetupState(this, _controller);
			PlayState = new GamePlayState(this, _controller);
			WinState = new GameWinState(this, _controller);
			LoseState = new GameLoseState(this, _controller);
		}

		private void Start()
		{
			ChangeState(SetupState);
		}
	}
}