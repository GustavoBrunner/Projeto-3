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
    private bool animationControl; //checará se o jogador recém passou por um trigger, se não, ele seguirá, se não, a câmera voltará
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
            //refazer o códigos: receber um evento somente, com um parâmetro, e fazer um switch com base no parâmetro
            //mais otimizado
            DoorTrigger.FirstDoorTriggerEntered += FirstAnimation;
            DoorTrigger.SecondDoorTriggerEntered += SecondAnimation;
            CameraTriggers.SideTriggerEntered += ThirdAnimation;
            CameraTriggers.SecondSideTriggerEntered += ForthAnimation;
        }
    }
    void FirstAnimation()
    {
        Debug.Log("evento de animação funcionando");
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
