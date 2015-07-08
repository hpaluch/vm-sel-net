Video Mode Selection Tool - C#/Net
==================================

This is simple tool to select video mode in Windows(R).
It is written in C#/Net (4.0 for VS 2013, 2.0 for VS 2005).

Tested environment
==================

* Win XP SP3 Visual Studio 2005 Express C# Edition
* Win 7/64bit Visual Studio Express 2013 for Windows Desktop

Requirements
============

For Windows 7 or later:

* Get and install Visual Studio Express 2013 for Windows Desktop
  from https://www.visualstudio.com/en-us/products/visual-studio-express-vs.aspx
  (free registration required prior download)

For Win XP:

* Get and install Visual Studio 2005 Express C# - it is available on 
  many samples CD for programming books and magazines

Common tasks:

* Get Git for Win32 from https://www.visualstudio.com/en-us/products/visual-studio-express-vs.aspx
   When asked for CR LF conversion, choice None (checkout as-is, commit as-is)


Bulding
=======

For Visual Studio Express 2013 for Windows Desktop checkout *master* branch:

	git clone https://github.com/hpaluch/vm-sel-net.git

For Visual Studio 2005 Express checkout *vs2005_express* branch

	git clone -b vs2005_express https://github.com/hpaluch/vm-sel-net.git


* Run Visual Studio Express C#
* File -> Open Projects -> Open VmSelNet.sln file
* Press F5 to Debug application or Ctrl-F5 to run Application

Credits
=======

WINAPI Calls code comes from http://www.codeproject.com/Articles/6810/Dynamic-Screen-Resolution
Remaining code is mine :-)

