using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionMaker : MonoBehaviour
{
    public Potion potion;

    public void setBase(string newPotion)
    {
        switch (newPotion)
        {
            case "Multi-Potion":
                this.potion = new MultiPotion();
                break;
            case "Red Potion":
                this.potion = new RedPotion();
                break;
            default:
                Debug.LogError("No base potion selected " + newPotion);
                break;
        }
        DisplayPotion();
    }

    public void addIngredient(string newIngredient)
    {
        switch (newIngredient)
        {
            case "Healing Grass":
                this.potion = new HealingGrass(potion);
                break;
            case "Mana Shroom":
                this.potion = new ManaShroom(potion);
                break;
            case "Energy Bug":
                this.potion = new EnergyBug(potion);
                break;
        }
        DisplayPotion();
    }

    public void DisplayPotion()
    {
        gameObject.GetComponent<Text>().text = "Health: " + potion.getHealthBuff() + "\nMana: " 
            + potion.getManaBuff() + "\nStamina: " + potion.getStamBuff();
    }
}
