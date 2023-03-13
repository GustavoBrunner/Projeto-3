using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : CameraTriggers
{
    public delegate void DoorTriggerHandler();

    public static event DoorTriggerHandler FirstDoorTriggerEntered;
    public static event DoorTriggerHandler SecondDoorTriggerEntered;
    public static event DoorTriggerHandler ThirdDoorTriggerEntered;

    protected override void Awake()
    {
        base.Awake();
    }
    protected override void TurnObjectOn()
    {
        base.TurnObjectOn();
    }
    protected override void TurnObjectOff()
    {
        base.TurnObjectOff();
    }

    void OnTriggerEnter(Collider other)
    {
        //verificará o nome do trigger atual, e disparará um evento de acordo
        if(other.gameObject.tag == "Player")
        {
            
            switch (this.gameObject.name)
            {
                case "DoorTrigger1":
                    if(FirstDoorTriggerEntered != null)
                    {
                        FirstDoorTriggerEntered();
                        Debug.Log("Evento Disparado");
                    }
                    break;
                case "DoorTrigger2":
                    if(SecondDoorTriggerEntered != null)
                    {
                        SecondDoorTriggerEntered();
                        Debug.Log("Evento Disparado");
                    }
                    break;
                case "DoorTrigger3":
                    if(ThirdDoorTriggerEntered != null)
                    {
                        ThirdDoorTriggerEntered();
                        Debug.Log("Evento Disparado");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
