using UnityEngine;

public interface IMovable
{
    public void Move(Rigidbody rb, Vector3 finish, float speed);
}
