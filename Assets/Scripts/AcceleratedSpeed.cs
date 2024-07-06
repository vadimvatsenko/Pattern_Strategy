using UnityEngine;

public class AcceleratedSpeed: IMovable // ускорение
{
    private float _accelerate;

    public AcceleratedSpeed(float accelerate)
    {
        _accelerate = accelerate;
    }

    public void Move(Rigidbody rb, Vector3 finish, float speed)
    {
        if (Vector3.Distance(rb.position, finish) < 0.1f) return;

        _accelerate += (speed * Time.deltaTime);
        Debug.Log(_accelerate);
        rb.MovePosition(Vector3.MoveTowards(rb.position, finish, _accelerate));

    }

}
