//Made in class - 100655510
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class PluginReader : MonoBehaviour
{
    Vector3 pos;
    private Rigidbody rb;

    float posx, posy, posz;
   
    const string DLL_NAME = "tut2";
    [DllImport(DLL_NAME)]
    private static extern int Save(float x, float y, float z);
    [DllImport(DLL_NAME)]
    private static extern Vector3 Load();

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            posx = rb.GetComponent<Rigidbody>().position.x;
            posy = rb.GetComponent<Rigidbody>().position.y;
            posz = rb.GetComponent<Rigidbody>().position.z;

            Debug.Log(Save(posx, posy, posz));
           //Debug.Log(Load());

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            pos = Load();
            rb.GetComponent<Rigidbody>().position = pos;

        }
    }
}