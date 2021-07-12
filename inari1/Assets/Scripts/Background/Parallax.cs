using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float parallax;
    public Vector3 offset;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cam.transform.position;
        transform.position = new Vector3(transform.position.x / parallax, transform.position.y / parallax);
        transform.position += offset;
    }
}
