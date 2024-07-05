using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCar : Car
{
    public float _acceleration;
    public virtual void Start()
    {
        _model = "YellowCar";
        _movable = new AcceleratedSpeed();
        _acceleration = 5f;
        _speed = 0f;
    }

    public virtual void Update()
    {
        _model += _acceleration;
        _movable.Move(_rb, _finish, _speed);
    }
}
