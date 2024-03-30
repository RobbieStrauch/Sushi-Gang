using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPlacement : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGrab()
    {
        rb.constraints = RigidbodyConstraints.None;
    }
 
    public void OnRelease()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}
