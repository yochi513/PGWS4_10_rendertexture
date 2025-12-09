using UnityEngine;

public class RotateScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(-3.0f, 20.0f * Time.deltaTime, 2.0f);
    }
}
