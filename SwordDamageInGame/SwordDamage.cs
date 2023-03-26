namespace SwordDamageInGame;

public class SwordDamage
{
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;
    public int Roll { get; set; }

    public int Damage(DamageTypeEnum damageType)
    {
        if (damageType == DamageTypeEnum.Flame)
        {
            return Roll + BaseDamage + FlameDamage;
        }

        return Roll + BaseDamage;
    }
}