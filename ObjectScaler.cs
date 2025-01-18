using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    void Update()
    {
        Vector3 growth = Vector3.one * _growthSpeed * Time.deltaTime;
        transform.localScale += growth;
    }
}
