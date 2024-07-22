using UnityEngine;

namespace Scripts
{
    class InputMoveController
    {
        Rigidbody2D _rb;
        float _speed, _jumpForce;
        bool _isGrounded = false;
        Vector3 _vectorZero = Vector3.zero;

        public InputMoveController(Rigidbody2D rb, float speed, float jumpForce, PlayerController controller) 
        {
            _rb = rb;
            _speed = speed;
            _jumpForce = jumpForce;
            controller.Grounded += OnGround;
            controller.OnFixedUpdate += OnUpdate;
            controller.Jump += OnJump;
        }

        private void OnGround()
        {
            _isGrounded = true;
        }

        private void OnJump()
        {
            if(_isGrounded)
            {
                _rb.AddForce(new Vector2(0, _jumpForce));
                _isGrounded = false;
            }
        }

        void OnUpdate(float fixedDeltaTime)
        {
            Vector3 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal") * fixedDeltaTime * _speed, _rb.velocity.y);
            _rb.velocity = Vector3.SmoothDamp(_rb.velocity, targetVelocity, ref _vectorZero, 0.1f);
        }
    }
}
