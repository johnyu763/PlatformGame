using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject thing = GameObject.FindWithTag("ball");

    private Vector3 offset;

    void Start()
    {
        //anim = GameObject.FindWithTag("Player").GetComponent<Animator>();
        offset = transform.position - thing.transform.position;
    }

    void LateUpdate()
    {
        transform.position = thing.transform.position + offset;
    }
}