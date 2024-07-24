using UnityEngine;

namespace Scripts
{
    class InputMoveController: MoveController
    {
        private Vector2 _vectorZero = Vector2.zero;

        private void OnGUI()
        {
            if (Input.GetButtonDown("Jump"))
            {
                Jump();
            }
        }

        protected override void Jump()
        {
            if(_isGrounded)
            {
                _rb.AddForce(new Vector2(0, _jumpForce));
                _isGrounded = false;
            }
        }
        protected override void Move()
        {
            Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime * _speed, _rb.velocity.y);
            _rb.velocity = Vector2.SmoothDamp(_rb.velocity, targetVelocity, ref _vectorZero, 0.1f);
        }
    }
}
