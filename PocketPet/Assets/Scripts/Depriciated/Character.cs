//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//[CreateAssetMenu(fileName = "Character", menuName = "Character")]
//public class Character : ScriptableObject
//{
//    protected string charName; // name of the character
//    protected string desc; // description of the character and their purpose
//    protected int age; // manages how long the character stays alive
//    protected int hth; // physical wellbeing of the character
//    protected int hap; // mental wellbeing of the character

//    /* SAVE - future combat TBD
//        protected int atk; // attack power
//        protected int def; // reduces damage from enemy attacks
//        protected int mana; // produces special attacks
//    */

//    // Setter and Getter methods
//    public string GetCharName()
//    {
//        return charName;
//    }

//    public void SetCharName(string aName)
//    {
//        charName = aName;
//    }

//    public string GetDescription()
//    {
//        return desc;
//    }

//    public void SetDescription(string newDesc)
//    {
//        desc = newDesc;
//    }

//    public int GetAge()
//    {
//        return age;
//    }

//    public void SetAge(int newNum)
//    {
//        age = newNum;
//    }

//    public void AddAge()
//    {
//        age += 1;
//    }

//    public int GetHealth()
//    {
//        return hth;
//    }

//    public void SetHealth(int newNum)
//    {
//        hth = newNum;
//    }

//    public int GetHappy()
//    {
//        return hap;
//    }

//    public void SetHappy(int newNum)
//    {
//        hap = newNum;
//    }

//    private void GenerateStats(int tot, int mini, int maxi)
//    /// <summary>
//    /// Generates the stats for health and happiness.
//    /// </summary>
//    /// <param name="tot">The randomly generated numbers must add up to this number. </param>
//    {
//        while (GetHappy() + GetHealth() != tot)
//        {
//            SetHealth(Random.Range(mini, maxi));
//            SetHappy(Random.Range(mini, maxi));
//        }
//    }

//    public Character(string newName)
//    {
//        charName = newName;
//        desc = "";
//        SetAge(0);
//        GenerateStats(20, 2, 10);
//    }

//    public Character(string newName, string descrip)
//    {
//        charName = newName;
//        desc = descrip;
//        SetAge(0);
//        GenerateStats(20, 2, 10);
//    }

//}
