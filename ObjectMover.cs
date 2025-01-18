using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    void Update()
    {
        var FirstPozition = transform.position;
        var SecondPozition = transform.position;

        FirstPozition.z += 0.01f;
        transform.position = FirstPozition;
    }
}
