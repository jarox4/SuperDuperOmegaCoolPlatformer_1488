using UnityEngine;

namespace Scripts
{
    abstract class Rotateable
    {
        protected Transform _transform;
        protected Camera _camera;

        public Rotateable(Transform transform)
        {
            _transform = transform;
            _camera = Camera.main;
        }

        public abstract void Rotate();
    }
}
