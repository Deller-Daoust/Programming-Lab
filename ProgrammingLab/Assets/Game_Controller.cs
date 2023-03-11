using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    public enum GameState { Ready = 2, Playing = 4, Pause = 6, GameOver = 3};
    public GameState state;

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Playing;
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case GameState.Ready:
                Debug.Log((int)GameState.Ready);
                break;
            case GameState.Playing:
                Debug.Log((int)GameState.Playing);
                break;
            case GameState.Pause:
                Debug.Log((int)GameState.Pause);
                break;
            case GameState.GameOver:
                Debug.Log((int)GameState.GameOver);
                break;
        }
    }
}
