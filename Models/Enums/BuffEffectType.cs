using System;

namespace GameServer.Templates
{
  [Flags]
  public enum BuffEffectType
  {
    SkillSign = 0, //技能标志
    StatusFlag = 1, //状态标志
    CausesSomeDamages = 2, //造成伤害
    StatsIncOrDec = 4, //属性增减
    DamageIncOrDec = 8, //伤害增减
    CreateTrap = 16, //创建陷阱
    LifeRecovery = 32, //生命回复
    TemptationBoost = 64, //诱惑提升
    Riding = 128 //坐骑状态
  }
}
