using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPlacement : MonoBehaviour
{
    private Rigidbody rb;
    private List<int> hands = new List<int>();
    private int counter = 0;
    private Vector3 originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalRotation = transform.eulerAngles;
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
            transform.eulerAngles = new Vector3(originalRotation.x, transform.eulerAngles.y, originalRotation.z);
        }
    }

    public void OnGrab()
    {
        counter++;
        hands.Add(counter);
        //rb.constraints = RigidbodyConstraints.None;
    }
 
    public void OnRelease()
    {
        hands.Remove(counter);
        counter--;
        //rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}
