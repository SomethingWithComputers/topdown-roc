using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private List<Hittable> _hittablesInRange = null;

    private void Start()
    {
        _hittablesInRange = new List<Hittable>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Might cause problems! Multithreading..
            foreach (Hittable hittable in _hittablesInRange.ToArray())
            {
                hittable.ReceiveHit(1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Hittable hittable = other.GetComponent<Hittable>();
        if (null != hittable)
        {
            Debug.Log("Added: " + hittable.name);
            _hittablesInRange.Add(hittable);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Hittable hittable = other.GetComponent<Hittable>();
        if (null != hittable)
        {
            Debug.Log("Removed: " + hittable.name);
            _hittablesInRange.Remove(hittable);
        }
    }
}