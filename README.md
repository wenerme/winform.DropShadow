<!-- title: winform.Dropdown -->
<!-- tag: CSharp, DEMO -->
<!-- date: 2014/1/1 -->
<!-- state: published -->

winform.Dropdown
================

A winform dropdown demo

First, the idea is come from [here](http://stackoverflow.com/questions/8793445).

I go farther, write a workable class [here](https://github.com/wenerme/blog/blob/master/%E9%82%A3%E4%BA%9B%E5%B0%8F%E4%B8%9C%E8%A5%BF/%E8%80%83%E5%8B%A4%E7%B3%BB%E7%BB%9F/WindowsFormsApplication1/Dropshadow.cs).

![Old DropShadow](https://raw.github.com/wenerme/blog/master/%E9%82%A3%E4%BA%9B%E5%B0%8F%E4%B8%9C%E8%A5%BF/%E8%80%83%E5%8B%A4%E7%B3%BB%E7%BB%9F/screenshot.png "Old DropShadow")

Usage:

```C#
var f = new Dropshadow(this)
{
	BorderRadius = 40,
	ShadowColor = Color.Blue
};

f.RefreshShadow();
```

Then I rewrite the class,now it looks like this, a real DropShadow.

![](https://raw.github.com/wenerme/winform.Dropdown/master/screenshot.png 'DropShadow screenshot')

Source is **[here](https://github.com/wenerme/winform.Dropdown)**.

One thing you should know is this class not consider the `border-radius`(takes form css).

Main property is 

* ShadowColor
* ShadowV
* ShadowH
* ShadowSpread
* ShadowBlur

The property is same as css `box-shadow`, see [here](http://www.w3schools.com/cssref/css3_pr_box-shadow.asp)

These propertyies

* ShadowSpread
* ShadowBlur
* ShadowColor

require you manual call `RefreshShadow()`.

Go to the [demo project](https://github.com/wenerme/winform.Dropdown)