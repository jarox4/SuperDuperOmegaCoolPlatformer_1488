using System;
using UnityEngine;

namespace Scripts
{
    class BulletTransformController : TransformController
    {
        public BulletTransformController(Transform transform, float speed) : base(transform, speed)
        {
        }

        protected override void InitBehaviours()
        {
            throw new System.NotImplementedException();
        }
    }
}
