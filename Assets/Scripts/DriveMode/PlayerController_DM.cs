using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_DM : MonoBehaviour
{
    private Vector3 vec = Vector3.right;
    private float offset = 5F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, Mathf.Sin(30F * Time.deltaTime), 
        //                0, Space.Self);
        transform.position = vec * Mathf.PingPong(5 * Time.deltaTime, 50);
    }
}
