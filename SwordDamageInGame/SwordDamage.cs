namespace SwordDamageInGame;

public class SwordDamage
{
    private const int BaseDamage = 3;
    public int Roll { get; set; }

    public int Damage()
    {
        return Roll + BaseDamage;
    }
}