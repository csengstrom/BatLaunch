<style>
	.sst{
		font-family: Verdana;
		color: #efefef;
		font-size: 0.75em;
		display: flex;
	}
	.sst-l{
		border-top-left-radius: 0.3em;
		border-bottom-left-radius: 0.3em;
		background-color: #444; 
		padding: 3px 4px 3px 6px; margin: 0;
	}
	.sst-r{ 
		border-top-right-radius: 0.3em; 
		border-bottom-right-radius: 0.3em;
		background-color: green;
		padding: 3px 6px 3px 4px; margin: 0;
		text-shadow: 1px 1px 3px #666;
	}
</style>

# BatLaunch

<span class="sst">
<span class="sst-l">BatLaunch</span>
<span class="sst-r">v01.00.01</span>
</span>
<p>&nbsp;</p>





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




