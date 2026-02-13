## KeepMachineAwake

[![GitHub Release](https://img.shields.io/github/v/release/denoor/KeepMachineAwake?style=flat-square)](https://github.com/deNoor/KeepMachineAwake/releases/latest)

Requires Windows 7+ (x64).

This tiny program prevents Windows system and display inactivity timeouts from triggering.\
It runs as an icon in the notification area (tray). Right-click to open the context menu, double left-click to enable/disable. 

Useful if you want to keep your computer temporarily active without changing the timeout settings. You can still lock, turn off the display, or put your computer to sleep manually.\
Please remember that with the program enabled, Windows will not automatically lock on idle when you are away.

It does not consume CPU resources, only sets [ThreadExecutionState](https://learn.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setthreadexecutionstate).

### Download

Available from [Releases](https://github.com/deNoor/KeepMachineAwake/releases/latest):
- _Framework-dependent_ version: Choose this if you prefer to have the .NET Desktop Runtime installed (it will redirect you to the download page if you don't have the required version).
- _Self-contained_ version: Choose this if you don't want to install the .NET Desktop Runtime, but note that the file size is noticeably larger.
