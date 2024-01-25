using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1Menu : MonoBehaviour
{
    [SerializeField]
    Button b1;

    [SerializeField]
    Button b2;

    // Start is called before the first frame update
    void Start()
    {
        // disable buttons
        b1.interactable = false;
        b2.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
