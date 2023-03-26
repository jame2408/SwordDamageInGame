using SwordDamageInGame;

namespace SwordDamageTest;

[TestClass]
public class DamageTest
{
    private SwordDamage _swordDamage;

    [TestInitialize]
    public void SetUp()
    {
        // 建立計算傷害的物件
        _swordDamage = new SwordDamage();
    }

    [TestMethod]
    public void TestBasicDamage_RollIsGiven10_DamageShouldBe13()
    {
        GivenSwordDamagePoints(10);
        DamageShouldBe(DamageTypeEnum.Basic, 13);
    }

    [TestMethod]
    public void TestBasicDamage_RollIsGiven18_DamageShouldBe21()
    {
        GivenSwordDamagePoints(18);
        DamageShouldBe(DamageTypeEnum.Basic, 21);
    }

    [TestMethod]
    public void TestFlameDamage_RollIsGiven3_DamageShouldBe8()
    {
        GivenSwordDamagePoints(3);
        DamageShouldBe(DamageTypeEnum.Flame, 8);
    }


    private void GivenSwordDamagePoints(int swordDamageRoll)
    {
        _swordDamage.Roll = swordDamageRoll;
    }

    private void DamageShouldBe(DamageTypeEnum damageType, int expected)
    {
        var damage = _swordDamage.Damage(damageType);
        Assert.AreEqual(expected, damage);
    }
}