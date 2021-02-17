using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LevelWindow : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Button addExperienceButton;

    public Action ClickFunc = null;
    private Text levelText;
    private Image experienceBarImage;
    private LevelSystem levelSystem;

    private void Start()
    {
        addExperienceButton = transform.Find("ExperienceAddBtn50").GetComponent<Button>();
    }
    private void Awake()
    {
        levelText = transform.Find("LevelTxt").GetComponent<Text>();
        experienceBarImage = transform.Find("ExperienceBar").Find("Bar").GetComponent<Image>();

    }
    public void OnPointerClick(PointerEventData eventData)
    {

    }
    private void SetExperienceBarSize(float experienceNormalized)
    {
        experienceBarImage.fillAmount = experienceNormalized;
    }
    private void SetLevelNumber(int levelNumber)
    {
        levelText.text = "LEVEL\n" + (levelNumber + 1);
    }
    public void SetLevelSystem(LevelSystem levelSystem)
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
