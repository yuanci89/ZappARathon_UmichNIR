using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
//using static UnityEditor.Progress;

public class CaseChooser : MonoBehaviour
{
    public Dropdown choosecase;
    GameObject[] caselist;
    int visi;
    int invisi;
    static int casenum = 0;

    // Start is called before the first frame update
    void Start()
    {
        caselist = GameObject.FindGameObjectsWithTag("Case");
        visi = LayerMask.NameToLayer("Default");
        invisi = LayerMask.NameToLayer("Invisible");

        PopulateDropdown(choosecase, caselist);

        caselist[casenum].layer = visi;
        foreach (Transform child in caselist[casenum].GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = visi;
        }
    }

    // Update the dropdown list
    void PopulateDropdown(Dropdown dropdown, GameObject[] optionsArray)
    {
        List<string> options = new List<string>();
        foreach (var option in optionsArray)
        {
            options.Add(option.name); // Or whatever you want for a label
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }

    // With each chosen case
    public void SelectCase()
    {
        caselist[casenum].layer = invisi;
        foreach (Transform child in caselist[casenum].GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = invisi;
        }

        //Debug.Log(String.Format("Length {0}", casenum));
        //for (int i = 0; i < caselist.Length; i++)
        //{
        //    caselist[i].layer = invisi;
        //    foreach (Transform child in caselist[i].GetComponentsInChildren<Transform>(true))
        //    {
        //        child.gameObject.layer = invisi;
        //    }
        //}

        casenum = choosecase.value;

        caselist[casenum].layer = visi;
        foreach (Transform child in caselist[casenum].GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = visi;
        }
    }
}
