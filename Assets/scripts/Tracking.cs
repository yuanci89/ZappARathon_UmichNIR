using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zappar;

public class Tracking : MonoBehaviour
{
    public GameObject model = null;
    public GameObject preview = null;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting tracking");
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnSeen()

    {
        model.SetActive(true);
        preview.SetActive(true);
        Debug.Log("This is really high stress.");
        
    }
    public void OnNotSeen()
    {
        Debug.Log("My name is Racos and I'm chill.");
        model.SetActive(false);
        preview.SetActive(false);
    }
    }
