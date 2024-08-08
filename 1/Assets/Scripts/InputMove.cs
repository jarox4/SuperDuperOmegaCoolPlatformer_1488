using UnityEngine;

namespace Scripts
{
    class InputMove : Moveable
    {
        public InputMove(float speed, Transform transform) : base(speed, transform) { }

        public override void Move() 
        {
            Vector2 startPos = _transform.position;
            Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if (direction.x != 0 && direction.y != 0)
            {
                _currSpeed = _speed * _diagonalSlow;
            }
            else
            {
                _currSpeed = _speed;
            }
            _transform.position = new Vector2(startPos.x + (direction.x * _currSpeed * Time.fixedDeltaTime), startPos.y + (direction.y * _currSpeed * Time.fixedDeltaTime));
        }
    }
}
