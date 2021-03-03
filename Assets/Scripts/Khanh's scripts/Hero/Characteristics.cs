using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteristics
{
    //Physic damage calculation
    private int weaponAttack;
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
        weaponAttack = 2 * STR;
        weaponDefense = 3 * STR;

        //DEX = this.DEX;
        INT = this.INT;
        magicAttack = INT;
        magicDefense = INT * 10;
        //LUK = this.LUK;
    }
    //Get weapon attack
    public int GetWeaponAttack()
    {
        int twa = weaponAttack;
        return weaponAttack;
    }
    
    public int GetMagicAttack()
    {
        int tma = magicAttack;
        return magicAttack;
    }

}
