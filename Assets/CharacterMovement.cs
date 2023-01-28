using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    
    float mainSpeed = 100.0f; //regular speed
    float shiftAdd = 250.0f; //multiplied by how long shift is held.  Basically running
    float maxShift = 1000.0f; //Maximum speed when holdin gshift
    float camSens = 250f; //How sensitive it with mouse
    bool isPausing = false;

    private float totalRun = 1.0f;

    void Update()
    {
        

        //Keyboard commands
        float f = 0.0f;
        Vector3 p = GetBaseInput();
        if (p.sqrMagnitude > 0)
        {
            // only move while a direction key is pressed
            if (Input.GetKey(KeyCode.LeftShift))
            {
                totalRun += Time.deltaTime;
                p = p * totalRun * shiftAdd;
                p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
                p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
                p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
            }
            else
            {
                totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
                p = p * mainSpeed;
            }

            p = p * Time.deltaTime;
            Vector3 newPosition = transform.position;
            
          
                transform.Translate(p);
            
            
            
        }
        
    }

    private Vector3 GetBaseInput()
    {
        //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(0, 0, 0.25f);
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            isPausing = !isPausing; 
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            p_Velocity += new Vector3(0,0 , -0.25f);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            p_Velocity += new Vector3(-0.25f, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0.25f, 0, 0);
        }

        
        
        return p_Velocity;
    }

    
}

