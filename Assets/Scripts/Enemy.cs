using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _health = 1;

    // Start is called before the first frame update
    protected void Start()
    {
        GetComponent<Hittable>().OnHit += damage =>
        {
            if (--_health <= 0)
            {
                Destroy(gameObject);
            }
        };
    }
}