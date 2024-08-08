using UnityEngine;

namespace Scripts
{
    class GunScriptable : ScriptableObject
    {
        [SerializeField]
        private int _damage;
        [SerializeField]
        private float _reloadTime;
        [SerializeField]
        private DamageType _type;

        public int Damage { get { return _damage; } }
        public float ReloadTime { get { return _reloadTime; } }
        public DamageType Type { get { return _type; } }
    }
    enum DamageType
    {
        Physical,
        Fire,
        Ice
    }
}
