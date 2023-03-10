using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FristDoorTrigger : DoorTrigger
{
    protected override void Awake()
    {
        base.Awake();
        CameraTriggers.SideTriggerEntered += HideTrigger;
        CameraTriggers.CenterTriggerEntered += ShowTrigger;
    }

    void HideTrigger(int x)
    {
        this.gameObject.SetActive(false);
    }
    void ShowTrigger(int x)
    {
        this.gameObject.SetActive(true);
    }
}
