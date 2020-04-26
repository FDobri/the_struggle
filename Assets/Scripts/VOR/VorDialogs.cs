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
        Dialogs_Level_1.Add(new VORText("Use A and D to move.", 3.0f));
        Dialogs_Level_1.Add(new VORText("Press space to jump.", 3.0f));
        Dialogs_Level_1.Add(new VORText("I sense some trouble in the outter world.", 3.0f));
        Dialogs_Level_1.Add(new VORText("'How?' you ask?", 2.0f));
        Dialogs_Level_1.Add(new VORText("Your goal is to reach the portal to a parallel universe...", 4.0f));
        Dialogs_Level_1.Add(new VORText("You'll find your answers there.", 2.0f));
        Dialogs_Level_1.Add(new VORText("Play your adventure!", 2.0f));

        Dialogs_Level_2.Add(new VORText("Welcome to a parallel universe.", 4.0f));
        Dialogs_Level_2.Add(new VORText("Your emotions will spawn and try to hurt you!", 4.0f));
        Dialogs_Level_2.Add(new VORText("Run from them or fight them, what's your choice?", 4.0f));
        Dialogs_Level_2.Add(new VORText("Press the left click button to attack!", 3.0f));

        Dialogs_Level_3.Add(new VORText("Back to normal huh?", 3.0f));
        Dialogs_Level_3.Add(new VORText("Guess some of your emotions just got real.", 4.0f));
        Dialogs_Level_3.Add(new VORText("There's no escape now, you got to fight them!", 4.0f));

        Dialogs_Level_4.Add(new VORText("Oh...really? Here again? What a loser.", 4.0f));
        Dialogs_Level_4.Add(new VORText("Just kidding, I don't sense much...trouble here, or not?", 4.0f));
        Dialogs_Level_4.Add(new VORText("Stay safe, keep the distance! #stayHome", 3.0f));

        Dialogs_Level_5.Add(new VORText("It's you against your emotions here?", 3.0f));
        Dialogs_Level_5.Add(new VORText("If your emotions win over you...", 3.0f));
        Dialogs_Level_5.Add(new VORText("Who knows what will happen?", 3.0f));
        Dialogs_Level_5.Add(new VORText("Be brave and win this!", 3.0f));
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
    



