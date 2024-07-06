using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCar : Car
{
    private float _acceleration;
    public override void Start()
    {
        base.Start();
        _model = "YellowCar";
        _movable = new AcceleratedSpeed(_acceleration = 0.01f);
        _speed = 0.001f;
    }

    public virtual void Update()
    {
        _movable.Move(_rb, _finish, _speed);
    }
}
