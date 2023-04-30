using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPerson : MonoBehaviour
{
    float x = 0;
    float z = 0;
    float rotSpeed = 3000;


    public CubeSelector mySelector;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetKey(KeyCode.LeftShift))
        {
           if (Input.GetKey(KeyCode.W))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, transform.right, rotSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, -transform.right, rotSpeed * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.A))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, Camera.main.transform.up, rotSpeed * Time.deltaTime);
                
            }
            if (Input.GetKey(KeyCode.D))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, -Camera.main.transform.up, rotSpeed * Time.deltaTime);
                
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * Time.deltaTime * 10;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= transform.forward * Time.deltaTime * 10;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= transform.right * Time.deltaTime * 10;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += transform.right * Time.deltaTime * 10;
            }  
        }
        // FPS controls
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<CubeSelector>().ThrowCube();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            GetComponent<CubeSelector>().Drop();
        }
        else if (Input.GetMouseButtonDown(0))
        {
            GetComponent<CubeSelector>().PickUp();
        }
    }
}
