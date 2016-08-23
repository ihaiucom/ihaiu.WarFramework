using UnityEngine;
using System.Collections;

namespace Games
{
	/** 游戏对外接口，集合游戏数据、模块引用 */
	public class Game
	{
		/** 游戏配置数据 */
		public static GameModel mode = new GameModel();

		/** 用户数据 */
		public static User user = new User();
		/** 角色数据 */
		public static Role role = new Role();

	}
}
