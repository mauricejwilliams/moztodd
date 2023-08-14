using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public int MaxHealth = 100;
    public int CurrentHealth = 0;
    public int MaxFood = 100;
    public int CurrentFood = 0;

    public Vector3 RespawnLocation = new Vector3(0,1.71f,0);
    public GameObject DeadScreen;


    public Image HpBar;
    public Image FoodBar;
    public float FoodTimerRaise = 0f;
    public float addfood = 0;
    public Gradient gradient;
    public Gradient gradient2;

    void Start()
    {
        CurrentHealth = MaxHealth;
        CurrentFood = MaxFood;
        InvokeRepeating("Starve", 2, 3);
        checkGradient();
    }

    void checkGradient()
    {
        HpBar.color = gradient.Evaluate(HpBar.fillAmount);
        FoodBar.color = gradient2.Evaluate(FoodBar.fillAmount);
    }

    void EatFood(string FoodType)
    {
        
            if (FoodType == "Apple")
            {
                CurrentFood += 5;
                addfood += 3;
            }
            if (FoodType == "Bread")
            {
                CurrentFood += 15;
                addfood += 10;
            }
        

        if (CurrentFood > 100)
        {
            CurrentFood = 100;
        }
    }


    void Starve()
    {
        CurrentFood -= 1;
        if (CurrentFood <= 0)
        {
            NoFoodStarvingNow();
            CurrentFood = 0;
        }
    }


    void KeyPress()
    {

         if (Input.GetKeyDown("t"))
          {
            FoodConsumed("Apple");
          }
          if (Input.GetKeyDown("y"))
          {
            FoodConsumed("Bread");
          }
        if (Input.GetKeyDown("p"))
        {
            RespawnLocation = transform.position;
        }


        if (Input.GetKeyDown("r"))
        {
            RespawnLocation = transform.position;
        }
    }

    public void FoodConsumed(string FoodType)
    {
        EatFood(FoodType);
    }

    public void UpdateHealthBar(float MaxHealth, float CurrentHealth)
    {
        HpBar.fillAmount = CurrentHealth / MaxHealth;
    }

    public void UpdateFoodBar(float Maxfood, float Currentfood)
    {
        FoodBar.fillAmount = Currentfood / Maxfood;
    }


    // Update is called once per frame
    void Update()
    {

        checkGradient();

        KeyPress();


        UpdateHealthBar(MaxHealth, CurrentHealth);
        UpdateFoodBar(MaxFood, CurrentFood);

     if (CurrentHealth <= 0)
        {
            Die();
        }

     if (addfood > 0)
        {
            FoodTimerRaise += Time.deltaTime;
        }
        
        if (FoodTimerRaise >= 1)
        {
            if (CurrentHealth < 100)
            {
                CurrentHealth += 1;
                addfood -= 1;
                FoodTimerRaise = 0f;
            }
        }

        if (CurrentHealth >= 100)
        {
            addfood = 0;
            CurrentHealth = 100;

        }





    }


    private void NoFoodStarvingNow()
    {
        if (CurrentHealth > 0)
        {
            CurrentHealth -= 1;
        }
        
    }



    void Die()
    {
        DeadScreen.SetActive(true);
    }

    public void Respawn()
    {
        DeadScreen.SetActive(false);
        transform.position = RespawnLocation;
        CurrentHealth = 100;
        CurrentFood = 100;
    }

}
