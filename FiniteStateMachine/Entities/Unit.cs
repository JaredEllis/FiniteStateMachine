using UnityEngine;
using FiniteStateMachine.States;

namespace FiniteStateMachine.Entities
{
	public class Unit : MonoBehaviour
	{
		private GameFSM _stateMachine;
		
		public Rigidbody2D rb;
    
		private GameController _controller;

		private void Awake()
		{
			_stateMachine = FindObjectOfType<GameFSM>();
			_controller = FindObjectOfType<GameController>();
		}
	}
}