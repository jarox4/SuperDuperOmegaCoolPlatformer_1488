using UnityEngine;

namespace Scripts
{
    class InputTransformController : TransformController
    {
        protected override void InitBehaviours()
        {
            _moveable = new InputMove(_speed, transform);
            _rotateable = new InputRotate(transform);
        }
    }
}
