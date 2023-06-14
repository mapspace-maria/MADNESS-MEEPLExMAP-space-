using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_left : MonoBehaviour
{
    public float rotateSpeed = 10f; // adjust this value to control the speed of rotation

    // Start is called before the first frame update
    void Start()
    {
        // nothing to do here
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.TransformDirection(Vector3.down) * rotateSpeed * Time.deltaTime); // rotate the object around its own local y-axis
    }
}
