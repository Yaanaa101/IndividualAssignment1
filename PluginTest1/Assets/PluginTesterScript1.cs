using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class PluginTesterScript1 : MonoBehaviour
{
    const string DLL_NAME = "SIMPLEPLUGIN";
    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();

    [DllImport(DLL_NAME)]
    private static extern void read();

    [DllImport(DLL_NAME)]
    private static extern void write(float numX, float numY, float numZ);

    [DllImport(DLL_NAME)]
    private static extern float getX();

    [DllImport(DLL_NAME)]
    private static extern float getY();

    [DllImport(DLL_NAME)]
    private static extern float getZ();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {   
            Debug.Log(SimpleFunction());
        }

        //saves the position of the cube to the txt file
        if (Input.GetKey(KeyCode.O))
        {
            //writes the position of the x,y,z of the cube to the txt file
            write(transform.position.x, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.P))
        {
            read();

            //getting the transformed position and setting the cube's position to that
            transform.position = new Vector3(getX(), getY(), getZ());
         
        }
    }
}