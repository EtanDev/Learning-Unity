using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int health;
    int power;
    string name;

    public Player()
    {

    }

    public Player(int health, int power, string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;

    }

    public void Info()
    {
        Debug.Log("Player created, health: " + this.health + " Power " + this.power + " name: " + this.name);
    }

    public void Attack()
    {
        Debug.Log("The Player is attacking");
    }

}
