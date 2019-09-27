using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { 

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * 10.0f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * 10.0f * Time.deltaTime;
        }
        //didnt use s because when s is pressed it begins to debug instead
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * 10.0f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * 10.0f * Time.deltaTime;
        }


    }
}
