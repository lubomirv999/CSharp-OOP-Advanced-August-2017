using System;

public class Footman : Soldier
{
    protected const int HitsToBeDead = 2;

    public event EventHandler UnderAttack;

    public Footman(string name) : base(name)
    {
    }

    public override void KingUnderAttack(object sender, EventArgs ea)
    {
        if (this.HitsDone == HitsToBeDead)
        {
            IsDead = true;
        }
        else
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }

    public override void OnUnderAttack(object sender, EventArgs ea)
    {
        if (this.UnderAttack != null)
        {
            UnderAttack(this, new EventArgs());
        }
    }

    public override void OnUnderAttack()
    {
        HitsDone++;

        if (this.HitsDone == HitsToBeDead)
        {
            IsDead = true;
        }
    }
}