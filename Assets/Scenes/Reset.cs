using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(1.5f, 0.5f, 1.5f);
        }
    }
}
