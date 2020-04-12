# Math-For-Games-using-Unity
 Mathematics for Computer Games Development using Unity

## 1. Introduction and Welcome

### Properties of Right Angle Triangles

![right angle triangle](https://sun9-12.userapi.com/lXtL2FO7JALx-BBrHQIn4Ofn1IlYeLQapLLGOA/uswXBPIIdlQ.jpg "right angle triangle")

A right angle triangle has three sides denoted the hypotenuse for the longest side (the side opposite the right angle) and two others known as the adjacent or opposite depending on their relationship to the angles. For example, for the angle **β**, **b** would be opposite and **a** would be adjacent.  For the other angle the roles of a and b would be reversed.

The formula are:

![formulas](https://sun9-15.userapi.com/E_qhssr9e7hUZRlHHdRgF2_cvk32y0qrOIhAEA/J3sCXgMhBcs.jpg "formulas")

## 2. Bitwise Operations

![basicbitwice](https://sun4-16.userapi.com/JPocCvFKrA0U5d5bIcDdVwtL9CSB-eY2RdbsSg/zxkE-4anhAQ.jpg "basicbitwise")

* Example of use this:

![example1](https://sun9-55.userapi.com/wAFSCJheGi387c-jD0j5yQbdsTVn7BRCeSLWmA/8kxb97G7-Lc.jpg "example1")

### Bit Packing

For example: We have a three values **A = 1001111**, **B = 10110**, **C = 0011** (Length of these values = 16); And we want to pack these values into 16-bit value X:

* A = 1001111 packing into 16-bit X value:

![packingA](https://sun4-17.userapi.com/STqp1hhtfzqy_0mij5I8KWP3hPyF0kLUlrEE-A/iiBq10tBORU.jpg "packingA")

* B = 10110 packing into 16-bit X Value:

![packingB](https://sun4-15.userapi.com/3hvpC61qV_9KHOgFXMegRNpwaW_7gZAjIdIqJw/dVjc-EhOypU.jpg "packingB")

* C = 0011 packing into 16-bit X value:

![packingC](https://sun4-16.userapi.com/4GYWu32MPRX5plED8mIXmg8CEPmEnl5_weYqSg/sc4uZAxkxcs.jpg "packingC")

* Another Example: put three values into INTEGER (32-bit value):

![packingInt](https://sun4-10.userapi.com/QxN1ilg4--XRv4T1GwViz9J2tebRdpJNnCdOjA/vRNUMu5zqO0.jpg "packingInt")

### Bit UnPacking

For unpacking bits we need create a mask that will get all of the you're interested in for each value, and shifting to right. Example:

* UnPack to A(7-bit) from X(16-bit):

![UnpackingA](https://sun4-17.userapi.com/vA4TGqxo5DL1DOE_5-GXUws0HwgLicJFKPIZTg/C3-OsBEjuuE.jpg "UnpackingA")

![UnpackingA2](https://sun4-17.userapi.com/K__FqKGX7v0f7wo_Xyg58TuyNeCxZC_4mmGF-g/dx02AhC7x9U.jpg "UnpackingA2")

* UnPack to B(5-bit) from X(16-bit):

![packingB](https://sun4-10.userapi.com/ONdpd0iVbubqtPMGHQM9u9POLP1NzpPCuP8aBw/SU5YYTRMWxI.jpg "packingB")

* UnPack to C(4-bit) from X(16-bit):

![packingC](https://sun4-17.userapi.com/rU09mIrHj4Av37fLyh7g0wHDz3DxyugGs4OKqg/QOJjX6T9v20.jpg "packingC")

* If you need to Toggling of Bits, you need use **XOR (^)** operation

![togglinXOR](https://sun4-17.userapi.com/WGr1CdaMistavHrQK9Fcmb7sEA2l2VmdS5idMw/QEM96hJae7A.jpg "togglingXOR")

## 3. Locations

### Cartesian Coordinates & Points

* A point in the Cartesian space is denoted by its distance along the **x** axis followed by its distance along the **y** coordinate for the point is written **X Y**. 
For Example:

![cartCoord1](https://sun4-17.userapi.com/qeZOOrvqPDJ-N7DAiHXVXb6SA3LeIIVwIE_B3w/kmGfo3rmvnw.jpg "cartCoord1")

The **X** coordinate must and always comes first followed by the **Y**. The defining property of Cartesian space is that a single coordinate only identifies a single location.

* Cartesian coordinates can be defined for all dimensions of space from the **one dimensional** lumber line that has a single axis to the **two dimensional** system we've just looked at with **x** and **y** axes to the **three dimensional** system that add the addition of the **Z** axis to any number of dimensions that are difficult to visualise.

* Simple example of three dimensional space system (X,Y,Z):

![cartCoord2](https://sun4-12.userapi.com/ybhPfiphOKWsFFLRWFNFkTtTaNA9t9LqBvCRpQ/qPuqBIsqwj0.jpg "cartCoord2")

* In games we generally are most concerned with representations in two and three dimensions. That is points stored as **X Y** for **2D** and points stored as **X Y Z** for **3D**

![cartCoord3](https://sun4-16.userapi.com/fyyKo9AVqgqy1ja0hczxH-EQshGgQbauVfbY4Q/3WXuCN9l9pw.jpg "cartCoord3")

* Basically we can think of space as a large rectangular prism with X Y and Z dimensions like this (3D space):

![cartCoord4](https://sun4-17.userapi.com/Z-E_WSGrtBPIyDoe6Mxed9gE2dpzzzMHTbOxHA/vqpyV4Ji0_8.jpg "cartCoord4")