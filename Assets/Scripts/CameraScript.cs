using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public delegate void CameraMoveHandler(int x);
    public static event CameraMoveHandler CameraMove;
    private Vector3 target = new Vector3();
    Transform tf;
    float speed = 7f;
    private Animator camAnimator;
    private bool animationControl; //checar� se o jogador rec�m passou por um trigger, se n�o, ele seguir�, se n�o, a c�mera voltar�
    void Awake()
    {
        tf = GetComponent<Transform>();
        camAnimator = GetComponent<Animator>(); 
    }
    private void LateUpdate()
    {
        StartAnimation();
    }
    
    void StartAnimation()
    {
        if (camAnimator != null)
        {
            DoorTrigger.FirstDoorTriggerEntered += FirstAnimation;
            DoorTrigger.SecondDoorTriggerEntered += SecondAnimation;
            CameraTriggers.SideTriggerEntered += ThirdAnimation;
            CameraTriggers.SecondSideTriggerEntered += ForthAnimation;
            CameraTriggers.ThirdSideTriggerEntered += FifthAnimation;
            CameraTriggers.ForthSideTriggerEntered += SixthAnimation;
            CameraTriggers.FifthSideTriggerEntered += SeventhAnimation;
            CameraTriggers.SixthSideTriggerEntered += EighthAnimation;
        }
    }
    void FirstAnimation()
    {
        camAnimator.SetTrigger("FirstCamAnimationStart");
    }
    void SecondAnimation()
    {
        camAnimator.SetTrigger("SecondCamAnimationStart");
        if(CameraMove != null)
        {
            CameraMove(1);
        }
    }
    void ThirdAnimation()
    {
        camAnimator.SetTrigger("ThirdCamAnimationStart");
        
    }
    void ForthAnimation()
    {
        camAnimator.SetTrigger("ForthCamAnimationStart");
        if(CameraMove != null)
        {
            CameraMove(2);
        }
    }
    void FifthAnimation()
    {
        camAnimator.SetTrigger("FifthCamAnimationStart");
        
    }
    void SixthAnimation()
    {
        camAnimator.SetTrigger("SixthCamAnimationStart");
        if(CameraMove != null)
        {
            CameraMove(3);
        }
    }
    void SeventhAnimation()
    {
        camAnimator.SetTrigger("SeventhCamAnimationStart");
    }
    void EighthAnimation()
    {
        camAnimator.SetTrigger("EighthCamAnimationStart");
        if (CameraMove != null)
        {
            CameraMove(0);
        }
    }
}
