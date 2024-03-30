using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModelUI : MonoBehaviour
{
    public GameObject modelPanel;
    public GameObject leavePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnModelPanel()
    {
        modelPanel.SetActive(true);
        leavePanel.SetActive(false);
    }

    public void TurnOnLeavePanel()
    {
        modelPanel.SetActive(false);
        leavePanel.SetActive(true);
    }

    public void TurnOffAll()
    {
        modelPanel.SetActive(false);
        leavePanel.SetActive(false);
    }
}
