# Math-For-Games-using-Unity
 Mathematics for Computer Games Development using Unity

## Content:
* [1 - Introduction and Welcome](#intro)
  * [1.1 - Properties of Right Angle Triangles](#prop_triangle)
* [2 - Bitwise Operations](#bitwise_operations)
  * [2.1 - Bit Packing](#packing)
  * [2.2 - Bit Unpacking](#unpacking)
* [3 - Locations](#locations)
  * [3.1 - Cartesian Coordinates & Points](#cartesian_coords)
  * [3.2 - Calculating Distance](#calculating_distance)
* [4 - Vectors](#vectors)
  * [4.1 - Vectors Moving to a Point](#vector_moving)
  * [4.2 - Vector Normal Form](#vector_normal_form)
  * [4.3 - Dot Product](#dot_product)
  * [4.4 - Vector Rotations](#vector_rotations)
  * [4.5 - Cross Product](#cross_product)
  * [4.6 - Moving from 2D to 3D](#from_2d_to_3d)
* [5 - Intersections](#intersections)

## 1. Introduction and Welcome <a name="intro"></a>

### Properties of Right Angle Triangles <a name="prop_triangle"></a>

![right angle triangle](https://sun9-12.userapi.com/lXtL2FO7JALx-BBrHQIn4Ofn1IlYeLQapLLGOA/uswXBPIIdlQ.jpg "right angle triangle")

A right angle triangle has three sides denoted the hypotenuse for the longest side (the side opposite the right angle) and two others known as the adjacent or opposite depending on their relationship to the angles. For example, for the angle **β**, **b** would be opposite and **a** would be adjacent.  For the other angle the roles of a and b would be reversed.

The formula are:

![formulas](https://sun9-15.userapi.com/E_qhssr9e7hUZRlHHdRgF2_cvk32y0qrOIhAEA/J3sCXgMhBcs.jpg "formulas")

## 2. Bitwise Operations <a name="bitwise_operations"></a>

![basicbitwice](https://sun4-16.userapi.com/JPocCvFKrA0U5d5bIcDdVwtL9CSB-eY2RdbsSg/zxkE-4anhAQ.jpg "basicbitwise")

* Example of use this:

![example1](https://sun9-55.userapi.com/wAFSCJheGi387c-jD0j5yQbdsTVn7BRCeSLWmA/8kxb97G7-Lc.jpg "example1")

### Bit Packing <a name="packing"></a>

For example: We have a three values **A = 1001111**, **B = 10110**, **C = 0011** (Length of these values = 16); And we want to pack these values into 16-bit value X:

* A = 1001111 packing into 16-bit X value:

![packingA](https://sun4-17.userapi.com/STqp1hhtfzqy_0mij5I8KWP3hPyF0kLUlrEE-A/iiBq10tBORU.jpg "packingA")

* B = 10110 packing into 16-bit X Value:

![packingB](https://sun4-15.userapi.com/3hvpC61qV_9KHOgFXMegRNpwaW_7gZAjIdIqJw/dVjc-EhOypU.jpg "packingB")

* C = 0011 packing into 16-bit X value:

![packingC](https://sun4-16.userapi.com/4GYWu32MPRX5plED8mIXmg8CEPmEnl5_weYqSg/sc4uZAxkxcs.jpg "packingC")

* Another Example: put three values into INTEGER (32-bit value):

![packingInt](https://sun4-10.userapi.com/QxN1ilg4--XRv4T1GwViz9J2tebRdpJNnCdOjA/vRNUMu5zqO0.jpg "packingInt")

### Bit UnPacking <a name="unpacking"></a>

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

## 3. Locations <a name ="locations"></a>

### Cartesian Coordinates & Points <a name ="cartesian_coords"></a>

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

### Calculating Distance <a name="calculating_distance"></a>

* For calculate distance between two objects, you can use **Pythagorean theorem** :

![distance1](https://sun4-16.userapi.com/c9F7drVSsXrvYAdNiCJoMcLOcST0eIHg_f24YQ/1ROkwJ7tWWY.jpg "distance1")

![distance2](https://sun4-15.userapi.com/SgmOL09jy6KSIRCJkR8FriS8mzYfrD5y5GeBRA/29huVA-i650.jpg "distance2")

## 4. Vectors <a name="vectors"></a>

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

### Vectors Moving to a Point <a name="vector_moving"></a>

* Find direction:

![vmove1](https://sun4-10.userapi.com/iKUdHK8OOFh02QUl-lSm8I_mWCW4OalxWkA_Sg/O0lVjgcOYbU.jpg "vmove1")

### Vector Normal Form <a name="vector_normal_form"></a>

Calculate in the normal of a vector requires knowing the vectors direction as well as its magnitude. Now what we want to do is find another vector that is travelling in exactly the same direction buy has a **length of one.** **This is normal**

![normal1](https://sun4-17.userapi.com/3l6EKnl2qCjy8X_qN5p8sywJGHfRqAQe6rJ_wg/77gulf6ip8c.jpg "normal1")

Have a think about how you would get any number to equal 1. Well you divide it by itself. So five divided by five is going to give you one. **The way to reduce a vector down to a length of 1 is to divide each element.** Each coordinate by its magnitude. So the formula look like this:

![normal2](https://sun4-10.userapi.com/hRaxBBhKsaOpNvaeK7Vvce_SbcPSEz0V0PY_6Q/snPYzRFvFMo.jpg "normal2")

So the **V with little hat above** it means **the normal form of v the vector**. Is going to equal the **x** coordinate divided by the length and remember the length. Is denoted by the vector with the double pipes around it and then the **y** coordinate divided by its length.

![normal3](https://sun4-10.userapi.com/-oviM9--yIsQCufMCMVrhmeYkB6dlC7TvY5izQ/aKJfhF0OMq8.jpg "normal3")

### Dot Product <a name="dot_product"></a>

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

This useful in games will allows us to determine where one game object is in relation to another game object.

For example:

![dotprod4](https://sun4-11.userapi.com/F8EUZbt6nT_3PAjEHNf5nkOQR_xbG1t_1gqgOg/UBG_sCVdV9U.jpg "dotprod4")

If we will interest in is turning the tank to face the fuel before it moves towards it, we will have *the first problem** we are faced with is ti find the **actual angle** between the forward facing direction of the tank and the direction to the fuel.

![dotprod5](https://sun4-10.userapi.com/SCZ_WZObgUMBom6LqUX-W4KolVFs4Mr6A3j7uQ/9ARVU70PnbU.jpg "dotprod5")

The relationship between the dot product and the angle between the vectors, and angle between the vectors can be expressed like this:

![dotprod6](https://sun4-16.userapi.com/5dxctG2pabtBky7XJrA86d2ow8YVg6qlKJY9hQ/i_xMlYXut6A.jpg "dotprod6")

### Vector Rotations <a name="vector_rotations"></a>

**To rotate** a vector about an angle the **x and y** components need to be manipulated with **sine and cosine** functions such that the **new x value of the vector becomes** the **original x** value **multiplied by the coastline of the Ange minus the original y value multiplied by the sine of the value** and **the y value becomes the original x value multiplied be the sine of the angle plus the original y value multiplied by the cosine of the angle**

![rotate1](https://sun4-16.userapi.com/BYavK9YkC126SYEQz9LoAjzoz-C-ejFMeq8GpQ/M4zKoG0xBOY.jpg "rotate1")

If we apply its into our code, we'll get a wrong clockwise rotation, because we rotating in Right-Handed Coordinates, while Unity uses Left-Handed Coordinate. 

![rotate2](https://sun4-15.userapi.com/qXi52IqEX8RcHVlItf6BMXkrVmUp-HCMHQcpww/nL6aZJO6jig.jpg "rotate2")

### Cross Product <a name="cross_product"></a>

![cross1](https://sun4-17.userapi.com/zJbNAcZdz-5TILA5vhotCzMtYPCOCTRSe1c4CA/hLJK-Ti3rpw.jpg "cross1")

Resulting vector is one that is perpendicular to the other two. Now the interesting thing about the cross product is that it's **not reversible**. **v cross W does not equal w cross V**. In fact if you perform the operation the other way around you will still get evicted that is perpendicular to both V and W, but it will be facing in the other direction...

![cross2](https://sun4-17.userapi.com/QsqvDUa-2CbVQpXSpvBApt9w6GWTuxdqFFMioA/QvdnmooITTg.jpg "cross2")

...  and we can exploit this fact in determining which way our tanks should turn.

![cross3](https://sun4-15.userapi.com/6DWOIvDN7IOfx_EaTn8YOVe219MTsktoxfbYiA/I_9ZNrpCl6U.jpg "cross3")

### Moving from 2D to 3D <a name="from_2d_to_3d"></a>

In 3D space all rules are same:

![3d1](https://sun4-10.userapi.com/LURQIi3a7vnejfW7yfCTXnQG0X2axW3hVBM1RQ/KDBM4uyd2jE.jpg "3d1")

![3d2](https://sun4-16.userapi.com/ogr_FwXwBLqftT3WRQ-11TC-9VdaExtFk_zkaw/PQdofTVjGTE.jpg "3d2")

![3d3](https://sun4-17.userapi.com/AjJwJWLcKkZCpsaagiyYs4ZV9kkFaNkuoUYLKw/qKjCZLKw6Qw.jpg "3d3")

![3d4](https://sun4-15.userapi.com/gCP0WgXfPDqAuFEQFbjTKSVwnkGdjRusVQ1DZA/n7VMFbgyGUY.jpg "3d4")

![3d5](https://sun4-15.userapi.com/fzKj86FkuF_hk1y9lYShkIGyTFxDbPKzoK6puw/eyN-TlAg5EA.jpg "3d5")

![3d6](https://sun4-15.userapi.com/URczifO4ab6t0tggEXW8yKP6vxVpNBWn2Ykujg/0hnorCquqAc.jpg "3d6")

## 5. Intersections <a name="intersections"></a>

### Lines, Line Segments and Rays

**Vector**. It's Represented by an arrow in space with no position but has a **direction and magnitude**.

**A Line**. A line is defined by two points, let's call these **a** and **b**. A line passes through these points and continues to infinity in both directions.

**A Line Segment**. A line segment on the other hand is a small part of a line that terminates on both end.

**A Ray**. Well a ray is kind of like a vector in that it has a direction though unlike a vector it has s tarting point and continues off into infinity.

![lines](https://sun4-17.userapi.com/LCNKYB0fUBhAh3ZaFWIIlr40TdtP-NzOCvJb3Q/UUoFySbO8xU.jpg "lines")

* Parametric From

Think of a line or at least a line segment as a point and a vector. We know that for the point on the **other end** of this line segment the equation to find it it **the point plus the vector**. In this case that's **B equals A plus V**. So if B equals A plus V, then what might the formula for the point halfway along this line be. Well it's going to be a plus half of V. Ok.. What's about a point that is a quarter of the way along the line segment from A towards B? Well, it's going to be **A plus V multiplied by her point five or where we're taking a quarter of V and adding it to A**.

![params1](https://sun4-15.userapi.com/UR7i9dJHxFfAaMdoUedqlQFWguXq0l3FNJZ2kA/DQaY5hvCitg.jpg "params1")

In fact, **any point on this line** second be found by **adding some multiple of the vector to A**. **At A the multiple will be zero** and **at B it will be one**. We can therefore say that **any point on the line** can be calculated with **B equals A plus V multiplied by t**. **t ranges between 0 and 1 inclusive**. And **B = A + v*t is parametric form of the equation of a line segment**. And the line formula can be used for all **(lines and rays)** the only **differing factor is the range of T**.

![params2](https://sun4-10.userapi.com/l68saZaNYMzj4Eo1nS-hQOpSAbTpr5DUAiK_gg/AmGqt-6Xay0.jpg "params2")

So we need to write the equation like this instead. Now it reads that **the line at position t is equal to A or the starting point plus the Vector multiplied by t**.

![params3](https://sun4-16.userapi.com/irNIwauIZq9jZIDXR3cCEY3JZz4P7jyRKlYaFg/_6niHrrHyYI.jpg "params3")

Example:

![params4](https://sun4-10.userapi.com/IOb3Vk9XswbziJcAn7bhhgQrYWdm6wZCAUJqBA/XJ_E9mm-G3Q.jpg "params4")

### Planes

While a line can be defined  by a point and one Vector, **A plane is defined by one point and two vectors thus.**

![plane1](https://sun4-17.userapi.com/L6AgBWb-HdzxiX5TUVCQfBw8bIUv0R1T4VSZDw/zOpUVAOeloI.jpg "plane1")

In proper mathematical therms, A plane is very much the same as a line as **it goes to infinity in all directions**.

A polygon on the other hand is a finite space. 

Any point on the plane can be defined by a combination of various lengths of the two given vectors. For example:

![plane2](https://sun4-17.userapi.com/nqxbw7mVJclqMlk77WW_28qzadQn6Gkj2birzA/txo_fIJCWCA.jpg "plane2")
![plane3](https://sun4-15.userapi.com/mRZ_FeyabXLu7jHTul49WhfXGsCwgwxAOIBWIg/VsWAGn-V85Y.jpg "plane3")
![plane4](https://sun4-16.userapi.com/f0DRfp-eeYpj-UImSfKCGP2WTwp1eMa4Uk1rkQ/pllc2aiDejo.jpg "plane4")

Parametric form for a plane is thus. **P at S , T equals A plus V multiplied by S plus U multiply by T**.

![plane5](https://sun4-11.userapi.com/-T2C6JdBp5-tpKbuJc5ZL5wOSa03c_mee7ipxg/YaqY7jrBRj0.jpg "plane5")

For example, if we need find a parametric form for a plane that passes through the point 0 0 0, 5 4 6, and -10 7 3 . First we need to work out the two vectors and so we can use these points to do that but we must create the vectors starting at the same point 0 0 0. Is just easiest for doing calculations.

![plane6](https://sun4-10.userapi.com/QL-78mdKQkZaQO9UBUqfNGCZieapZLSpYvWxUw/m_ZpDR3EILM.jpg "plane6")

### Intersection of Two Line Segment

Consider two lines one defined by the **point A** and a **vector V** and other defined by the **point B** and **vector U**. 

In parametric form the line for **A** is **A + vt** , and the line for **B** is **B + us**. These lines will intersect where the results for these two equations are equal. So we can define the intersection point as **A + vt = B + us**.

To simplify this further in order to help us solve it we are going to remove the points **A and BB** and **replace them with vector**. Here we can rearrange the equation of vt equals B minus A plus us. Now we know from determining vectors that B minus A because it points is going to give us a vector from the point A to B. So we'll call this new vector **c** and substitute it into the equation in the place of B minus A.

![inter1](https://sun4-11.userapi.com/TDTMbUZRypOesb9V91vqSENp3gwWZXec5y1llA/NywmarAE3Z0.jpg "inter1")

Look another principle of 2D vector. **The 2D Perp Vector**.

The 2D perp vector is a vector that sits perpendicular that's 90 degrees to another. And it's easily found by **simply exchanging the x and y values and negating on of them.**

The notation for the perp vector is the vector name, in this case **v**, super scripted with an **upside down T** that signifies the perpendicular set of lines.

Fo example: for the vector **9 7** - the perp vector is **-7 9**.

![perp1](https://sun4-17.userapi.com/KaEQUF_WZJ57f210z0zzzsqZ9RjB80L-6-O4Og/hB6_rXQ5hq4.jpg "perp1")

In the case of negating the original x value we end up with a perp then is 90 degrees chounreclockwise in rotation from the original v.

Among the useful properties of perp vectors that we are going to exploit to solve the issue at hand, witch is finding the line line intersection.. 
* **Is that the dot product between a vector and its perp will be zero, as any two vectors that produce a dot product of zero are at 90 degrees to one another**;

Another useful property:
* **is that the. For product of a perp vector and another can be rearranged to be negative of the perp of the other. And the dot product of the original vector**

![perp2](https://sun4-16.userapi.com/2RRF6-Lvkdr_5nvTtvKvmtjWfsN0p44zO2feEA/Ac2NDDTOYs0.jpg "perp2")

Let's take a quick look at worked examples of these:

* Thirst let's confirm that the dot product of a perp and its vector equal 0

![perp3](https://sun4-17.userapi.com/l2AvG_-gOXYnAuAoaMhHqe2sLRQ2DcAemoa6Lw/jsDQQchJgSM.jpg "perp3")

* now let's work the other property

![perp4](https://sun4-10.userapi.com/WKqyLPLm2mf3R2fONUMLcASujhFIWiTIhFiYgQ/1HC_s9xVYnA.jpg "perp4")

Now we know about the perp vector and these two properties we can return to figuring out where the lines intersect:

Now we can't solve either **t** or **s** unless we get rid of one of them. So let's go for the **t** first and I mean let's keep the **t** and get rid of the **s((. This means that we need to eliminate the term **us** in the equation. Now we have just learned a way to make this vector us zero. Yes it's multiplying itself with its perp. So we multiply both sides of the equation with the perp of u.

![perp5](https://sun4-15.userapi.com/6ISL3hhfvhHt90ns-HsFT_D3NZ-H9-AwBZgmgQ/5PC7d8IF4yE.jpg "perp5")

In this case we have use second property of perps that can eliminate the negative bu swapping around which vector is the perp.

![perp6](https://sun4-15.userapi.com/t6Xv6GqwyPyhUWx0sR_NECuldexSqefLS7LQlg/t56yr6rBsJg.jpg "perp6")

![perp7](https://sun4-16.userapi.com/4zWgwAFSdS3VpYAmalzB7d4KBbeBCMKEPlDy-g/XRtDLmP9_Go.jpg "perp7")

**So the only time 2D lines won't intersect at some point is if they are parallel. We can tell if the lines are parallel as the perp of one of the vectors will sit at 90 degrees to the other** This means in this case, that u perp dot v would give us a zero.

![perp8](https://sun4-15.userapi.com/TehOtWfBx9L5zAGwKwsZkDJMHXr9AXGkV3SWwA/qOD3I5fpIao.jpg "perp8")

### Line-Plane Intersections

If we wanted a term and where a line Ray or line-segment intersects with a plane, we need to find: A + w*t = B + v*a + u*e:

![lpint1](https://sun4-15.userapi.com/w0oC3m2SDgSzB_lyDnCem8rPcbXIpax6p1Ls5Q/zsN-WuJUXCg.jpg "lpint1")

For solving this we need:

First we need to change the way we look at the plane that involves returning to the idea of normals that we touched on briefly when looking at the cross product recall. ** The cross product of two vectors gives a third vector that sits at 90 degrees to the other**. 
**n** will always sit perpendicular to the plane divined by **v** and **w**. Now because **n** is perpendicular to both, **v and w** we know that **n dot w equals 0 and n dot v = 0**.

If you find a couple of points on the plane by which to calculate the vector w you can then use these and substitute them into the previous equation to get n dot B minus p equals zero.:

![lpint2](https://sun4-17.userapi.com/Wo4IpNb0PNk3R1XnrVC1gSmk1mJ2B9fWlZQp0w/nl2ZhD8rvwU.jpg "lpint2")

A line also have a point Normal Form. All you need it the starting and ending points of a line-segment on that line calculate the vector between them and then find the normal.

![lpint3](https://sun4-10.userapi.com/bmY5omMlw4DkG16ej2KAk0YvxU5vFGGpFMTG8g/_uJrgW_tZB4.jpg "lpint3")

Now back to the problem at hand.

To simplify thing we express the plain in point normal form as n dot (H - B) equals zero, **where** **H is the hit point**.

Now we know that line for some value of t is going to intersect the hit point. So therefore the hit point also equals A plus w multiplied by t. Substituting this into the plane's normal form, we get n dot A plus w t minus B equals zero;

![lpint4](https://sun4-11.userapi.com/aTQmG7XkCcw_-heyDciF3Tb-RzZz02449MQ2XQ/vGYKtbi7HkI.jpg "lpint4")

* let's work though an example of finding this hit point by hand.

**we have**:
![lpint5](https://sun4-17.userapi.com/cXs9xk4yAoH7fKYqoUfPMqmGgG1mbYYyH7DNiQ/p4JQKVQ3-cY.jpg "lpint5")

* First, we need a couple of vectors that will define a plane. So let's calculate **v** vector from **B** and **D** and **u** the vector from **B** to **E**. Remember the vector is the destination point minus the starting point. Therefore v will be D - B;
![lpint6](https://sun4-11.userapi.com/RoeprIjT4SzvN32JIDsQUc0Ue6zaP_yXVuTMGA/gDfmN40lp8E.jpg "lpint6")

* Well, let's move on and find out what **w** is **w** is the vector from **A** to **C**:
![lpint6](https://sun4-10.userapi.com/NnPPX1pDC6MqfiISbZWQjxXJ_BVl9yrdlov4yQ/-0G3WnthzSo.jpg "lpint6")

* Now to work out the value of **t** . According to our equation, we're only missing **n** which is the normal to the plane. The normal is calculated from the cross product of the vectors that define the plane. Which in the case **v and u**.
![lpint7](https://sun4-17.userapi.com/TCFqSdn0dTy6dgZEjBn7JazQ1NoauKZ0Dzlm6A/UhhH-DTgFCE.jpg "lpint7")

* finally get this:
![lpint8](https://sun4-10.userapi.com/vmlA_s8p5zfzjh_flX_5A_2S2bNfeW3zFYQJVg/qHJeWallowM.jpg "lpint8")

## 6. Affine Transformation

### An Introduction to Matrices

Matrices are a fundamental concept in computer graphics and are using in pretty much all calculations involving moving and locating objects.

A matrix is a rectangular array of numbers with a set amount of rows and columns.

Examples:
![matrix1](https://sun4-12.userapi.com/V6Br4sPXxWzKZlV-1V4vMig8iuBe6COkEa764A/KcsHmx4knBo.jpg "matrix1")

* a one row matrix is called a **row vector**, and a one column matrix is called  **column vector**

![matrix2](https://sun4-16.userapi.com/t7iTi-EjEi_LijVw0Rc1oAkyQ9MI3zq8s_uc2A/pJ5djthQqfc.jpg "matrix2")

A square matrix which is the most common type used in computer game calculations. Is one with the same number of rows as it has columns. Two default share matrices often used: are the **zero matrix** and **the identity matrix.

![matrix3](https://sun4-16.userapi.com/MWj-HQgpOcYtMCUhO35s88wwN6QEGQERv85XdQ/aMOJW3D0bL4.jpg "matrix3")

**Matrix calculations**
* Scaling

 ![matrix4](https://sun4-15.userapi.com/MJaAOUxO0kmP6A0hv954lRgjDV-PreT2vmpNqg/fWEwffI_uSU.jpg "matrix4")

* Addition and Substruction

Matrices can also be added and subtracted **but only when both matrices are the same shape**. That means they must have the same number of rows and columns.

![matrix5](https://sun4-15.userapi.com/yP83X_aMIqU12STcEyz6e0bOGFRCqSZNtyR_Xw/gq8_oLUtMcE.jpg "matrix5")

Another concept to use when working with matrices is that of the transposed version. Because sometimes you need to turn a matrix on its side. The transpose of a matrix is **when the values in the rows are interchanged with values in the columns**.

![matrix6](https://sun4-17.userapi.com/-0SqU9UVMbK7UYVkgF4JDCh5FN2-IX1MY65NoQ/Y1QakzDT3kU.jpg "matrix6")

Matrix multiplication is the crux of many many many operations that occur in computer graphics and games. Two matrices **can only be multiplied together if the can form**. That means that the number of columns in the first Matrix **must** equal the number of rows in the second Matrix. 

Multiplication matrix is easy. We basically take each row of the first Matrix and find the dot product of it and the columns of the second matrix. 

* First calculation will be between first row of first matrix and first column of second matrix.

![matrix7](https://sun4-15.userapi.com/2MTGZqfuO-VTSFxLhRLLUTC1vnrzXHkziGYIrA/x2vis-3mtUo.jpg "matrix7")

* Now we do the first row and the second column.

![matrix8](https://sun4-16.userapi.com/rZs2XmgFe0coIZTv7V7W5ET0TZS4mWr3AHhdfA/Rw07-YLUytE.jpg "matrix8")

* and so on.. Finally we get this matrix:

![matrix9](https://sun4-16.userapi.com/A3f3UZ_ryIcWC7BJWMYVKweI2jFANu_nZ_L8rg/Q-A-aOnKsZ0.jpg "matrix9")

### Homogeneous Coordinates

A vector in such a frame is defined in pretty much the same way except its components are measured according ti its local axis. The x component is a multiple of the x axis the y component is a multiple of the y axis and the z component is a multiple of the z axis. The origin is doesn't matter, because remember vectors don't have a location.

![homo1](https://sun4-10.userapi.com/lI-DjqI4rAonEDOeJZar6Rcnfz_txen8r5Q4wQ/5WTK8yQAb0Y.jpg "homo1")

A point on the other hand is always defined relative to the origin. It still has an x y and z component, but it is location dependent. When it was relative to the origin 0 0 0 as we always assumed before x y and z values were fine. But move the origin and the point becomes origin plus p.x*x + p.y*y + p.z*z

![homo2](https://sun4-11.userapi.com/S222C9rbDZkewQLP5nuXa1xOrBW-8WLnhZQaYQ/0X-C05zUAkE.jpg "homo2")

Now it's useful in calculations if vectors and points are represented in the same format. So instead of x y z like we have been using in the past, we're moving to x y z and w. Where **w** is 0 for a vector and 1 for a point.

![homo3](https://sun4-16.userapi.com/Y0yY698YZyn2PlrvfUezQq9KljC9lYTZ7tA3Wg/1xSFIm8kbBQ.jpg "homo3")

Let me show you why. We can rewrite our vector and point equations like this to include the **w** value. Then w is 0 for v, the origin is not included in the calculation. As anything multiplied by zero will give a zero. But when it is one for the point, the origin will then e taken into consideration. We can write Matrix format for the **v** calculation and Matrix format for the **p** calculation:

![homo4](https://sun4-12.userapi.com/EPePYKKqT6e1wfJoyakiwdPViwWrBnHkzTU9pw/rH-E0mtlxK8.jpg "homo4")

* Homogeneous Representation:

![homo5](https://sun4-17.userapi.com/P0Xy_3CtILfcQ3WT5VyhDrFoYwWV3pSU1hwfYA/S5nY595FRhU.jpg "homo5")

### Transformations

**Translation**

Translation is the movement of an object along one or more axes and changes its position. We do this by adding a vector to a point to get from point P to point Q, where Q = P + v. We can switch to matrix form:

![transl2](https://sun4-11.userapi.com/TDzH99HoCgMEoe5wGAsLZJdJiUZQuDKwSGq9mg/m84R4KGPTZ8.jpg "transl1")

**Scaling**

Unlike translation that is a matrix addition, scaling is a multiplication. An object is scale by multiplying its values along one or more directions. To scale a point the operation takes its x y and z and multiplies it by a matrix that will only affect each individual component, like this:

![scale1](https://sun4-12.userapi.com/_75aqsVIyfbMY1VBfycG4y7S1PtQ4ufGPiwTzg/W0O2G_eTUDM.jpg "scale1")

**Rotation**

* Rotation in 2D space:

![rotate1](https://sun4-16.userapi.com/Ay6TAjGvnqNmF1ViL5PuING61s1csxdjX9TK9A/cklBkqhynzs.jpg "rotate1")

* A roll Around the Z Axis in 3D Space:

![rotate2](https://sun4-17.userapi.com/clFbeMrxeNM96ELO1xjp0S9w_S_TNBqD-FtI8g/soUHFT70C98.jpg "rotate2")

* A Y-Roll (Yaw)

![rotate3](https://sun4-12.userapi.com/4_FJVT9adjUdY2S-ouY8FVqLKUSvNvMX8nFZuQ/TwMP2IuDLPY.jpg "rotate3")

* A X-Roll (Pitch)

![rotate4](https://sun4-10.userapi.com/fWvgdsXEkO5EvxzO9E1ka373F7Bd9HkjamkqxQ/06dYuzZx6YY.jpg "rotate4")

To build a complex rotational matrix that rotates around all angels, we multiplied the X-Roll Y-Roll and Z-Roll matrices together like this, there angle theta is a X-Roll, Alpha the Y-Roll and Beta is the Z-Roll.

![rotate5](https://sun4-17.userapi.com/ziA12QvU23WTVK0Hkr66Ou-YhqRNA6Wp0CFLjA/ziy2Ll2-Jw4.jpg "rotate5")

This angles **Theta, Alpha and Beta** are called **Euler Angles**.