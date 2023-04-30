using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    public float x = 0;
    public float z = 0;
    public float y = 0;
    public bool pickedUp = false;
    bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }
 
    void LateUpdate()
    {
        if (selected)
        {
            selected = false;
        }
        else if (pickedUp)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void lookedAt()
    {
        selected = true;
        GetComponent<Renderer>().material.color = Color.red;
        if (pickedUp)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
