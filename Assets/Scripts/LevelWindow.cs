using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelWindow : MonoBehaviour
{
    [SerializeField] private Button addExperienceButton;

    private Text levelText;
    private Image experienceBarImage;
    private LevelSystem levelSystem;

    private void Start()
    {
        Button addExperienceBtn = addExperienceButton.GetComponent<Button>();
        //addExperienceBtn.onClick.AddListener(levelSystem.LevelUp(50));
    }
    private void Awake()
    {
        levelText = transform.Find("LevelTxt").GetComponent<Text>();
        experienceBarImage = transform.Find("ExperienceBar").Find("Bar").GetComponent<Image>();

        //transform.Find("ExperienceAddBtn50").GetComponent<Button>().onClick = levelSystem.LevelUp(50);
    }

    private void SetExperienceBarSize(float experienceNormalized)
    {
        experienceBarImage.fillAmount = experienceNormalized;
    }

    private void SetLevelNumber(int levelNumber)
    {
        levelText.text = "LEVEL\n" + (levelNumber + 1);
    }

    private void SetLevelSystem(LevelSystem levelSystem)
    {
        //Set the LevelSystem object
        this.levelSystem = levelSystem;

        //Update the starting values
        SetLevelNumber(levelSystem.GetLevelNumber());
        SetExperienceBarSize(levelSystem.GetExperienceNormalized());

        //Subscribe to the changed events
        levelSystem.OnExperienceChanged += LevelSystem_OnExperienceChanged;
        levelSystem.OnLevelChanged += LevelSystem_OnLevelChanged;
    }

    private void LevelSystem_OnLevelChanged(object sender, System.EventArgs e)
    {
        //Level changed, update next
        SetLevelNumber(levelSystem.GetLevelNumber());
    }

    private void LevelSystem_OnExperienceChanged(object sender, System.EventArgs e)
    {
        //Experience changed, update bar size
        SetExperienceBarSize(levelSystem.GetExperienceNormalized());
    }
}
