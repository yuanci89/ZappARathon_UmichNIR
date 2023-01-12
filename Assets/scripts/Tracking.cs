using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
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
        Debug.Log("This is really high stress.");
        
    }
    public void OnNotSeen()
    {
        Debug.Log("My name is Racos and I'm chill.");
    }
    }
