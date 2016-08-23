using UnityEngine;
using System.Collections;

namespace Games
{
	/** 用户数据 */
	public class User
	{
		/** 账号 */
		public Account account;

		/** 登录 */
		public void DLogin(Account account)
		{

		}

		/** 登录成功 */
		public void OnLoginSuccess(Account account, Role role)
		{
			this.account = account;
			Game.role = role;
		}
	}
}
