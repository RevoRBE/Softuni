using System;
using System.Collections.Generic;
using System.Text;

class Engine
{
    private double speed;
    private double power;

    public double Power => power;

    public Engine(double speed, double power)
    {
        this.speed = speed;
        this.power = power;
    }
}
