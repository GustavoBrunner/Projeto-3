using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool FirstPuzzle = false,
        SecondPuzzle = false,
        ThirdPuzzle = false,
        ForthPuzzle = false,
        FifthPuzzle = false;

    public delegate void PuzzleHandler();

    public static event PuzzleHandler FirstPuzzleOpened;


    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) )
        {
            FirstPuzzle = true;
            if(FirstPuzzleOpened != null && FirstPuzzle)
            {
                FirstPuzzleOpened();
            }
        }
    }
    
}
