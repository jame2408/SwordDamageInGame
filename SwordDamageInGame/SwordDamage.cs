namespace SwordDamageInGame;

public class SwordDamage
{
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;
    public int Roll { get; set; }

    public int Damage(DamageTypeEnum damageType)
    {
        if (damageType==DamageTypeEnum.Magic)
        {
            return (int)Math.Round(Roll * 1.75M, 0) + BaseDamage + FlameDamage;
        }
        
        if (damageType == DamageTypeEnum.Flame)
        {
            return Roll + BaseDamage + FlameDamage;
        }

        return Roll + BaseDamage;
    }
}