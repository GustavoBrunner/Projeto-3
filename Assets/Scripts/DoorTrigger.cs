using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : CameraTriggers
{
    public delegate void DoorTriggerHandler(int i);

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

    void OnTriggerStay(Collider other)
    {
        //verificará o nome do trigger atual, e disparará um evento de acordo
        if(other.gameObject.tag == "Player")
        {
            
            switch (this.gameObject.name)
            {
                case "DoorTrigger1":
                    if(FirstDoorTriggerEntered != null)
                    {
                        FirstDoorTriggerEntered(2);
                        Debug.Log("Evento Disparado");
                    }
                    break;
                case "DoorTrigger2":
                    if(SecondDoorTriggerEntered != null)
                    {
                        SecondDoorTriggerEntered(3);
                        Debug.Log("Evento Disparado");
                    }
                    break;
                case "DoorTrigger3":
                    if(ThirdDoorTriggerEntered != null)
                    {
                        ThirdDoorTriggerEntered(4);
                        Debug.Log("Evento Disparado");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
