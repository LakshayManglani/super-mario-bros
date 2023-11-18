using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool isLeft = false;
    public float speed = 2.5f;

    void Update()
    {
        Vector3 nextPosition;
        if (isLeft)
        {
            nextPosition = Vector3.left;
        }
        else
        {
            nextPosition = Vector3.right;
        }

        transform.position += nextPosition * Time.deltaTime * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isLeft = !isLeft;
    }
}
