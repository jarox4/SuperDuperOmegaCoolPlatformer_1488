using UnityEngine;

namespace Scripts
{
    class SpawnManager : MonoBehaviour
    {
        [SerializeField]
        PrefabsScriptable _prefabScriptabe;
        UnitControllerFactory _unitControllerFactory;
        void Awake()
        {
            _unitControllerFactory = new UnitControllerFactory(_prefabScriptabe);
        }

        public void CreateUnit(UnitType type)
        {
            _unitControllerFactory.CreateUnitLogic(type);
        }
    }
}
