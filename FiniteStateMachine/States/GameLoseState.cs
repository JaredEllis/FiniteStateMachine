using UnityEngine;

namespace FiniteStateMachine.States
{
	public class GameLoseState : State
	{
		private GameFSM _stateMachine;
		private GameController _controller;

		public GameLoseState(GameFSM stateMachine, GameController controller)
		{
			_stateMachine = stateMachine;
			_controller = controller;
		}
    
		public override void Enter()
		{
			base.Enter();
        
			Debug.Log("STATE: Lose");
			_controller.LoseText.SetActive(true);
		}

		public override void Exit()
		{
			base.Exit();
		}

		public override void FixedTick()
		{
			base.FixedTick();
		}

		public override void Tick()
		{
			base.Tick();
		}
	}
}