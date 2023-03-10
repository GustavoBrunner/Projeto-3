using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectsScript : MonoBehaviour
{
    protected Transform tf;
    protected string name;
    protected Vector3 IntancePosition;
    protected Quaternion IntanceRotation;
    protected Collider cllidr;

    protected virtual void Awake()
    {
        tf = GetComponent<Transform>(); 
        cllidr = GetComponent<Collider>();
        //cllidr.enabled = false;
        cllidr.isTrigger = true;
        cllidr.enabled = false;
    }

    
}
