using UnityEngine;

namespace Scripts
{
    class GameLoop
    {
        private UnitControllerFactory _controllerFactory;

        public GameLoop(UnitControllerFactory controllerFactory)
        {
            _controllerFactory = controllerFactory;
            _controllerFactory.CreateUnitController(UnitType.Player);
        }
    }
}
