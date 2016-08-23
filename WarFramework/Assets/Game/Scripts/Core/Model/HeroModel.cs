using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Games
{
	/** 英雄配置数据  */
	public class HeroModel : BaseModel
	{
		/** 英雄配置 */
		public Dictionary<int, HeroConfig> heros = new Dictionary<int, HeroConfig>();

		/** 获取英雄配置 */
		override public HeroConfig GetHeroConfig(int id)
		{
			HeroConfig config = null;
			if(!heros.TryGetValue(id, out config))
			{
				Debug.LogErrorFormat("[Error] 获取英雄配置失败 HeroModel.GetHeroConfig({0})", id);
			}

			return config;
		}
	}
}