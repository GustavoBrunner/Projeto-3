using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoorTrigger : DoorTrigger
{
    protected override void Awake()
    {
        base.Awake();
        //DoorTrigger.SideTriggerEntered += HideTrigger;
        // CameraTriggers.CenterTriggerEntered += ShowTrigger;
    }
    void ShowTrigger()
    {
        this.gameObject.SetActive(true);
    }
    void HideTrigger()
    {
        this.gameObject.SetActive(false);
    }
}
