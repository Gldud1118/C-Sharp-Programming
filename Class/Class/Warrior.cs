using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Warrior
    {
        private const int MAX_HEALTH = 500;
        private const int MAX_MANA = 50;
        private const int MAX_STAMINA = 200;

        private int mHealth = MAX_HEALTH; //밖에서 보지 못하는 멤버 변수
        private int mMana = MAX_MANA;
        private int mStamina = MAX_STAMINA;

        public Warrior(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public int Health
        {
            get
            {
                return mHealth;
            }
            set
            {
                mHealth = value;

                if(mHealth < 0)
                {
                    mHealth = 0;
                }

                if(mHealth > MAX_HEALTH)
                {
                    mHealth = MAX_HEALTH;
                }
            }
        }

        public int Mana
        {
            get
            {
                return mMana;
            }
            set
            {
                mMana = value;

                if (mMana < 0)
                {
                    mMana = 0;
                }

                if (mMana > MAX_HEALTH)
                {
                    mMana = MAX_HEALTH;
                }
            }
        }

        public int Stamina
        {
            get
            {
                return mStamina;
            }
            set
            {
                mStamina = value;

                if (mStamina < 0)
                {
                    mStamina = 0;
                }

                if (mStamina > MAX_HEALTH)
                {
                    mStamina = MAX_HEALTH;
                }
            }
        }
    }
}
