using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirtsPuzzleObject : ObjectsScript, IInteractable
{
    
    

    private string[] puzzleText;
    protected override void Awake()
    {
        base.Awake();
        GameController.FirstPuzzleOpened += TurnInteractionOn;
    }
    public void HighLightItem()
    {
        //C�digo que far� com que esse objeto receba um highlight na tela
        Debug.Log("Player se aproximou do objeto");
    }

    public void Interact()
    {
        //C�digo que far� o item fazer algo ao ser interagido.
        Debug.Log("Player interagiu com o objeto");
    }

    public void TurnInteractionOn()
    {
        //far� com que a Intera��o dos objetos seja ativada
        cllidr.enabled = true;
        Debug.Log("Intera��o ligada");
    }
}
