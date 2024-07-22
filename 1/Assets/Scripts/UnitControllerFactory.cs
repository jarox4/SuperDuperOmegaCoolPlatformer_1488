using UnityEngine;
using System;

namespace Scripts
{
    class UnitControllerFactory
    {
        PrefabsScriptable _prefabs;
        public UnitControllerFactory(PrefabsScriptable prefabs)
        {
            _prefabs = prefabs;
        }
        public GameObject CreateUnitLogic(UnitType type)
        {
            switch (type)
            {
                case UnitType.Player:
                    return UnityEngine.Object.Instantiate(_prefabs.prefab);
                case UnitType.Enemy:
                    return UnityEngine.Object.Instantiate(_prefabs.prefab);
                case UnitType.Ally:
                    return UnityEngine.Object.Instantiate(_prefabs.prefab);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
