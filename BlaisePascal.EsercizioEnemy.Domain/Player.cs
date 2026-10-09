using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.EsercizioEnemy.Domain
{
    public class Player
    {
        public string Name { get; set; }
        public int Health
        {
            get;
            private set
            {
                if (IsAlive)
                {
                    if (value < 0)
                    {
                        Health = 0;
                        IsAlive = false;
                    }
                    else if (value > MaxHealth) Health = MaxHealth;
                    else Health = value;
                }
            }
        }
        public int Level
        {
            get;
            private set
            {
                if (value < 1) throw new ArgumentException("Level must be greater than 1");
                else Level = value;
            }
        }
        public int Experience
        {
            get;
            private set
            {
                if (value < 0) throw new ArgumentException("Experience must be greater than 0");
                else Experience = value;
            }
        }
        public int MaxHealth
        {
            get;
            private set
            {
                if (value <= 0) throw new ArgumentException("MaxHealth must be greater than 0");
                else MaxHealth = value;
            }
        }
        /*public bool IsAlive { 
            get 
            {
                if (Health == 0) return false;
                else return true;
            }
        }
        */
        public bool IsAlive { get; private set; }
        public int Gold { get; private set; }

        public void AddExperience(int experience)
        {
            if (experience > 0)
            {
                while (Experience + experience >= 100)
                {
                    Level += 1;
                    experience -= 100;
                }
            }
        }
        public void ResetExperience()
        {
            Experience = 0;
        }
        public void TakeDamage(int damageTaken)
        {
            Health -= damageTaken;
        }

        public void Heal(int healthHealed)
        {
            Health += healthHealed;
        }

        public void AddGold(int addedGold)
        {
            Gold += addedGold;
        }

        public void ResetHealth()
        {
            IsAlive = true;
            Health = MaxHealth;
        }
        public Player(string name)
        {
            Name = name;
            Experience = 0;
            Level = 1;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }
    }
}