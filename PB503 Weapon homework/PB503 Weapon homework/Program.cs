namespace PB503_Weapon_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon1 = new Weapon()
            {
                ShootMode = Mode.Single,
                MagazineCapacity = 30,
                CurrentBullet = 30,
            };

            int menuNumber;

            do
            {
                Console.WriteLine("0.Get Information");
                Console.WriteLine("1.Shoot");
                Console.WriteLine("2.Fire");
                Console.WriteLine("3.Get Remain Bullet Count ");
                Console.WriteLine("4.Reload");
                Console.WriteLine("5.Change Fire Mode");
                Console.WriteLine("6.Exit");
                Console.WriteLine("7.Edit");
                Console.WriteLine("=======================================");

                menuNumber = Convert.ToInt32(Console.ReadLine());
                switch (menuNumber)
                {
                    case 0:
                        Console.WriteLine($"weapon1: {weapon1.ToString()}");
                        Console.WriteLine();
                        break;
                    case 1:
                        weapon1.Shoot();
                        Console.WriteLine();
                        break;
                    case 2:
                        weapon1.Fire();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine($"remain bullet count - {weapon1.GetRemainBulletCount()}");
                        Console.WriteLine();
                        break;
                    case 4:
                        weapon1.Reload();
                        Console.WriteLine();
                        break;
                    case 5:
                        weapon1.ChangeFireMode(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("8.Change to the new magazine capacity");
                        Console.WriteLine("9.Change number of current bullets");
                        int editMenu = Convert.ToInt32(Console.ReadLine());

                        if (weapon1.ShootMode == Mode.Automatic || weapon1.ShootMode == Mode.Burst)
                        {
                            if (editMenu is 8)
                            {
                                int newMagazineCapacity = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"Magazine capacity has changed from {weapon1.MagazineCapacity} to {newMagazineCapacity}");
                                weapon1.MagazineCapacity = newMagazineCapacity;
                                Console.WriteLine();
                            }
                            else if (editMenu is 9)
                            {
                                int changedCurrentBullet = Convert.ToInt32(Console.ReadLine());
                                if (changedCurrentBullet <= weapon1.MagazineCapacity)
                                {
                                    Console.WriteLine($"Number of current bullets changed from {weapon1.CurrentBullet} to {changedCurrentBullet}");
                                    weapon1.CurrentBullet = changedCurrentBullet;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Entered current bullets number cant'be more than magazine capacity!");
                                    Console.WriteLine();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Error. Choose correct edit mode");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Change single mode to the burst mode or automatic mode!");
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Choose correct menu number");
                        Console.WriteLine();
                        break;
                }
            } while (menuNumber != 6);
        }
    }
}
