using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteristics
{
    //Physic damage calculation
    private int maxWeaponAttack;
    private int minWeaponAttack; 
    //Magic damage calculation
    private int magicAttack;
    //Hurt calculation
    private int weaponDefense;
    private int magicDefense;
    //Damage rate
    private int accurancy;
    //Hurt rate
    private int avoidability;
    //Character's movements
    private int speed;
    private int jump;
    //Character's ability points
    public int STR;
    //public int DEX;
    public int INT;
    //public int LUK;

    public Characteristics(int STR, /*int DEX*/int INT/*int LUK*/)
    {
        //1STR = 1 max weapon attack, 10 STR = 10 max weapon attack + 1 min weapon attack, given range 2~10)
        STR = this.STR;
        this.STR = maxWeaponAttack;
        minWeaponAttack = ((1 / 10) * STR);

        //DEX = this.DEX;
        INT = this.INT;
        this.INT = magicAttack;
        magicDefense = INT * 10;
        //LUK = this.LUK;
    }
    //Get weapon attack
    public void GetWeaponAttack()
    {
        int[] twa = {minWeaponAttack, maxWeaponAttack};
    }
    
    public void GetMagicAttack()
    {
        int tma = magicAttack;
    }

}
