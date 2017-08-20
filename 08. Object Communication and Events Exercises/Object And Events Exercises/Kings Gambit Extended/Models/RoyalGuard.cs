using System;

public class RoyalGuard : Soldier
{
    protected const int HitsToBeDead = 3;

    public event EventHandler UnderAttack;

    public RoyalGuard(string name) : base(name)
    {
    }

    public override void KingUnderAttack(object sender, EventArgs ea)
    {
        if (!IsDead)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
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