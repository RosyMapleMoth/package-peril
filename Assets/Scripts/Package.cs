using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class Package : MonoBehaviour
{
    public float x = 0;
    public float z = 0;
    public float y = 0;
    public string address;
    public TextMeshPro text;
    public bool droppedOff = false;
    public bool pickedUp = false;
    bool selected = false;
    private bool droppedOffBAD = false;

    public Material baseMat;

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
        else if (droppedOff)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (droppedOffBAD)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GetComponent<Renderer>().material = baseMat;
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

    public void dropOff()
    {
        droppedOff = true;
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void dropOffBAD()
    {
        droppedOffBAD = true;
        GetComponent<Renderer>().material.color = Color.blue;
    }


}
