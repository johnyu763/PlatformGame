using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Reset();
        }
        else if (Input.GetKeyDown("a"))
        {
            Brake();
        }
        else if (Input.GetKeyDown("w"))
        {
            Quick();
        }
    }

    private void Reset()
    {
        player.transform.position = new Vector3(-4.5f, 5, 4.5f);
        player.transform.rotation = Quaternion.identity;
        player.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
        player.GetComponent<Rigidbody>().angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
    }

    private void Brake()
    {
        player.GetComponent<Rigidbody>().drag += 1;
    }

    private void Quick()
    {
        player.GetComponent<Rigidbody>().drag -= 1;
    }
}
