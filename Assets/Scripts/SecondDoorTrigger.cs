using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoorTrigger : DoorTrigger
{
    protected override void Awake()
    {
        base.Awake();
        DoorTrigger.SideTriggerEntered += HideTrigger;
        CameraTriggers.CenterTriggerEntered += ShowTrigger;
    }
    void ShowTrigger(int x)
    {
        this.gameObject.SetActive(true);
    }
    void HideTrigger(int x)
    {
        this.gameObject.SetActive(false);
    }
}
