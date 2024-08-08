using System;
using UnityEngine;

namespace Scripts
{
    abstract class TransformController: MonoBehaviour
    {
        [SerializeField]
        protected float _speed;
        protected Moveable _moveable;
        protected Rotateable _rotateable;

        private void Awake()
        {
            InitBehaviours();
        }

        protected abstract void InitBehaviours();
        private void FixedUpdate()
        {
            _moveable.Move();
            _rotateable.Rotate();
        }
    }
}