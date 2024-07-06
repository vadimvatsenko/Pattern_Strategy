using UnityEngine;

public class AcceleratedSpeed : MonoBehaviour, IMovable // ускорение
{
    private float _accelerate;

    public AcceleratedSpeed(float accelerate)
    {
        _accelerate = accelerate;
    }

    public void Move(Rigidbody rb, Vector3 finish, float speed)
    {
        rb.MovePosition(Vector3.MoveTowards(rb.position, finish, speed += _accelerate));
    }



}
