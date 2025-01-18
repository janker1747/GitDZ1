using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _rotationCentre;
    [SerializeField] private Vector3 _offset;

    void Update()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
        _offset = transform.position - _rotationCentre.position;
    }
}
