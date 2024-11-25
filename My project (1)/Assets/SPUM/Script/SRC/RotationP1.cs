using UnityEngine;

public class RotationP1 : MonoBehaviour
{
    public float rota = 50f;
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
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(0, 0, rota * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(0, 0, -rota * Time.deltaTime);
        }
    }
}