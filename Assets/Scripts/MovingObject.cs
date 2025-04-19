using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] Transform point1;
    [SerializeField] Transform point2;
    [SerializeField] float moveSpeed;

    Transform target;

    void Start()
    {
        target = point1;
    }

    void Update()
    {
        if (transform.position == point1.position)
            target = point2;
        else if (transform.position == point2.position)
            target = point1;
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
