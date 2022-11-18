using GuessNumber;

public class SecretNumber
{
    private readonly int _generatedRandomNumber;
    public int GeneratedRandomNumber => _generatedRandomNumber;

    public SecretNumber()
    {
        _generatedRandomNumber = StaticRandom.Instance.Next(1, 101);
    }

    public int Validation(int? inputValue)
    {
        if (inputValue == _generatedRandomNumber)
        {
            return 0;
        }
        else if (inputValue > _generatedRandomNumber)
        {
            return -1;
        }
        else if (inputValue < _generatedRandomNumber)
        {
            return 1;
        }
        else throw new ArgumentException("The input must be (int).");
    }
}
