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

### Calculating Distance

* For calculate distance between two objects, you can use **Pythagorean theorem** :

![distance1](https://sun4-16.userapi.com/c9F7drVSsXrvYAdNiCJoMcLOcST0eIHg_f24YQ/1ROkwJ7tWWY.jpg "distance1")

![distance2](https://sun4-15.userapi.com/SgmOL09jy6KSIRCJkR8FriS8mzYfrD5y5GeBRA/29huVA-i650.jpg "distance2")

## 4. Vectors

### Introduction to Vectors

**Vectors** themselves when written coordinates look very much the same as point. However they are different.

**The point** four or five is a single location four along the **x** axis and five along the **y** measured from the **origin**.

**The vector** for five however can start from **anywhere** in space but measure four in the **x** and five in the **y** whereas a point is a single location affected can be anywhere. In space a **vector** also represent a **direction**

We can draw vector here, here and here and etc, It's just a direction and magnitude in space:

![vector1](https://sun4-17.userapi.com/FEfL49rlwUoT9xb6n2mW5Bc9PMJ7V5s-ThiAkQ/NJ9snzucYLM.jpg "vector1")

* Recall Pythagoras this theorem where the **length** is equal to the **square root** of **x squared** **plus** **y squared**. So we can find the distance between two objects a vector.:

![vector2](https://sun4-17.userapi.com/lXQ1IoQTUCODIYCpoS29y9_PLBI1Ucq1oGgC2g/5fPBQrix9zM.jpg "vector2")

* Once we know where a vector starts we can calculate the point where it ends by adding the starting point coordinated to the vector coordinates. _For example:_ 
* So if we start at **0 0** and travel along the vector **4 5** the destination Weill be **0 0 plus 4 5** which gives us **4 5**.
* If we start at the point **7 1** and travel along the **same vector** we end up at **7 1 plus 4 5** which will give us our destination point of **11 6** :

![vector3](https://sun4-10.userapi.com/nqi9K-tT7hjdhxx2F52bxn45tkbrzQGkhyjZ6Q/nnqp-Hy4Wqw.jpg "vector3")

* Vector/Point Addition & Subtraction.

![vector4](https://sun4-10.userapi.com/RIUXtxbDu5qorvvxUZqfylr7P0pBPOKEpCcKVQ/M0hCozGIybU.jpg "vector4")

![unityspec2](https://sun4-15.userapi.com/iwkF9wwTbl0eClET-rE15fHKbbFnYCQH3O8ztg/rIpY3I7Rhfk.jpg "unityspec2")

So to reiterate scaling a vector affects it in the way. If you multiply it by a whole then you're going to **increase** its size. You can see a vector and then it's multiply by 2. It remains parallel so it's pointing in the same direction. **It's just got a larger magnitude.**

If we multiply it by a value **less then 1** say point 5 then we're actually **decreasing** its size. Again it stays parallel to the original vector points in exactly the same direction but it has a **shorter** magnitude.

Now if you wanna flip the vector around so it's in exactly the opposite direction so it's facing essentially 180 degrees from what it was before, then we multiply it by a **negative** value. Multiplying it by negative one will make the magnitude stay at the same but give us the **opposite** vector. 

If we multiply by a smaller value such as zero point five or negative zero point five then we shorten the vector and we turn it around.

![vector5](https://sun4-11.userapi.com/3RmHJrLRfsomX2Sn-99jCq-uw5HulF5ed8kIRw/psj7cNK_w5U.jpg "vector5")

* Mathematically Speaking

![vector6](https://sun4-12.userapi.com/iJsMeX2EtOS2_NYlLMqxz9fshT5pT5tTDQHdTg/VDBSicGiT3Q.jpg "vector6")

* Unity Specifics

![unityspec1](https://sun4-17.userapi.com/z26nCTxy0-WDnyVob0mI-xVFbnrBhqxQLXYooQ/x-IF9eInjz8.jpg "unityspec2")

### Vectors Moving to a Point

* Find direction:

![vmove1](https://sun4-10.userapi.com/iKUdHK8OOFh02QUl-lSm8I_mWCW4OalxWkA_Sg/O0lVjgcOYbU.jpg "vmove1")

### Vector Normal Form

Calculate in the normal of a vector requires knowing the vectors direction as well as its magnitude. Now what we want to do is find another vector that is travelling in exactly the same direction buy has a **length of one.** **This is normal**

![normal1](https://sun4-17.userapi.com/3l6EKnl2qCjy8X_qN5p8sywJGHfRqAQe6rJ_wg/77gulf6ip8c.jpg "normal1")

Have a think about how you would get any number to equal 1. Well you divide it by itself. So five divided by five is going to give you one. **The way to reduce a vector down to a length of 1 is to divide each element.** Each coordinate by its magnitude. So the formula look like this:

![normal2](https://sun4-10.userapi.com/hRaxBBhKsaOpNvaeK7Vvce_SbcPSEz0V0PY_6Q/snPYzRFvFMo.jpg "normal2")

So the **V with little hat above** it means **the normal form of v the vector**. Is going to equal the **x** coordinate divided by the length and remember the length. Is denoted by the vector with the double pipes around it and then the **y** coordinate divided by its length.

![normal3](https://sun4-10.userapi.com/-oviM9--yIsQCufMCMVrhmeYkB6dlC7TvY5izQ/aKJfhF0OMq8.jpg "normal3")

### Dot Product

The dot product is the sum of the multiplication of the corresponding components or coordinate values.  
In two vectors given the vectors V and W shown below **The dot product** is found by **multiplying both x values together both y values together and then adding the result.**

![dotprod1](https://sun4-15.userapi.com/Fn5wYrRtxfk4F0HI-yfXJ8Q09z_rXYr_yX1xBQ/17cC1qZBdvk.jpg "dotprod1")

Now you're probably sitting there thinking so what this is value we are calculating main. Well it tells us a few things about the relative orientations of the vectors. Look at example below:

![dotprod2](https://sun4-11.userapi.com/IdOakT_29aBUpMIA1rH6Wm-JjWQvjz8KS3Vtog/BqqpzDQ2Zww.jpg "dotprod2")

Here:
* In **a** .In the case of **dot product** is a **positive value** and **the angle between the vectors is less than 90 degrees.** 
* In **b** the vectors are at **90 degrees to each other** and **the dot product is 0**
* for **c** the vectors make a **greater than 90 degrees** to each other and **the dot product is less than zero**.

![dotprod3](https://sun4-16.userapi.com/JQbzaq9nOki5VHjx8sa7JgJuoY6tIpAUopjeQw/px2hEVezicQ.jpg "dotprod3")