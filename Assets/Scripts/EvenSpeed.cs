using UnityEngine;

public class EvenSpeed : IMovable // полная скорость
{
    public void Move(Rigidbody rb, Vector3 finish, float speed)
    {
        rb.MovePosition(Vector3.MoveTowards(rb.position, finish, speed * Time.deltaTime));
    }
}
