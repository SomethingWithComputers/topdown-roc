using System;
using UnityEngine;

public class Hittable : MonoBehaviour
{
    public Action<int> OnHit = delegate { };

    public void ReceiveHit(int damage = 0)
    {
        OnHit(0);
    }
}