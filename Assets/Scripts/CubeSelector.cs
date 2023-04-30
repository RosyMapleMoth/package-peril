using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    public GameObject selectedCube;
    public Package heldCube; 
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
            selectedCube.transform.parent = transform.GetChild(0);
            selectedCube.transform.localPosition = new Vector3(0, 0, 1.5f);

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
