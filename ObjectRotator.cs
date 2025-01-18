using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float _speedRotation;
    [SerializeField] private Transform _rotationCentre;

    private void Update()
    {
        transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime);
    }
}
