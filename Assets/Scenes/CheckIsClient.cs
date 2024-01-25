using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("IsClient: " + GameManager.instance.isClient);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
