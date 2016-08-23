using UnityEngine;
using System.Collections;
namespace Games
{
	#if SCRIPTABLE
	public class BaseScript : ScriptableObject
	#else
	public class BaseScript 
	#endif
	{
		/** 重置, 用在对象池 */
		virtual public void CReset()
		{
		}
		
		/** 释放,一般用在销毁或对象池释放 */
		virtual public void CRelease()
		{
		}
		
		/** 销毁内存分配 */
		virtual public void CDealloc()
		{
		}
	}

}