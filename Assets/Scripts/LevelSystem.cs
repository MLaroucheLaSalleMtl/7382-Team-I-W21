using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem
{
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
    private void LevelUp(int amount)
    {
        experience += amount;
        if (experience >= experienceToNextLevel)
        {
            //gain enough exp to level up
            level++;
            experience -= experienceToNextLevel;
        }
    }
}
