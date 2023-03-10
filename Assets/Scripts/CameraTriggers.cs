using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : ObjectsScript
{
    
    public delegate void SideTriggersHandler();
    protected Collider clldr;
    protected List<CameraTriggers> triggers = new List<CameraTriggers>();

    public static event SideTriggersHandler SideTriggerEntered;
    public static event SideTriggersHandler SecondSideTriggerEntered;
    public static event SideTriggersHandler ThirdSideTriggerEntered;
    public static event SideTriggersHandler ForthSideTriggerEntered;
    public static event SideTriggersHandler FifthSideTriggerEntered;
    public static event SideTriggersHandler SixthSideTriggerEntered;
    public static event SideTriggersHandler SeventhSideTriggerEntered;


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
        //Respons�vel por ligar todos os triggers da c�mera
        gameObject.SetActive(true);
    }
    protected virtual void TurnObjectOff()
    {
        //Respons�vel por desligar todos os triggers da c�mera
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
        //Verifica qual que � o side trigger que foi entrado pelo player, e voltar� a navega��o de acordo
        if(other.gameObject.tag == "Player")
        {
            switch (this.gameObject.name)
            {
                case "SideTrigger3":
                    if(ThirdSideTriggerEntered != null)
                    {
                        ThirdSideTriggerEntered();
                    }
                    break;
                case "SideTrigger4":
                    if(ForthSideTriggerEntered != null)
                    {
                        ForthSideTriggerEntered();
                    }
                    break;
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
                case "SideTrigger5":
                    if(FifthSideTriggerEntered != null)
                    {
                        FifthSideTriggerEntered();
                    }
                    break;
                case "SideTrigger6":
                    if(SixthSideTriggerEntered != null)
                    {
                        SixthSideTriggerEntered();
                    }
                    break;
                case "SideTrigger7":
                    if(SeventhSideTriggerEntered != null)
                    {
                        SeventhSideTriggerEntered();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
