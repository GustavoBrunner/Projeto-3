using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameController : MonoBehaviour
{
    private bool FirstPuzzle = false,
        SecondPuzzle = false,
        ThirdPuzzle = false,
        ForthPuzzle = false,
        FifthPuzzle = false;

    public delegate void PuzzleHandler();

    public static event PuzzleHandler FirstPuzzleOpened;

    
    [SerializeField]
    private List<Transform> positions = new List<Transform>();

    private void Awake()
    {
        positions.AddRange(GameObject.FindGameObjectWithTag("PlaceHolders")
            .GetComponentsInChildren<Transform>());
        
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
