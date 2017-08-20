using System;

public abstract class Soldier
{
    public event EventHandler UnderAttack;

    public Soldier(string name)
    {
        this.Name = name;
        this.IsDead = false;
    }

    public string Name { get; private set; }

    public bool IsDead { get; set; }

    public int HitsDone { get; set; }

    public abstract void KingUnderAttack(object sender, EventArgs ea);

    public abstract void OnUnderAttack(object sender, EventArgs ea);

    public abstract void OnUnderAttack();
}