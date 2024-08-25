using UnityEngine;

namespace Scripts
{
    class GameStateMachine
    {
        private GameLoop _loop;

        public GameStateMachine(GameLoop loop)
        {
            _loop = loop;
        }
    }
}
public enum GameState
{
    Live,
    Pause,
    GameOver
}