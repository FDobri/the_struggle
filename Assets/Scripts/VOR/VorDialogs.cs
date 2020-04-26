using System.Collections;
using System.Collections.Generic;


public class VORText
{
    public string Text;
    public float AppearTime;

    public VORText(string text, float appearTime)
    {
        Text = text;
        AppearTime = appearTime;
    }
};

public class VORDialogs
{
    // Level 1 texts
    public List<VORText> Dialogs_Level_1 = new List<VORText>();
    public List<VORText> Dialogs_Level_2 = new List<VORText>();
    public List<VORText> Dialogs_Level_3 = new List<VORText>();
    public List<VORText> Dialogs_Level_4 = new List<VORText>();
    public List<VORText> Dialogs_Level_5 = new List<VORText>();

    public VORDialogs()
    {
        Dialogs_Level_1.Add(new VORText("Hello...", 3.0f));
        Dialogs_Level_1.Add(new VORText("I am your Voice of Reason!", 3.0f));
        Dialogs_Level_1.Add(new VORText("I am your guide to what's normal...or not?", 3.0f));
        Dialogs_Level_1.Add(new VORText("Nothing is real here, yet everything is real.", 5.0f));
        Dialogs_Level_1.Add(new VORText("Use the A and D keys on your keyboard to move...", 5.0f));
        Dialogs_Level_1.Add(new VORText("And press space to jump.", 3.0f));
        Dialogs_Level_1.Add(new VORText("See? This isn't real since you can actually jump and move, unlike in real life!", 5.0f));
        Dialogs_Level_1.Add(new VORText("To defend yourself use your sword...", 3.0f));
        Dialogs_Level_2.Add(new VORText("Press the left click button to attack!", 3.0f));
        Dialogs_Level_1.Add(new VORText("Wait...What's going on?", 3.0f));
        Dialogs_Level_1.Add(new VORText("I sense some trouble in the outter world.", 3.0f));
        Dialogs_Level_1.Add(new VORText("'How?' you ask?", 2.0f));
        Dialogs_Level_1.Add(new VORText("Fast, reach the portal at the end of this level...", 4.0f));
        Dialogs_Level_1.Add(new VORText("You'll find your answers there.", 2.0f));

        Dialogs_Level_2.Add(new VORText("There has been a breach of some kind...", 4.0f));
        Dialogs_Level_2.Add(new VORText("It's like the universes are mixing...", 4.0f));
        Dialogs_Level_2.Add(new VORText("It feels like we are inside of your emotions, but bad ones...", 4.0f));
        Dialogs_Level_2.Add(new VORText("Your negative emotions will spawn and try to hurt you...", 4.0f));
        Dialogs_Level_2.Add(new VORText("It's just like listening to Katy Perry..", 4.0f));
        Dialogs_Level_2.Add(new VORText("Run from them or fight them, what's your choice?", 4.0f));
        Dialogs_Level_2.Add(new VORText("How long has it been since you've been running tho?", 4.0f));
        Dialogs_Level_2.Add(new VORText("Need to find a better option...hmmm...ah, got it!", 4.0f));
        Dialogs_Level_2.Add(new VORText("Play FF7 remake, that's a game, not this one!", 4.0f));

        Dialogs_Level_3.Add(new VORText("Back to normal huh?", 3.0f));
        Dialogs_Level_3.Add(new VORText("Guess some of your emotions just got real.", 4.0f));
        Dialogs_Level_3.Add(new VORText("Lorem ipsum dolor sit.", 4.0f));
        Dialogs_Level_3.Add(new VORText("Why are you even listening to me?", 4.0f));
        Dialogs_Level_3.Add(new VORText("public void print(std::string greetingsMessage)", 4.0f));
        Dialogs_Level_3.Add(new VORText("The breach is strong here, you must do something fast!", 4.0f));
        Dialogs_Level_3.Add(new VORText("Can't liiiiiive, if living is without youuu!", 4.0f));
        

        Dialogs_Level_4.Add(new VORText("Oh...really? Here again? What a loser.", 4.0f));
        Dialogs_Level_4.Add(new VORText("Just kidding, I don't sense much...trouble here, or not?", 4.0f));
        Dialogs_Level_4.Add(new VORText("Stay safe, keep the distance! #stayHome #staySafe", 3.0f));
        Dialogs_Level_4.Add(new VORText("#drinkFanta #notSponsored #definitelyNotSponsored", 3.0f));

        Dialogs_Level_5.Add(new VORText("It's you against your emotions here?", 3.0f));
        Dialogs_Level_5.Add(new VORText("If your emotions win over you...", 3.0f));
        Dialogs_Level_5.Add(new VORText("Who knows what will happen?", 3.0f));
        Dialogs_Level_5.Add(new VORText("I don't really care, just finish this quickly...", 3.0f));
        Dialogs_Level_5.Add(new VORText("I need to go to the bathroom and feed the fish!", 3.0f));
    }

    public List<VORText> GetDialogsForLevel(int level)
    {
        switch (level)
        {
            case 1:
                return Dialogs_Level_1;

            case 2:
                return Dialogs_Level_2;

            case 3:
                return Dialogs_Level_3;

            case 4:
                return Dialogs_Level_4;

            case 5:
                return Dialogs_Level_5;

            default:
                return null;
        }
    }
}
    



