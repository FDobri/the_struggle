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
        Dialogs_Level_1.Add(new VORText("Hello", 3.0f));
        Dialogs_Level_1.Add(new VORText("I am your Voice of Reason", 5.0f));
        Dialogs_Level_1.Add(new VORText("Play your adventure", 6.0f));

        Dialogs_Level_2.Add(new VORText("Welcome to level 2", 3.0f));
        Dialogs_Level_2.Add(new VORText("Continue your adventure", 5.0f));

        Dialogs_Level_3.Add(new VORText("Level 3", 5.0f));

        Dialogs_Level_4.Add(new VORText("Level 4", 5.0f));

        Dialogs_Level_5.Add(new VORText("Level 5", 5.0f));
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
    



