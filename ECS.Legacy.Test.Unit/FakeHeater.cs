namespace ECS.Legacy.Test.Unit
{
    public class FakeHeater :IHeater
    {
        public bool HeaterState { get; set; } = false;
        public bool RunSelfTest()
        {
            return true;
            
        }

        public void TurnOff()
        {
            HeaterState = false;
        }

        public void TurnOn()
        {
            HeaterState = true;
        }
    }
}