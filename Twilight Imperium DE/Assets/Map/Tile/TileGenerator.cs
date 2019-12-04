using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    public Tile tileObject;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void GenerateTiles()
    {
        Vector3 startingPos = new Vector3(0, 0, 0);

        Tile centerTile = GameObject.Instantiate(tileObject);
        centerTile.transform.position = startingPos;
        double hexWidth = centerTile.GetParallelWidth() / 2;
        double hexHeight = centerTile.GetPointWidth() * 0.75;

        Debug.Log($"hexWidth = {hexWidth}");
        Debug.Log($"hexHeight = {hexHeight}");

        Tile testTile = GameObject.Instantiate(tileObject);
        testTile.transform.position = new Vector3(startingPos.x + (float)hexWidth, startingPos.y + (float)hexHeight, 0);

        //for (int i = 0; i < 5; i++)
        //{

        //}
    }


    public void Awake()
    {
        GenerateTiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
