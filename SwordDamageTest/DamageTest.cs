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
        DamageShouldBe(13);
    }

    [TestMethod]
    public void TestBasicDamage_RollIsGiven18_DamageShouldBe21()
    {
        GivenSwordDamagePoints(18);
        DamageShouldBe(21);
    }

    private void GivenSwordDamagePoints(int swordDamageRoll)
    {
        _swordDamage.Roll = swordDamageRoll;
    }

    private void DamageShouldBe(int expected)
    {
        var damage = _swordDamage.Damage();
        Assert.AreEqual(expected, damage);
    }
}