namespace Iscronium.Models;

public class Actions
{
    public interface IEquipped
    {
        public void PutOn();
        public void TakeOff();

    }
}