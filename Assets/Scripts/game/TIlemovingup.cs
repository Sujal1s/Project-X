using UnityEngine;

public class TIlemovingup : MonoBehaviour
{
    public float moveDistance = 4.5f; // Distance to move in the x-axis
    public float moveSpeed = 2f; // Speed of movement

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool moveup = true;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + new Vector3(0 , moveDistance, 0);
    }

    void Update()
    {
        if (moveup)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (transform.position == targetPosition)
            {
                moveup = false;
                targetPosition = startPosition - new Vector3( 0, moveDistance, 0);
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (transform.position == targetPosition)
            {
                moveup = true;
                targetPosition = startPosition + new Vector3(0 , moveDistance, 0);
            }
        }
    }
}