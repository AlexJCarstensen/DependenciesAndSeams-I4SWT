namespace ECS.Legacy
{
    internal interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}