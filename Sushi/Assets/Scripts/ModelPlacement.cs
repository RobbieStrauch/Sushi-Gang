using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPlacement : MonoBehaviour
{
    private Rigidbody rb;
    private List<int> hands = new List<int>();
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hands.Count > 0)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
        else
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    public void OnGrab()
    {
        counter++;
        hands.Add(counter);
    }
 
    public void OnRelease()
    {
        hands.Remove(counter);
        counter--;
    }
}
