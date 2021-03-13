using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ColoredMaterialData : ScriptableObject
{
    public Material _red;
    public Material _green;
    public Material _yellow;
    public Material _black;
    public Material _orange;
    public Material _grey;

    public static Material red;
    public static Material green;
    public static Material yellow;
    public static Material black;
    public static Material orange;
    public static Material grey;


    private void OnEnable()
    {
        red = _red;
        green = _green;
        yellow = _yellow;
        black = _black;
        orange = _orange;
        grey = _grey;
    }
}
