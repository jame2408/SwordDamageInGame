namespace SwordDamageService;

public class SwordDamage
{
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;
    public int Roll { get; set; }

    public int Damage(DamageTypeEnum damageType) => RandomDamagePoint(damageType)
                                                    + BaseDamage
                                                    + IsFlameDamage(damageType);

    private int RandomDamagePoint(DamageTypeEnum damageType) =>
        (int)Math.Round(Roll * GetDamageMultiplier(damageType), 0);

    private decimal GetDamageMultiplier(DamageTypeEnum damageType) => damageType == DamageTypeEnum.Magic ? 1.75M : 1;

    private int IsFlameDamage(DamageTypeEnum damageType) => damageType == DamageTypeEnum.Basic ? 0 : FlameDamage;
}