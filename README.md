# BatLaunch

BatLaunch is a windows console app written in C#. When executed, it looks for 
the file `batlaunch.bat` in the `.bat` subfolder of `batlaunch.exe` and 
executes it.

### Motivation

I wanted to put a shortcut in the Windows Taskbar and/or the Windows Start 
Screen but I could not find an easy way to do that. 

Maybe a registry hack could accomplish what I wanted, but I tend to avoid 
registry hacks (*most of the time*).

### Use

- Make as many folders as you need containing `batlaunch.bat` with a `.bat` 
subfolder. 
- Prepare and place your `batlaunch.bat` file in the `.bat` subfolder.
- Create a shortcut for `batlaunch.exe` 
	- Name it anything you please.
	- Change the shortcut icon as desired.
- Place the shorcut on either the 
	- Task Bar
	- Windows Start Screen
	- Desktop or any other folder

### Folder Structure

*Key*: (F) *means a tree node is a* ***F***<em>older</em> 

[//]: # (Box/Tree drawing sometimes won't render)

```txt
any-folder (F) 
├╴batlaunch.exe
├╴.bat (F)
│  ├╴ batlaunch.bat   
│  └╴(backup batch files)
└╴README.md
```




