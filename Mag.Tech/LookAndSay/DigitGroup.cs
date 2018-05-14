namespace Mag.Tech.LookAndSay
{
    public class DigitGroup
    {
        public int Encounters { get; private set; }
        public char Digit { get; private set; }

        public DigitGroup(char digit)
        {
            Digit = digit;
            Encounters = 1;
        }

        public void Increment()
        {
            Encounters++;
        }

        public override string ToString()
        {
            return $"{Encounters}{Digit}";
        }
    }
}
