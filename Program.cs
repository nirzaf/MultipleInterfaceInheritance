using System.Runtime.CompilerServices;

public interface IVehicle
{
    void Move();
}

public interface ICar
{
    void Move();
}


public class Audi : IVehicle, ICar
{
    void IVehicle.Move()
    {
        throw new NotImplementedException();
    }

    void ICar.Move()
    {
        throw new NotImplementedException();
    }
}

