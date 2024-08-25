using System;
using UnityEngine;

namespace Scripts
{
    abstract class TransformController
    {
        protected Transform _transform;
        protected float _speed;
        protected Moveable _moveable;
        protected Rotateable _rotateable;

        public TransformController(Transform transform,float speed)
        {
            _transform = transform;
            _speed = speed;
            InitBehaviours();
        }

        protected abstract void InitBehaviours();
        public void Move()
        {
            _moveable.Move();
            _rotateable.Rotate();
        }
    }
}