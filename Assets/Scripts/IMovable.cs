using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    public void Move(Rigidbody rb, Vector3 finish, float speed);
}
