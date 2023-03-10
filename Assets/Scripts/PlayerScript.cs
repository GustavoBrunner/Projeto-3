using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    private float Vertical;
    private float Horizontal;
    private Vector3 direction;
    private float speed = 5f;
    private bool CanMove;
    private float RoomTransitionTime = 3f;

    //------------------------------------------------
    //puzzles
    public delegate void FirstPuzzleItemInteraction();

    public static event FirstPuzzleItemInteraction OnFirstPuzzleItemInteracted;
    public static event FirstPuzzleItemInteraction OnFirstPuzzlePickedUp;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //rb.useGravity = false;
        rb.freezeRotation = true;
        gameObject.tag = "Player";
        CanMove = true;
        DoorTrigger.FirstDoorTriggerEntered += StopMoving;
        DoorTrigger.SecondDoorTriggerEntered += StopMoving;
        CameraTriggers.SideTriggerEntered += StopMoving;

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        //Responsável por fazer o jogador se mover pelo mapa
        if(CanMove)
        {
            Vertical = Input.GetAxis("Vertical");
            Horizontal = Input.GetAxis("Horizontal");
            direction = new Vector3(Horizontal, 0f, Vertical);
            rb.velocity = direction * speed;
        }
    }
    private void StopMoving(int _i)
    {
        //Responsável por trocar o valor bool da variável de movimentação durante a transição de cômodo
        rb.velocity = Vector3.zero;
        StartCoroutine(Transition());
    }
    private IEnumerator Transition()
    {
        //pausa a movimentação do personagem enquanto a transição de tela está ocorrendo
        CanMove = false;
        yield return new WaitForSeconds(RoomTransitionTime);
        CanMove = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
        if(interactable != null)
        {
            interactable.HighLightItem();
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Teste");
                interactable.Interact();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
        if (interactable != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interactable.Interact();
            }
        }
    }
}
