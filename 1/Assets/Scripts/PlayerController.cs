using Unity;
using UnityEngine;
namespace Scripts
{
    class PlayerController : UnitController
    {
        protected override void InitBehaviours()
        {
            var test = gameObject.transform;
            _transformController = new InputTransformController(gameObject.transform, _speed);
        }
    }
}
