using UnityEngine;

namespace Scripts
{
    public class GameStateMachine : MonoBehaviour
    {
        [SerializeField]
        GameLoop loop;
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