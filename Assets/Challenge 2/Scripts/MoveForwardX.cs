using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Dog"))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else
            transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
