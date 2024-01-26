using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class InputFieldValidator : MonoBehaviour
{
    public static string ID;
    public TMP_InputField inputField;
    public Button button1;
    public Button button2;

    void Start()
    {
        // Disabilita i bottoni
        button1.interactable = false;
        button2.interactable = false;
    }

    void Update()
    {
        // Controlla se l'input field contiene almeno 4 caratteri
        if (inputField.text.Length >= 4)
        {
            // Abilita i bottoni
            button1.interactable = true;
            button2.interactable = true;

           
        }
        else
        {
            // Disabilita i bottoni
            button1.interactable = false;
            button2.interactable = false;
        }
    }
      public void OnButtonClick()
    {
        // Genera un ID univoco
        ID = System.Guid.NewGuid().ToString();
    }
}

