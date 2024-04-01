using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VirtualUI : MonoBehaviour
{
    public List<GameObject> panels;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnPanelOn(GameObject panel)
    {
        foreach (var item in panels)
        {
            if (item == panel)
            {
                item.SetActive(true);
            }
            else
            {
                item.SetActive(false);
            }
        }
    }

    public void TurnOffAll()
    {
        foreach (var item in panels)
        {
            item.SetActive(false);
        }
    }
}
