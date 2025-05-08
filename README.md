## KeepMachineAwake

[![GitHub Release](https://img.shields.io/github/v/release/denoor/KeepMachineAwake?style=flat-square)](https://github.com/deNoor/KeepMachineAwake/releases/latest)

Requires Windows 7+, x64.

This tiny program prevents Windows system and display inactivity timeouts from triggering.\
It runs as an icon in notification area (tray). Right click to open context menu, double left click to enable/disable. 

Useful if you want to keep your computer temporarily active without changing the timeouts settings. You can still lock, turn off the display, or put your computer to sleep manually.\
Please remember that with the program enabled, Windows will not automatically lock on idle when you are away.

Does not consume CPU, only sets [ThreadExecutionState](https://learn.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setthreadexecutionstate).

### Download

from [Releases](https://github.com/deNoor/KeepMachineAwake/releases/latest)
- _framework-dependent_ version when you prefer to have .NET Desktop Runtime installed, (it will point to the download page if you don't have the required version).
- _self-contained_ version when you don't want to install .NET Desktop Runtime, but the file size is noticeably larger.
