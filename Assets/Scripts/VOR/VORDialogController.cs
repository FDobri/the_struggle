using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class VORDialogController : MonoBehaviour
{
    public Text TextObject;

    public int currentLevel = -1;

    private List<VORText> currentLevelDialogs;
    private int totalNumberOfTexts = 0;
    private int prevText = 0;
    private int currentText = 0;
    private float currentTextAppearTime = 0f;

    private VORDialogs dialogs;

    void Start()
    {
        Assert.IsNotNull(TextObject, "VOR Chat panel must be set in editor");
        Assert.IsTrue(currentLevel != -1, "Current level must be set in editor");
        dialogs = new VORDialogs();

        currentLevelDialogs = dialogs.GetDialogsForLevel(currentLevel);
        totalNumberOfTexts = currentLevelDialogs.Count;

        if (totalNumberOfTexts < 1)
        {
            Destroy(gameObject);
        }

        currentTextAppearTime = currentLevelDialogs[currentText].AppearTime;
        TextObject.text = currentLevelDialogs[currentText].Text;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTextAppearTime <= 0f)
        {
            prevText = currentText;
            ++currentText;
            if (currentText >= totalNumberOfTexts)
            {
                Destroy(gameObject);
                return;
            }

            currentTextAppearTime = currentLevelDialogs[currentText].AppearTime;
            TextObject.text = currentLevelDialogs[currentText].Text;
        }

        currentTextAppearTime -= Time.deltaTime;
    }
}
