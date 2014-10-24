XBMC-Music-Video-NFO
====================

This is a modification of the jacksonliam's XBMC Music Video XML Creator

Original program written by jacksonliam
 http://forum.xbmc.org/showthread.php?tid=103954
 Modifications:

Album Name

   * Album name from Directory

Faster thumbnails
   * The code to generate the thumbnail is more efficient
   * I've also used a more recent version of ffmpeg so any optimizations done by the ffmpeg group carry over of course
   * I fill as many fields of the XBMC Music Video NFO file as possible
   * I get duration from the video file using Windows Media Player library

File Copying:

   * I've disabled File Copying in the GUI

Misc:

  * There are a few other modifications that I made for quality of life.
  * Visual Studio 2010 or 2012 broke a few things.

Notes:

 In Visual Studio 2013 there is a warning for WMPLib
 However, duration is still extracted. 
