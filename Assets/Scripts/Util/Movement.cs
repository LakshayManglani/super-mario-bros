using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 2.5f;

    private bool _isLeft = false;

    private void Update()
    {
        HorizontalMovement();
    }

    private void HorizontalMovement()
    {
        Vector3 nextPosition;
        if (_isLeft)
        {
            nextPosition = Vector3.left;
        }
        else
        {
            nextPosition = Vector3.right;
        }

        transform.position += nextPosition * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isLeft = !_isLeft;
    }
}
