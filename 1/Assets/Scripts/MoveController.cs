using System;
using UnityEngine;

namespace Scripts
{
    public abstract class MoveController: MonoBehaviour
    {
        [SerializeField]
        protected float _speed, _jumpForce;
        private const float _groundCheckRadius = 0.2f;

        [SerializeField]
        private LayerMask _groundLayerMask;
        [SerializeField]
        private Transform _groundCheck;

        protected bool _isGrounded;
        protected Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        protected virtual void FixedUpdate()
        {
            CheckIfOnGround();
            Move();
        }
        private void CheckIfOnGround()
        {
            bool wasGrounded = _isGrounded;
            _isGrounded = false;
            Collider2D[] colliders = Physics2D.OverlapCircleAll(_groundCheck.position, _groundCheckRadius, _groundLayerMask);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject != gameObject)
                {
                    _isGrounded = true;
                }
            }
        }
        protected abstract void Move();
        protected abstract void Jump();
    }
}