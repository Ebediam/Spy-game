using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectableFromScreen : MonoBehaviour
{
    [Header("Image Settings")]
    public Image icon;
    public Color mainColor;
    public Color hoverColor;
    public Color selectedColor;


    [Header("Contextual Menu settings")]
    public GameObject contextualMenu;


    [Header("Events settings")]
    public VoidEventChannel NewSelected;

    private bool isSelected = false;
    private bool isHovering = false;

    void Start()
    {
        
        OnStart();
    }

    public virtual void OnStart()
    {
        icon.color = mainColor;
        contextualMenu.SetActive(false);
        NewSelected.RaisedEvent += OnNewSelected;

    }


    public void OnNewSelected()
    {
        if (!isHovering)
        {
            OnDeselect();
        }
    }
    public virtual void HoverStart()
    {
        isHovering = true;

        if (!isSelected)
        {
            icon.color = hoverColor;
        }

    }

    public virtual void HoverEnd()
    {

        isHovering = false;

        if (!isSelected)
        {
            icon.color = mainColor;
        }
    }

    public virtual void OnClick()
    {
        if (isSelected)
        {
            OnDeselect();
        }
        else
        {
            Selected();
        }
    }

    public virtual void Selected()
    {

        icon.color = selectedColor;
        isSelected = true;
        contextualMenu.SetActive(true);
        NewSelected.RaiseEvent();
    }

    public virtual void OnDeselect()
    {
        icon.color = mainColor;
        isSelected = false;
        contextualMenu.SetActive(false);
    }

}
