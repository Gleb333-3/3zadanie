using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class загадка : MonoBehaviour
{
    [SerializeField]
    private Transform _Plit;


    [SerializeField]
    private Transform _Joo;


    [SerializeField]
    private GameObject _Cten;

    // Update is called once per frame
    private void Update()
    {
        var di = Vector3.Distance(_Plit.position, _Joo.position);
        if(di < 0.4)
        {
            Destroy(_Cten);
        }
    }
}
