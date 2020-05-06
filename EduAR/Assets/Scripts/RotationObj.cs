using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.up, 50f * Time.deltaTime);
    }
}
