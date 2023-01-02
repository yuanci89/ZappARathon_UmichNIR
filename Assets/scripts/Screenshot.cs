using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zappar.Additional.SNS;
using static Zappar.Additional.SNS.ZSaveNShare;

public class Screenshot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ZSaveNShare.Initialize();

    }
 
    public void OnPressed()
    {
        TakeSnapshot();
        
        Debug.Log("Snapshot Taken");
    }
  
 
    public void TakeSnapshot()
    {
        ZSaveNShare.RegisterSNSCallbacks(OnSaved, OnShared, OnPromptClosed);
        StartCoroutine(ZSaveNShare.TakeSnapshot(OnSnapshotCaptured));
    }

    public void OnSnapshotCaptured()
    {
        Debug.Log("Open prompt");
        ZSaveNShare.OpenSNSSnapPrompt();
    }

    public void OnSaved()
    {
        Debug.Log("Prompt saved");
    }

    public void OnShared()
    {
        Debug.Log("Prompt shared");
    }

    public void OnPromptClosed()
    {
        Debug.Log("Save and share prompt closed");
        ZSaveNShare.DeregisterSNSCallbacks(OnSaved, OnShared, OnPromptClosed);
    }
}