using System;
using UnityEngine;

namespace Scripts
{
    class InputTransformController : TransformController
    {
        public InputTransformController(Transform transform, float speed) : base( transform, speed)
        {
        }

        protected override void InitBehaviours()
        {
            _moveable = new InputMove(_speed, _transform);
            _rotateable = new InputRotate(_transform);
        }
    }
}
