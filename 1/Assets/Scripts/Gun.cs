using UnityEditor.Media;
using UnityEngine;

namespace Scripts
{
    class Gun : MonoBehaviour
    {
        [SerializeField]
        private GunScriptable _gunScriptable;
        [SerializeField]
        private BulletTransformController _bulletPrefab;
        private float _lastShotTime;

        private void Awake()
        {
            _lastShotTime = 0;
        }

        private void Shoot()
        {
            //Instantiate(_bulletPrefab).transform.rotation = transform.rotation;
        }
        public void TryShoot(Vector3 direction)
        {
            if (_lastShotTime + _gunScriptable.ReloadTime > Time.time)
            {
                return;
            }
            else
            {
                Shoot();
                _lastShotTime = Time.time;
            }
        }
    }
}
