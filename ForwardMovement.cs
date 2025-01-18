using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _speedMovement;

    private void Update()
    {
        transform.position += transform.forward * _speedMovement * Time.deltaTime;
    }
}
