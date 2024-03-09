using System;
using UnityEngine;

namespace Homework
{
    public sealed class Weapon : MonoBehaviour
    {
        public int Charges
        {
            get => this.charges;
            set => this.charges = value;
        }
        public int MaxCharges
        {
            get => this.maxCharges;
            set => this.maxCharges = value;
        }
        
        [SerializeField]
        private int maxCharges;
        
        [SerializeField]
        private int charges;

        public void Fire()
        {
            //TODO: Реализовать стрельбу пулями (prefab Bullet) через метод Instantiate() при наличии зарядов,
            //а также учет оставшихся зарядов после выстрела
            //в качестве оружие рассматривать GameObject <Visual> prefab Weapon
            throw new NotImplementedException();
        }
        
        public void RestoreCharges(int numCharges)
        {
            //TODO: Реализовать пополнения зарядов, макс. количество зарядов равно MaxCharges.
            throw new NotImplementedException();
        }
    }
}

