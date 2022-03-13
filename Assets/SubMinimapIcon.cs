using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMinimapIcon : MonoBehaviour
{
    public Transform subsTransform;
    //Drag and Drop the transform (x,y,z) of the submarine. 
    //This script is so the minimap icon for the sub doesnt rotate like the sub.
    void Update()
    {
        transform.position = new Vector3(subsTransform.position.x, subsTransform.position.y + 10, subsTransform.position.z);
        transform.rotation = Quaternion.identity;
    }
}
