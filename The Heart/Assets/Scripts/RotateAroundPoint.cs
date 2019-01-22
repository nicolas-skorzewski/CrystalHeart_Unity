using UnityEngine;
using System.Collections;

public class RotateAroundPoint : MonoBehaviour
    
{
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.down, 35 * Time.deltaTime);
    }
}