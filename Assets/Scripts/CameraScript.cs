using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Vector3 target = new Vector3();
    Transform tf;
    float speed = 7f;
    [SerializeField]
    private List<Transform> positions = new List<Transform>();
    void Awake()
    {
        positions.AddRange(GameObject.FindGameObjectWithTag("PlaceHolders")
            .GetComponentsInChildren<Transform>());
        tf = GetComponent<Transform>();
        DoorTrigger.FirstDoorTriggerEntered += SideScrollCamera;
        DoorTrigger.SecondDoorTriggerEntered += SideScrollCamera;
        CameraTriggers.SideTriggerEntered += SideScrollCamera;
       
    }
    void SideScrollCamera(int _i)
    {
        //Código para mover a câmera para o segundo lugar da casa. 
        target.x = positions[_i].position.x;
        target.y = transform.position.y;
        target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(tf.transform.position, target, Time.deltaTime *speed);
    }

}
