using System;
using UnityEngine;

namespace Scripts
{
    class PlayerController : UnitController
    {
        [SerializeField]
        float _speed, _jumpForce;
        InputMoveController inputController;
        public event Action Jump;

        void Awake()
        {
            inputController = new InputMoveController(GetComponent<Rigidbody2D>(), _speed, _jumpForce, this);
        }
        private void OnGUI()
        {
            if (Input.GetButtonDown("Jump"))
            {
                Jump?.Invoke();
            }
        }
    }
}
