using UnityEngine;

public class EvenSpeed : IMovable // полная скорость
{
    public void Move(Rigidbody rb, Vector3 finish, float speed)
    {
        if (Vector3.Distance(rb.position, finish) < 0.1f) return;
        rb.MovePosition(Vector3.MoveTowards(rb.position, finish, speed * Time.deltaTime));
    }
}
