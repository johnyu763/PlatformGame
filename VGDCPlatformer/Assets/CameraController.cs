using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public GameObject board;
    private Vector3 offset;
    private Rigidbody rb;

    void Start()
    {
        offset = transform.position - player.transform.position;
        rb = player.gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        Vector3 velocity = rb.velocity.normalized;
        float angle = Mathf.Atan2(velocity.x, velocity.z);
        transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, Mathf.Rad2Deg * angle, transform.localEulerAngles.z);
        transform.position = player.transform.position + offset;
    }

}