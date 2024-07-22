using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "New Prefabs", menuName = "Prefab Data", order = 51)]
    class PrefabsScriptable : ScriptableObject
    {
        [SerializeField] public GameObject prefab;
    }
}
