using UnityEngine;
using System.Collections;

namespace Games
{
	public class BaseModel : BaseScript
	{
		/** 获取关卡配置 */
		virtual public StageConfig GetStageConfig(int id)
		{
			return Game.mode.war.GetStageConfig(id);
		}
		
		
		/** 获取技能配置 */
		virtual public SkillConfig GetSkillConfig(int id)
		{
			return Game.mode.skill.GetSkillConfig(id);
		}
		
		
		/** 获取英雄配置 */
		virtual public HeroConfig GetHeroConfig(int id)
		{
			return Game.mode.hero.GetHeroConfig(id);
		}

		
		/** 获取物品配置 */
		virtual public ItemConfig GetItemConfig(int id)
		{
			return Game.mode.item.GetItemConfig(id);
		}
	}
}