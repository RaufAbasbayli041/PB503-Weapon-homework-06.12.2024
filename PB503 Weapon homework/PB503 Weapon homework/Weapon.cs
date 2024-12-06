using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Weapon_homework
{
    public class Weapon
    {
        private int _magazineCapacity;
        private int _currentBullet;
        public Mode ShootMode { get; set; }
        public int MagazineCapacity
        {
            get
            {
                return _magazineCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _magazineCapacity = value;
                }
            }
        }
        public int CurrentBullet
        {
            get
            {
                return _currentBullet;
            }
            set
            {
                if (value >= 0)
                {
                    _currentBullet = value;
                }
            }
        }
        public void Shoot()
        {
            if (ShootMode == Mode.Single)
            {                
                CurrentBullet -= 1;
                Console.WriteLine("shoot");               
            }

            else if (ShootMode == Mode.Burst)
            {
                CurrentBullet -= 3;
                Console.WriteLine("shoot shoot shoot");                            
            }
            else
            {
                Console.WriteLine("Only single or burst mode has shoot mode");
            }
        }

        public void Fire()
        {
            if (ShootMode == Mode.Automatic)
            {
                    CurrentBullet = 0;
                    Console.WriteLine("fire");                                    
            }
            else
            {
                Console.WriteLine("Only automatic mode has fire method");
            }
        }

        public int GetRemainBulletCount()
        {
            return MagazineCapacity - CurrentBullet;
        }

        public int Reload()
        {
            CurrentBullet = MagazineCapacity;
            return MagazineCapacity;
        }

        public void ChangeFireMode(string lastMode)
        {
            if (string.IsNullOrEmpty(lastMode))
            {
                throw new CustomExceptions("error,enter right weapon mode");
            }
            if (Mode.Burst.ToString().ToLower().Contains("bu") && lastMode.ToLower().Contains("bu"))
            {
                ShootMode = Mode.Burst;
                Console.WriteLine("Weapon has changed to burst mode");
            }
            else if (Mode.Single.ToString().ToLower().Contains("si") && lastMode.ToLower().Contains("si"))
            {
                ShootMode = Mode.Single;
                Console.WriteLine("Weapon has changed to single mode");
            }
            else if (Mode.Automatic.ToString().ToLower().Contains("au") && lastMode.ToLower().Contains("au"))
            {
                ShootMode = Mode.Automatic;
                Console.WriteLine("Weapon has changed to automatic mode");
            }

        }

        public override string ToString()
        {
            return $"Shoot mode - {ShootMode}, magazine capacity - {MagazineCapacity}, current bullet - {CurrentBullet}";
        }
       
    }
}
