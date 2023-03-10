using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecRoomSideTriggers : CameraTriggers
{
    protected override void Awake()
    {
        base.Awake();
        gameObject.SetActive(false);
        CameraTriggers.CenterTriggerEntered += ShowAllTrigger;
        DoorTrigger.FirstDoorTriggerEntered += HideTrigger;
    }
    void ShowAllTrigger(int x)
    {
        this.gameObject.SetActive(true);
    }
    void HideTrigger(int x)
    {
        this.gameObject.SetActive(false);
    }
}
