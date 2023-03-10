using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterTrigger: CameraTriggers
{

    protected override void Awake()
    {
        base.Awake();
    }
    void OnColliderEnter(Collider other)
    {
        //quando o jogador encostar no trigger, ele ligará os triggers das laterais
    }
}
