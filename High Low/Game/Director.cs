public class Director
{
    string userChoice = "";
    Card card = new Card();
    bool isPlaying = true;
    int score = 300;
    string keepPlaying = "";

    public void StartGame()
    {
        while (isPlaying && score != 0)
        {
            GetInputs();
            CompareCards();
            DoOutputs();
        }
    }

    public void GetInputs()
    {
        card.currentCard = card.Deal();
        Console.WriteLine("");
        Console.WriteLine($"The number on the current card is: {card.currentCard}");
        Console.Write("Do you think the number on the next card is higher or lower? [h/l]: ");
        userChoice = Console.ReadLine();
    }

    public void CompareCards()
    {
        card.nextCard = card.Deal();
        string compare = card.Compare();

        if (compare == userChoice)
        {
            score += 100;
        }
        else
        {
            score -= 75;
        }
    }

    public void DoOutputs()
    {
        Console.WriteLine($"The number on the next card was: {card.nextCard}");
        Console.WriteLine($"Your score is: {score}");
        Console.Write($"Would you like to keep playing? [y/n]: ");
        keepPlaying = Console.ReadLine();
        isPlaying = (keepPlaying == "y");
    }

}