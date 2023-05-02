using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingVanSim : MonoBehaviour
{
    public Transform Van;
    public GameObject Player;
    public GameObject VanSim;
    public GameObject VanSimHitBox;
    public GameObject VanPersonModeHitbox;
    public List<GameObject> packages;

    public VanState state = VanState.Driving;

    public enum VanState
    {
        Driving,
        Stopped
    }


    // Start is called before the first frame update
    void Start()
    {
        //SwitchToDriving();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == VanState.Driving)
        {
            //VanSim.GetComponent<Rigidbody>().MovePosition(Van.position + new Vector3(0, -2000,0));
            VanSim.transform.rotation = Van.rotation;
        }
        else if (state == VanState.Stopped)
        {

        }
    }


    public void SwitchToDriving()
    {
        foreach (GameObject i in packages)
        {
            i.transform.SetParent(VanSim.transform.GetChild(0));
        }
        VanSim.transform.position = Van.position + new Vector3(0, -2000,0);
        VanSim.transform.rotation = Van.rotation;

        foreach (GameObject i in packages)
        {
            i.transform.SetParent(null);
        }

        VanSimHitBox.SetActive(true);
        VanPersonModeHitbox.SetActive(false);
        state = VanState.Driving;
    }


    public void SwitchToStopped()
    {
        foreach (GameObject i in packages)
        {
            i.transform.SetParent(VanSim.transform.GetChild(0));
        }
        VanSim.transform.position = Van.transform.position;
        VanSim.transform.rotation = Van.rotation;
        Player.transform.position = VanSim.transform.position + -Van.forward * 3 + new Vector3(0,4,0);
        Player.SetActive(true);
        foreach (GameObject i in packages)
        {
            i.transform.SetParent(null);
        }
        VanSimHitBox.SetActive(false);
        VanPersonModeHitbox.SetActive(true);
        state = VanState.Stopped;
    }
}
