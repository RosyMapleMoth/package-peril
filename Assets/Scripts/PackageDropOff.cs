using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PackageDropOff : MonoBehaviour
{
    public GameObject player;
    public TextMeshPro addressVisual;
    public string CorrectCube;
    public string address;
    public GameObject CorrectCubeObj;
    public bool InUse = false;

    // Start is called before the first frame update
    void Start()
    {
        addressVisual.text = address;
        player = FindObjectOfType<playerPerson>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.parent.transform.LookAt(player.transform);
        addressVisual.text = address;
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
