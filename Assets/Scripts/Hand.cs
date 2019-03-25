using UnityEngine;

public class Hand : MonoBehaviour
{
    // Update is called once per frame
    protected void Update()
    {
        Vector3 eulerAngles = transform.eulerAngles;
        if (Input.GetKey(KeyCode.A))
        {
            eulerAngles.z = 180.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            eulerAngles.z = 0.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            eulerAngles.z = 90.0f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            eulerAngles.z = 270.0f;
        }

        transform.eulerAngles = eulerAngles;
    }
}