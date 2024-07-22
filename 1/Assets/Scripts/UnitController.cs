using System;
using UnityEngine;

namespace Scripts
{
    abstract class UnitController : MonoBehaviour
    {
        [SerializeField]
        LayerMask _layerMask;
        [SerializeField]
        Transform _groundCheck;
        bool _isGrounded;
        public event Action OnUpdate;
        public event Action<float> OnFixedUpdate;
        public event Action Grounded;

        private void Update()
        {
            OnUpdate?.Invoke();
        }

        private void FixedUpdate()
        {
            OnFixedUpdate?.Invoke(Time.fixedDeltaTime);

            bool wasGrounded = _isGrounded;
            _isGrounded = false;
            Collider2D[] colliders = Physics2D.OverlapCircleAll(_groundCheck.position, 0.2f, _layerMask);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject != gameObject)
                {
                    _isGrounded = true;
                    if (!wasGrounded)
                        Grounded.Invoke();
                }
            }
        }
    }
}
