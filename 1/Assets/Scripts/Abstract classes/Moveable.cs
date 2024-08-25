using UnityEngine;

namespace Scripts
{
    abstract class Moveable
    {
        protected const float _diagonalSlow = 0.75f;
        protected float _speed, _currSpeed;
        protected Transform _transform;

        public Moveable(float speed, Transform transform)
        {
            _speed = speed;
            _currSpeed = _speed;
            _transform = transform;
        }

        public abstract void Move();
    }
}
