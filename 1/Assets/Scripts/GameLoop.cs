using UnityEngine;

namespace Scripts
{
    class GameLoop : MonoBehaviour
    {
        [SerializeField]
        SpawnManager _spawnManager;

        void Start()
        {
            _spawnManager.CreateUnit(UnitType.Player);
        }
    }
}
