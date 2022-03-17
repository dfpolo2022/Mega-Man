using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameState _gameState = GameState.start;

    public void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(GameState gameState)
    {
        _gameState = gameState;
    }

    // Update is called once per frame
    void Update()
    {
        switch (_gameState)
        {
            case GameState.start:
                break;

            case GameState.play:
                break;

            case GameState.end:
                break;
        }
    }

    public enum GameState
    {
        start,
        play, 
        end
    }
}
