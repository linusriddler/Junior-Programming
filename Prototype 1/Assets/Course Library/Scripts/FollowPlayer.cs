using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 0, 0);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}
