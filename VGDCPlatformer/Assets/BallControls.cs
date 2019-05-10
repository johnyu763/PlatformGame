using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour
{
    public GameObject player;
    public GameObject board;

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
        player.transform.position = new Vector3(0.0f, 30.0f, 0.0f);
        player.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
        player.GetComponent<Rigidbody>().angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        board.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        board.transform.rotation = Quaternion.identity;
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
