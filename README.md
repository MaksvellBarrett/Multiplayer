Too download apk to your device in this folder install Multi1.apk


in script OVRManager.cs I commit a part of code in InitOVRManager() for many managers:
Before:
		if (instance != null)
		{
			enabled = false;
			DestroyImmediate(this);
			return;
		}
After:
		//if (instance != null)
		//{
		//	enabled = false;
		//	DestroyImmediate(this);
		//	return;
		//}