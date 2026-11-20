using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private bool isFollowing = false;
    [SerializeField] private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = player.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision");
        if (other.gameObject == player)
        {
            isFollowing = true;
        }
    }
}
