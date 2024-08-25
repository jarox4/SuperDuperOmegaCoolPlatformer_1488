using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Scripts
{
    abstract class UnitController : MonoBehaviour
    {
        [SerializeField]
        protected float _speed;

        protected TransformController _transformController;

        protected abstract void InitBehaviours();
        private void Awake()
        {
            InitBehaviours();
        }
        private void FixedUpdate()
        {
            _transformController.Move();
        }
    }
}
