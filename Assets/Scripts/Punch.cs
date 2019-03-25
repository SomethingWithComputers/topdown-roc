using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        transform.localScale = Vector3.zero;

        LeanTween.scale(gameObject, Vector3.one, 0.08f).setEaseOutQuint().setOnComplete(() =>
        {
            LeanTween.alpha(gameObject, 0.0f, 0.32f).setOnComplete(() => { Destroy(gameObject); });
        });
    }
}