using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum VectorPosition
{
    x,
    y,
    z
}

public static class Utils
{
    
    public static Vector3 SwapFromVector(Vector3 original, float newValue, VectorPosition position)
    {
        Vector3 newVector = new Vector3();
        switch (position)
        {
            case VectorPosition.x:

                newVector = new Vector3(newValue, original.y, original.z);
                break;

            case VectorPosition.y:

                newVector = new Vector3(original.x, newValue, original.z);
                break;

            case VectorPosition.z:

                newVector = new Vector3(original.x, original.y, newValue);
                break;
        }

        return newVector;


    }


}
