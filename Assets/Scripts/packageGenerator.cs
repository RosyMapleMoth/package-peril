using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packageGenerator : MonoBehaviour
{
    public List<GameObject> packages;
    public List<PackageDropOff> dropOffs;

    float i = 2f;


    // Start is called before the first frame update
    void Start()
    {
        PackageDropOff[] temp = FindObjectsOfType<PackageDropOff>();
        foreach (PackageDropOff i in temp)
        {
            dropOffs.Add(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        i -= Time.deltaTime;
        if (i < 0)
        {
            try
            {
                CreatePackage();
            }
            catch
            {
                Debug.Log("No more drop off points");
            }
            i = 2f;
        }
    }

    public void CreatePackage()
    {
        GameObject newPackage = Instantiate(packages[Random.Range(0, packages.Count)]);
        newPackage.transform.position = transform.position;
        int temp = Random.Range(0, dropOffs.Count);   
        dropOffs[temp].CorrectCubeObj = newPackage.gameObject;
        newPackage.GetComponent<Package>().address = dropOffs[temp].address;
        newPackage.GetComponent<Package>().text.text = dropOffs[temp].address;
        dropOffs[temp].InUse = true;
        dropOffs.RemoveAt(temp);
    }
}
