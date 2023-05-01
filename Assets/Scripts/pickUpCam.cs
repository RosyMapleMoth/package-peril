using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpCam : MonoBehaviour
{

    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = cam.transform.rotation;
    }
}
