using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableCamera : SelectableFromScreen
{
    // Start is called before the first frame update
    [Header("General Settings")]
    public GameObject camView;


    public override void OnStart()
    {
        base.OnStart();
        DisableCam();

    }
    public void OnViewButton()
    {
        camView.SetActive(!camView.activeSelf);
    }

    public override void OnDeselect()
    {
        base.OnDeselect();
        DisableCam();
    }
    void DisableCam()
    {
        camView.SetActive(false);
    }


}
