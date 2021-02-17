using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem
{
    public event EventHandler OnExperienceChanged;
    public event EventHandler OnLevelChanged;
    private int level;
    private int experience;
    private int experienceToNextLevel;

    //initiate level system constructor
    public LevelSystem()
    {
        level = 0;
        experience = 0;
        experienceToNextLevel = 100;
    }

    //basic level system logic
    public void LevelUp(int amount)
    {
        experience += amount;
        if (experience >= experienceToNextLevel)
        {
            //gain enough exp to level up
            level++;
            experience -= experienceToNextLevel;
            if (OnLevelChanged != null) OnLevelChanged(this, EventArgs.Empty);
        }
        if (OnExperienceChanged != null) OnExperienceChanged(this, EventArgs.Empty);
    }

    public int GetLevelNumber()
    {
        return level;
    }

    public float GetExperienceNormalized()
    {
        return experience / experienceToNextLevel;
    }
}
