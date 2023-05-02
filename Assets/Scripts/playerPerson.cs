using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPerson : MonoBehaviour
{
    float x = 0;
    float z = 0;
    public float rotSpeed = 300;
    public float moveSpeed = 7;

    public CapsuleCollider myCollider;


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
        if (gmTimeAttack.Instance.gameOver)
        {
            return;
        }
    
        if (Input.GetKey(KeyCode.LeftShift))
        {
           if (Input.GetKey(KeyCode.W))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, mySelector.pickUpCam.transform.right, rotSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, -mySelector.pickUpCam.transform.right, rotSpeed * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.A))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, mySelector.pickUpCam.transform.up, rotSpeed * Time.deltaTime);
                
            }
            if (Input.GetKey(KeyCode.D))
            {
                mySelector.heldCube.transform.RotateAround(mySelector.heldCube.transform.position, -mySelector.pickUpCam.transform.up, rotSpeed * Time.deltaTime);
            }
        }
        else
        {
            RaycastHit hit;
            Vector3 move = new Vector3(0,0,0);   
            if (Input.GetKey(KeyCode.W))
            {
                Ray ray = new Ray(transform.position, transform.forward);
                if (!Physics.Raycast(ray,out hit, Time.deltaTime * moveSpeed + myCollider.radius)|| hit.collider.CompareTag("DeliveryZone")|| hit.collider.CompareTag("TruckPackageZone"))
                {
                    move += transform.forward * Time.deltaTime * moveSpeed;
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                Ray ray = new Ray(transform.position, -transform.forward);
                if (!Physics.Raycast(ray,out hit, Time.deltaTime * moveSpeed + myCollider.radius)|| hit.collider.CompareTag("DeliveryZone")|| hit.collider.CompareTag("TruckPackageZone"))
                {
                    move -= transform.forward * Time.deltaTime * moveSpeed;
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                Ray ray = new Ray(transform.position, -transform.right);
                if (!Physics.Raycast(ray,out hit, Time.deltaTime * moveSpeed + myCollider.radius) || hit.collider.CompareTag("DeliveryZone")|| hit.collider.CompareTag("TruckPackageZone"))
                {
                    move -= transform.right * Time.deltaTime * moveSpeed;
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                Ray ray = new Ray(transform.position, transform.right);
                if (!Physics.Raycast(ray,out hit, Time.deltaTime * moveSpeed + myCollider.radius)|| hit.collider.CompareTag("DeliveryZone") || hit.collider.CompareTag("TruckPackageZone"))
                {
                    move += transform.right * Time.deltaTime * moveSpeed;
                }
            }  
            Ray raydir = new Ray(transform.position, move.normalized);
            if (!Physics.Raycast(raydir,out hit, move.magnitude + myCollider.radius) || hit.collider.CompareTag("DeliveryZone")|| hit.collider.CompareTag("TruckPackageZone"))
            {
                transform.position += move;
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
        /*if (Input.GetKeyDown(KeyCode.Q))
        {
           gmTimeAttack.Instance.switchMode();
        }*/
    }




    /// <summary>
    /// OnTriggerStay is called once per frame for every Collider other
    /// that is touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TruckEnterZone"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gmTimeAttack.Instance.EnterTruckMode();
            }
        }
    }

}
