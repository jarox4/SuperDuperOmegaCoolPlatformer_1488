using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "New Prefabs", menuName = "Prefab Data", order = 51)]
    class PrefabsScriptable : ScriptableObject
    {
        [SerializeField]
        private GameObject _playerPrefab;

        public GameObject PlayerPrefab { get { return _playerPrefab; } }
    }
}
