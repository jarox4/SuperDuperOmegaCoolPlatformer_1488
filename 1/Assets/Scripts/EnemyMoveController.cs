using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    class EnemyMoveController : TransformController
    {
        public EnemyMoveController(Transform transform, float speed) : base(transform, speed)
        {

        }
        protected override void InitBehaviours()
        {
            throw new System.NotImplementedException();
        }
    }
}