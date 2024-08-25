using UnityEngine;
using System;

namespace Scripts
{
    class UnitControllerFactory
    {
        private PrefabsScriptable _prefabs;
        public UnitControllerFactory(PrefabsScriptable prefabs)
        {
            _prefabs = prefabs;
        }
        public GameObject CreateUnitController(UnitType type)
        {
            switch (type)
            {
                case UnitType.Player:
                    return UnityEngine.Object.Instantiate(_prefabs.PlayerPrefab);
                case UnitType.Enemy:
                    return UnityEngine.Object.Instantiate(_prefabs.PlayerPrefab);
                case UnitType.Ally:
                    return UnityEngine.Object.Instantiate(_prefabs.PlayerPrefab);
                default:
                    throw new NotImplementedException();
            }
        }
    }
    public enum UnitType
    {
        Player,
        Enemy,
        Ally
    }
}
