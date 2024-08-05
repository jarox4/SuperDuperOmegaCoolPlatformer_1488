using UnityEngine;

namespace Scripts
{
    public class GameStateMachine : MonoBehaviour
    {
        [SerializeField]
        private GameLoop loop;
    }
}
public enum GameState
{
    Live,
    Pause,
    GameOver
}
public enum UnitType
{
    Player,
    Enemy,
    Ally
}