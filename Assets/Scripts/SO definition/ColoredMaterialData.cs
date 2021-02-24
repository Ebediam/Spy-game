using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ColoredMaterialData : ScriptableObject
{
    public Material _red;
    public Material _green;

    public static Material red;
    public static Material green;

    private void OnEnable()
    {
        red = _red;
        green = _green;
    }
}
