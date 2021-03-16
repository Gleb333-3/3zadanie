using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patron : MonoBehaviour
{
    [SerializeField]
    private GameObject _yd;

    [SerializeField]
    private GameObject _ydJo;

    [SerializeField]
    private Transform _Patron;


    [SerializeField]
    private Transform _Ne1;

    [SerializeField]
    private Transform _DisPatr;

    [SerializeField]
    private Transform _DisJon;

    [SerializeField]
    private Transform _Jo1;

    private void Update()
    {
        var dis = Vector3.Distance(_Ne1.position, _Jo1.position);
        var dir = Vector3.Distance(_DisPatr.position, _DisJon.position);
        if (dis < 4)
        {
            _Patron.position = Vector3.MoveTowards(_Patron.position, transform.position, 10 * Time.deltaTime);

        }

        if (dir < 1)
        {
            Destroy(_yd);
            _ydJo.SetActive(false);
        }
    }
}
