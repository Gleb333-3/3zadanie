using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turel : MonoBehaviour
{


    [SerializeField]
    private Transform _cube;

    [SerializeField]
    private Transform _Jo;

    private void Update()
    {
        var positio = _cube.position - _Jo.position;
        var rotation = Quaternion.LookRotation(positio);
        _cube.rotation = rotation;


    }
}