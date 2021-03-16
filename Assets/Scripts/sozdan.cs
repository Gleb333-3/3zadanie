using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sozdan : MonoBehaviour
{
    [SerializeField]
    private Transform _GdeBom;

    [SerializeField]
    private Transform _Jon;

    [SerializeField]
    private Transform _bom;

    [SerializeField]
    private GameObject _yd;

    [SerializeField]
    private GameObject _Bom12;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_Bom12, _GdeBom.position, Quaternion.identity);
        }
        var di = Vector3.Distance(_Jon.position, _bom.position);
        if (di < 0.5)
        {
            Destroy(_yd);
            Debug.Log(di);
        }
    }
}