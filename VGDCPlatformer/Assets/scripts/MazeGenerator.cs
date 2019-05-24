using UnityEngine;
using System.Collections;

public class MazeGenerator : MonoBehaviour
{

    public Maze mazePrefab;

    private Maze mazeInstance;

    private void Awake()
    {
        BeginGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
    }

    private void BeginGame()
    {
        mazeInstance = Instantiate(mazePrefab) as Maze;
        StartCoroutine(mazeInstance.Generate());
        //Instantiate(Resources.Load("Actual Ball We Should use"), new Vector3(-9.5f, 200, 9.5f), Quaternion.identity);
        //-9.5,0,9.5
    }

    private void RestartGame()
    {
        StopAllCoroutines();
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}