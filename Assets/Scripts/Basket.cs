using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] private GameObject balloon;
    private bool floating = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (floating)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        balloon.SetActive(true);
    }

    public void StartFloat()
    {
        floating = true;
    }
}
