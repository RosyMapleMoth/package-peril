using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageDropOff : MonoBehaviour
{

    public string CorrectCube;
    public GameObject CorrectCubeObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("oh dear");
        if (other.gameObject.CompareTag("Package"))
        {
            if (other.GetComponent<Package>().pickedUp)
            {
                return;
            }
            if (other.gameObject == CorrectCubeObj)
            {
                Debug.Log("Gotum");
                other.GetComponent<Package>().dropOff();
            }
            else
            {
                Debug.Log("Gotum BAD");
                other.GetComponent<Package>().dropOffBAD();
            }

        }
    }
}
