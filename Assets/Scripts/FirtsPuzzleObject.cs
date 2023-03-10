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
        //Código que fará com que esse objeto receba um highlight na tela
        Debug.Log("Player se aproximou do objeto");
    }

    public void Interact()
    {
        //Código que fará o item fazer algo ao ser interagido.
        Debug.Log("Player interagiu com o objeto");
    }

    public void TurnInteractionOn()
    {
        //fará com que a Interação dos objetos seja ativada
        cllidr.enabled = true;
        Debug.Log("Interação ligada");
    }
}
