using UnityEngine;

namespace Scripts
{
    class InputRotate : Rotateable
    {
        public InputRotate(Transform transform) : base(transform) { }

        public override void Rotate()
        {
            Vector3 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
            Vector3 rotation = mousePos - _transform.position;
            float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            _transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }
    }
}
