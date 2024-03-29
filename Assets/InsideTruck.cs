using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideTruck : MonoBehaviour
{
    public  movingVanSim vanSim;
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
        if (other.CompareTag("Package"))
        {
            vanSim.packages.Add(other.gameObject);
        }
    }


    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Package"))
        {
            vanSim.packages.Remove(other.gameObject);
        }
    }

}
