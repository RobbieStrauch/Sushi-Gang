using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelDestroy : MonoBehaviour
{
    public static ModelDestroy instance;

    public List<GameObject> prefabsInScene;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clear()
    {
        if (prefabsInScene.Count > 0)
        {
            GameObject temp = prefabsInScene[prefabsInScene.Count - 1];
            prefabsInScene.Remove(prefabsInScene[prefabsInScene.Count - 1]);
            Destroy(temp);
        }
    }

    public void ClearAll()
    {
        if (prefabsInScene.Count > 0)
        {
            foreach (var item in prefabsInScene)
            {
                Destroy(item);
            }
            prefabsInScene.Clear();
        }
    }
}
