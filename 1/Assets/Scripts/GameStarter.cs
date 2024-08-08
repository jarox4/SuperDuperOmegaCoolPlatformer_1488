using System.Linq.Expressions;
using UnityEngine;

namespace Scripts
{
    class GameStarter : MonoBehaviour
    {
        [SerializeField]
        private PrefabsScriptable _prefabs;
        private UnitControllerFactory _factory;
        private GameLoop _gameLoop;
        private GameStateMachine _gameStateMachine;

        private void Awake()
        {
            _factory = new UnitControllerFactory(_prefabs);
            _gameLoop = new GameLoop(_factory);
            _gameStateMachine = new GameStateMachine(_gameLoop);
        }
    }
}