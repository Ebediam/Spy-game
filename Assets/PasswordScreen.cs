using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordScreen : MonoBehaviour
{

    public TMP_InputField inputField;
    public VoidEventChannel correctPasswordEvent;
    public string password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSubmit()
    {
        if(inputField.text.ToLower() == password.ToLower())
        {
            correctPasswordEvent.RaiseEvent();
            gameObject.SetActive(false);
        }
        else
        {
            inputField.text = "";
        }
    }
}
