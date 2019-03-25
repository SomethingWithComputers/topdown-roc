using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    [SerializeField] private GameObject _prefabPunch = null;

    private void OnDisable()
    {
        Sword.OnSwing -= onSwordSwing;
    }

    private void Start()
    {
        Sword.OnSwing += onSwordSwing;
    }

    private void onSwordSwing(Sword sword)
    {
        Instantiate(_prefabPunch, sword.transform.position, Quaternion.identity);
    }
}