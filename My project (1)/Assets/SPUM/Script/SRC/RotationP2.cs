using UnityEngine;

public class RotationP2 : MonoBehaviour
{
    public float r = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0, 0, r * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.O))
        {
            transform.Rotate(0, 0, -r * Time.deltaTime);
        }
    }
}