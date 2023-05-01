using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gmTimeAttack : MonoBehaviour
{

    public int score;
    public float time;
    public bool gameOver = false;
    public GameObject GAMEOVERSCREEN;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public packageGenerator generator;
    public GameObject playerPerson;
    public GameObject playerTruck;
    public List<Package> ActivePackages;
    public List<PackageDropOff> InactivePackages;
    public static gmTimeAttack Instance { get; private set; }


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = time.ToString("F2");
        scoreText.text = score.ToString();
        if (time < 0)
        {
            Debug.Log("Game Over");
            gameOver = true;
            GAMEOVERSCREEN.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            time -= Time.deltaTime;
        }

        if (ActivePackages.Count < 5)
        {   
            try
            {
                ActivePackages.Add(generator.CreatePackage());
            }
            catch
            {
                Debug.Log("No more drop off points");
            }
        }
    }


    public void EnterFirstPersonMode()
    {
        Debug.Log("Entering First Person Mode");


    }

    public void EnterTruckMode()
    {
        Debug.Log("Entering Truck Mode");

    }

    public void packageDropOff(Package package)
    {
        Debug.Log("Package Dropped Off");
        ActivePackages.Remove(package);
    }
}
