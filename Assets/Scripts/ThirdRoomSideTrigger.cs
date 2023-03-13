using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdRoomSideTrigger : CameraTriggers
{
    protected override void Awake()
    {
        base.Awake();
        //CameraTriggers.CenterTriggerEntered += ShowTriggers;
        //DoorTrigger.SecondDoorTriggerEntered += HideTrigger;
    }

    void ShowTriggers()
    {
        //faz somente o gameobject desse trigger aparecer, ao encostar no trigger central do terceiro cômodo
        this.gameObject.SetActive(true);
    }
    void HideTrigger()
    {
        //faz somente o gameobject desse trigger sumir, ao encostar no trigger da segunda porta
        this.gameObject.SetActive(false);
    }
}
