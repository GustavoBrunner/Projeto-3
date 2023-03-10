using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdRoomSideTrigger : CameraTriggers
{
    protected override void Awake()
    {
        base.Awake();
        CameraTriggers.CenterTriggerEntered += ShowTriggers;
        DoorTrigger.SecondDoorTriggerEntered += HideTrigger;
    }

    void ShowTriggers(int x)
    {
        //faz somente o gameobject desse trigger aparecer, ao encostar no trigger central do terceiro c�modo
        this.gameObject.SetActive(true);
    }
    void HideTrigger(int x)
    {
        //faz somente o gameobject desse trigger sumir, ao encostar no trigger da segunda porta
        this.gameObject.SetActive(false);
    }
}
