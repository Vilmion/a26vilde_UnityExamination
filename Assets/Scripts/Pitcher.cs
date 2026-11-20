using UnityEngine;

public class Pitcher : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.Play();
        audioSource.pitch = Random.Range(0.4f, 3f);
    }
}
