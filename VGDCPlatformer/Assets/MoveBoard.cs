using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoard : MonoBehaviour
{
    Maze maze; 
    public GameObject board;
    float startX = Screen.width/2;
    float startY = Screen.height/2 - 200;
    private void Start()
    {
        maze = board.GetComponent<Maze>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!maze.finishSpawning)
        {
            return; 
        }
        if (Input.GetKeyDown("r"))
        {
            Reset();
        }
        float newX = Input.GetAxis("Mouse X") * Time.deltaTime * 20;
        float newY = Input.GetAxis("Mouse Y") * Time.deltaTime * 20;

        if (newX != startX && newY != startY)
        {
            board.transform.Rotate(-newY, newX, 0);
        }
    }
    void Reset()
    {
        board.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        board.transform.rotation = Quaternion.identity;
    }
}
