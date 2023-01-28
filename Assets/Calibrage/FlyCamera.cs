using UnityEngine;
using System.Collections;

public class FlyCamera : MonoBehaviour
{

    /*
    Writen by Windexglow 11-13-10.  Use it, edit it, steal it I don't care.  
    Converted to C# 27-02-13 - no credit wanted.
    Simple flycam I made, since I couldn't find any others made public.  
    Made simple to use (drag and drop, done) for regular keyboard layout  
    wasd : basic movement
    shift : Makes camera accelerate
    space : Moves camera on X and Z axis only.  So camera doesn't gain any height*/


    float mainSpeed = 100.0f; //regular speed
    float shiftAdd = 250.0f; //multiplied by how long shift is held.  Basically running
    float maxShift = 1000.0f; //Maximum speed when holdin gshift
    float camSens = 250f; //How sensitive it with mouse
    bool isPausing = false;
    private Vector3
        lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    public Camera cam;

    private float totalRun = 1.0f;

    void Update()
    {
        cam.transform.position = new Vector3(65.75f, 514.5f, 46.5f);
        cam.transform.rotation =  Quaternion.Euler(90, 0, -90);

    }

    private Vector3 GetBaseInput()
    {
        //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        
        if (Input.GetKey(KeyCode.Z))
        {
            p_Velocity += new Vector3(0, 1, 0);
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            isPausing = !isPausing; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            cam.orthographicSize += 1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            cam.orthographicSize -= 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }

        
        
        return p_Velocity;
    }

    public Vector3 GetBaseRot()
    {
        Vector3 rot = Vector3.zero;
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rot += new Vector3(0, 0, -1);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rot += new Vector3(0, 0, 1);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rot += new Vector3(-1, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rot += new Vector3(1, 0, 0);
        }
        
        return rot;
    }
}