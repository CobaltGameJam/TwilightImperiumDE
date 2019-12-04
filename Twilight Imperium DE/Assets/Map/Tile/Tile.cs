using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }


    public double GetParallelWidth()
    {
        MeshFilter filter = GetComponent<MeshFilter>();
        var bounds = filter.mesh.bounds;
        double pWidth = bounds.max.x - bounds.min.x;
        return pWidth;
    }

    public double GetPointWidth()
    {
        MeshFilter filter = GetComponent<MeshFilter>();
        var bounds = filter.mesh.bounds;
        double pWidth = bounds.max.z - bounds.min.z;
        return pWidth;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
