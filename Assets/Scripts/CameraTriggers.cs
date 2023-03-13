using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : ObjectsScript
{
    
    public delegate void SideTriggersHandler();
    protected Collider clldr;
    protected List<CameraTriggers> triggers = new List<CameraTriggers>();

    public static event SideTriggersHandler SideTriggerEntered;
    public static event SideTriggersHandler ThirdSideTriggerEntered;
    public static event SideTriggersHandler SecondSideTriggerEntered;

    protected override void Awake()
    {
        base.Awake();
        clldr = GetComponent<Collider>();
        clldr.isTrigger = true;
        triggers.AddRange(GetComponentsInChildren<CameraTriggers>());
        clldr.enabled = true;
        //TurnAllOff();
    }
    protected virtual void TurnObjectOn()
    {
        //Responsável por ligar todos os triggers da câmera
        gameObject.SetActive(true);
    }
    protected virtual void TurnObjectOff()
    {
        //Responsável por desligar todos os triggers da câmera
        gameObject.SetActive(false);
    }
    protected void TurnAllOff()
    {
        //Desliga todos os triggers ao iniciar a fase
        foreach (var trigger in triggers)
        {
            if(this.gameObject.name != "DoorTrigger1")
            {
                TurnObjectOff();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Verifica qual que é o side trigger que foi entrado pelo player, e voltará a navegação de acordo
        if(other.gameObject.tag == "Player")
        {
            switch (this.gameObject.name)
            {
                case "TriggerCenter1":
                    if(ThirdSideTriggerEntered != null)
                    {
                        ThirdSideTriggerEntered();
                    }
                    break;
                //case "TriggerCenter0":
                //    if(CenterTriggerEntered != null)
                //    {
                //        CenterTriggerEntered();
                //    }
                //    break;
                case "SideTrigger1":
                    if(SideTriggerEntered != null)
                    {
                        SideTriggerEntered();
                    }
                    break;
                case "SideTrigger2":
                    if (SecondSideTriggerEntered != null)
                    {
                        SecondSideTriggerEntered();
                    }
                    break;
                //case "TriggerCenter2":
                //    if(CenterTriggerEntered != null)
                //    {
                //        CenterTriggerEntered();
                //        Debug.Log("evento disparado");
                //    }
                //    break;
                default:
                    break;
            }
        }
    }
}
