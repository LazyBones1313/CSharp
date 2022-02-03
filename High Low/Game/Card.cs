public class Card
{
    public int currentCard = 0;
    public int nextCard = 0;

    public Card()
    {
        
    }

    public int Deal()
    {
        Random random = new Random();
        int aCard = random.Next(1,13);
        return aCard;
    }

    public string Compare()
    {
        if (nextCard <= currentCard)
        {
            return "l";
        }
        else
        {
            return "h";
        }
    }

}