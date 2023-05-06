using UnityEngine;
using FiniteStateMachine.Entities;

namespace FiniteStateMachine.States
{
	public class GameController : MonoBehaviour
	{

		[Header("Game Data")]
		[SerializeField] private float _tapLimitDuration = 0.2f;
    
		[Header("Dependencies")]
		[SerializeField] private Transform _playerUnitSpawnLocation;
		[SerializeField] private UnitSpawner _unitSpawner;

		public Transform PlayerUnitSpawnLocation => _playerUnitSpawnLocation;
		public UnitSpawner UnitSpawner => _unitSpawner;

		public GameObject WinText;
		public GameObject LoseText;
	}
}