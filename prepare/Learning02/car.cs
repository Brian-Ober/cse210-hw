using System;
public class Car
{
    public string _make;
    public string _model;
    public int _mileage;
    public int _gallonsOfFuel;

    public Owner owner;



    public int RemainingMile()
    {
        return _gallonsOfFuel * _mileage;
    }
}