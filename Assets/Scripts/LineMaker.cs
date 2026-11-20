using UnityEngine;

public class LineMaker : MonoBehaviour
{
    private LineRenderer line;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        line = gameObject.GetComponent(typeof(LineRenderer)).GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, transform.position);
    }
}