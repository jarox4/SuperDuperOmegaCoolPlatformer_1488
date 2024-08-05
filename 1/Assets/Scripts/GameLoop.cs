using UnityEngine;

namespace Scripts
{
    class GameLoop : MonoBehaviour
    {
        [SerializeField]
        private SpawnManager _spawnManager;

        void Start()
        {
            _spawnManager.CreateUnit(UnitType.Player);
        }
    }
}
