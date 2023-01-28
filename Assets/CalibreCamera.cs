using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalibreCamera : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.position = new Vector3(59.1443f, 532.2576f, 46.7811f);
        camera.transform.rotation =  Quaternion.Euler(90f,0f,90f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
