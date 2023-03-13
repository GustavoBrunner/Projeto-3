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
            //refazer o c�digos: receber um evento somente, com um par�metro, e fazer um switch com base no par�metro
            //mais otimizado
            DoorTrigger.FirstDoorTriggerEntered += FirstAnimation;
            DoorTrigger.SecondDoorTriggerEntered += SecondAnimation;
            CameraTriggers.SideTriggerEntered += ThirdAnimation;
            CameraTriggers.SecondSideTriggerEntered += ForthAnimation;
        }
    }
    void FirstAnimation()
    {
        Debug.Log("evento de anima��o funcionando");
        camAnimator.SetTrigger("FirstCamAnimationStart");
    }
    void SecondAnimation()
    {
        camAnimator.SetTrigger("SecondCamAnimationStart");
        if(CameraMove != null)
        {
            CameraMove(1);
            Debug.Log("mudando instancia de movimento");
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
}
