using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUI : MonoBehaviour
{
    private Camera mainCamera;
    private float centerDistance = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = mainCamera.transform.position + (mainCamera.transform.forward * centerDistance);
        transform.position += (cameraPosition - transform.position) * Time.deltaTime;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, mainCamera.transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
