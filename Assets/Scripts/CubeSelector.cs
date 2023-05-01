using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    public GameObject selectedCube;
    public Package heldCube; 
    public Camera pickUpCam;
    public float PickUpRange = 2f;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectedCube = null;
        Vector3 rayOrigin = new Vector3(0.5f, 0.5f, 0f); // center of the screen

        // actual Ray
        Ray ray = Camera.main.ViewportPointToRay(rayOrigin);

        // debug Ray
        Debug.DrawRay(ray.origin, ray.direction * PickUpRange, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, PickUpRange))
        {
            if (hit.transform.CompareTag("Package"))
            {
                hit.transform.GetComponent<Package>().lookedAt();
                selectedCube = hit.transform.gameObject;
            }
        }
    }

    public void PickUp()
    {
        if (selectedCube != null)
        {
            selectedCube.transform.parent = pickUpCam.gameObject.transform;
            selectedCube.transform.localPosition = new Vector3(0, 0, 1f);
            GetComponent<CapsuleCollider>().radius = 1;

            heldCube = selectedCube.GetComponent<Package>();
            heldCube.pickedUp = true;
            Debug.Log("Held Cube assigned: " + selectedCube.transform.eulerAngles.x + " , " + selectedCube.transform.eulerAngles.z);
            heldCube.x = selectedCube.transform.eulerAngles.x;
            heldCube.z = selectedCube.transform.eulerAngles.z;
            //roateHeldCube(new Vector3(heldCube.x,heldCube.y,heldCube.z));
            Debug.Log("Held Cube x and z: " + heldCube.x + " , " + heldCube.z);

            selectedCube.GetComponent<Rigidbody>().isKinematic = true;
            selectedCube.gameObject.layer = 6; // layer 6 is the "Held" layer
            selectedCube.transform.GetChild(0).gameObject.layer = 6; // layer 6 is the "Held" layer
            selectedCube.transform.GetChild(1).gameObject.layer = 6;
        }
    }

    public void Drop()
    {
        if (heldCube != null)
        {
            /*Vector3 rayOrigin = new Vector3(0.5f, 0.5f, 0f);
            Ray ray = Camera.main.ViewportPointToRay(rayOrigin);

            // debug Ray
            Debug.DrawRay(ray.origin, ray.direction * PickUpRange, Color.blue);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, PickUpRange))
            {
                heldCube.transform.parent = null;
                heldCube.transform.position = hit.point + new Vector3(0.5f, 0.5f, 0);
            }
            else
            {
                heldCube.transform.parent = null;
                heldCube.transform.position = gameObject.transform.position + new Vector3(0, 0, 1f);
            }*/
            GetComponent<CapsuleCollider>().radius = 0.5f;
            heldCube.transform.position = gameObject.transform.GetChild(0).position + gameObject.transform.GetChild(0).forward;
            heldCube.transform.parent = null;
            heldCube.GetComponent<Rigidbody>().isKinematic = false;
            heldCube.GetComponent<Package>().pickedUp = false;
            heldCube.gameObject.layer = 0; // layer 6 is the "Held" layer
            heldCube.transform.GetChild(0).gameObject.layer = 0; // layer 6 is the "Held" layer
            heldCube.transform.GetChild(1).gameObject.layer = 0;
            heldCube = null;
        }
    }




    public void ThrowCube()
    {
        if (heldCube != null)
        {
            heldCube.transform.position = gameObject.transform.GetChild(0).position + gameObject.transform.GetChild(0).forward;
            heldCube.transform.parent = null;
            heldCube.GetComponent<Rigidbody>().isKinematic = false;
            heldCube.GetComponent<Package>().pickedUp = false;
            // throw the direction the camara is looking
            heldCube.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 600, ForceMode.Force);
            heldCube.gameObject.layer = 0; // layer 6 is the "Held" layer
            heldCube.transform.GetChild(0).gameObject.layer = 0; // layer 6 is the "Held" layer
            heldCube.transform.GetChild(1).gameObject.layer = 0;
            heldCube = null;

        }
    }


    public void roateHeldCube(Vector3 rotation)
    {
        if (heldCube != null)
        {
            Debug.Log("rotating");
            heldCube.transform.localEulerAngles = rotation;
        }
    }

    



}
